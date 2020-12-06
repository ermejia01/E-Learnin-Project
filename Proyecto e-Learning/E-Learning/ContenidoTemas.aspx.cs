using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFElearning;
using System.Data;

public partial class ContenidoTemas : System.Web.UI.Page
{
    ServiceClient ws = new ServiceClient();
    DataSet ds = new DataSet();
    DataSet dsCategorias = new DataSet();
    DataSet dsCursos = new DataSet();
    DataSet dsTemas = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                dsCategorias = ws.Mostrar_Categorias();
                if (dsCategorias.Tables.Count > 0)
                {
                    if (dsCategorias.Tables[0].Rows.Count > 0)
                    {
                        ddlCategoria.DataSource = dsCategorias;
                        ddlCategoria.DataMember = "Data de Categorias";
                        ddlCategoria.DataValueField ="Codigo";
                        ddlCategoria.DataTextField ="Nombre";
                        ddlCategoria.DataBind();
                        lblMensajes.Text = "";
                    }
                    else
                    {
                        lblMensajes.Text = "No se encontro ninguna categoria";
                    }
                }
                else
                {
                    lblMensajes.Text = "No se encontraron datos";
                }

                ds = ws.Mostrar_Contenidos();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Mostrar_Contenidos();
                    }
                    else
                    {
                        lblMensajesGrid.Text = "No se encontro ningun Contenido";
                    }
                }
                else
                {
                    lblMensajesGrid.Text = "No se encontraron registros";
                }
            }
        }
        catch (Exception ex)
        {
            lblMensajes.Text = ex.Message;
        }
    }

    protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Codigo;

        Codigo = int.Parse(ddlCategoria.SelectedValue);

        dsCursos = ws.Mostrar_Cursos_xCategoria(Codigo);
        if (dsCursos.Tables.Count > 0)
        {
            if (dsCursos.Tables[0].Rows.Count > 0)
            {
                ddlCursos.DataSource = dsCursos;
                ddlCursos.DataMember = "DataCursos";
                ddlCursos.DataValueField = "ID_Curso";
                ddlCursos.DataTextField = "Nombre_Curso";
                ddlCursos.DataBind();
                lblMensajes.Text = "";
            }
            else
            {
                lblMensajes.Text = "No se encontro ningun curso";
            }
        }
        else
        {
            lblMensajes.Text = "No se encontraron Datos de Cursos";
        }

    }

    protected void ddlCursos_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Codigo;

        Codigo = int.Parse(ddlCursos.SelectedValue);

        dsTemas = ws.Mostrar_Temas_xCursos(Codigo);
        if (dsTemas.Tables.Count > 0)
        {
            if (dsTemas.Tables[0].Rows.Count > 0)
            {
                ddlTema.DataSource = dsTemas;
                ddlTema.DataMember = "Data de Temas por Curso";
                ddlTema.DataValueField = "ID_Tema";
                ddlTema.DataTextField = "Nombre_Tema";
                ddlTema.DataBind();
                lblMensajes.Text = "";
            }
            else
            {
                lblMensajes.Text = "No se encontro ningun Tema";
            }
        }
        else
        {
            lblMensajes.Text = "No se encontraron Datos de temas";
        }
    }



    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        byte[] archivo;
        
        archivo = ws.RetornarStringEnBytes(txtArchivo.Text);

        ws.Insertar_Contenidos(txtDescripcion.Text,ddlTipo.Text,int.Parse(ddlCategoria.SelectedValue),int.Parse(ddlCursos.SelectedValue),int.Parse(ddlTema.SelectedValue),archivo);

        Mostrar_Contenidos();

        txtDescripcion.Text = "";
        ddlTipo.Text = "";
        txtArchivo.Text = "";
    }

    public void Mostrar_Contenidos()
    {
        ds = ws.Mostrar_Contenidos();
        if (ds.Tables.Count > 0)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                gdwContenidos.Visible = true;
                gdwContenidos.DataSource = ds;
                gdwContenidos.DataMember = ds.Tables[0].TableName;
                gdwContenidos.DataBind();
            }
            else
            {
                lblMensajesGrid.Text = "No se encontro ningun Contenido";
            }
        }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtID_Contenido.Text != "" | txtDescripcion.Text != "")
        {
            ds = ws.Buscar_Contenidos(int.Parse(txtID_Contenido.Text), txtDescripcion.Text);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtID_Contenido.Text = ds.Tables[0].Rows[0]["ID_Contenido"].ToString();
                    txtDescripcion.Text = ds.Tables[0].Rows[0]["Descripcion"].ToString();
                    ddlTipo.Text = ds.Tables[0].Rows[0]["Tipo"].ToString();
                    ddlCategoria.SelectedValue = ds.Tables[0].Rows[0]["ID_Categoria"].ToString();
                    ddlCursos.SelectedValue = ds.Tables[0].Rows[0]["ID_Curso"].ToString();
                    ddlTema.SelectedValue = ds.Tables[0].Rows[0]["ID_Tema"].ToString();
                    txtArchivo.Text = ws.RetornarByteEnString((byte[])ds.Tables[0].Rows[0]["Archivo"]);
                }
                else
                {
                    lblMensajes.Text = "No se encontro ningun contenido";
                }
            }
            else
            {
                lblMensajes.Text = "No se encontraron registros";
            }
        }

    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        byte[] archivo;

        archivo = ws.RetornarStringEnBytes(txtArchivo.Text);

        ws.Modificar_Contenidos(int.Parse(txtID_Contenido.Text),txtDescripcion.Text, ddlTipo.Text, int.Parse(ddlCategoria.SelectedValue), int.Parse(ddlCursos.SelectedValue), int.Parse(ddlTema.SelectedValue), archivo);

        Mostrar_Contenidos();

        txtID_Contenido.Text = "";
        txtDescripcion.Text = "";
        ddlTipo.Text = "";
        txtArchivo.Text = "";
    }

    protected void Cursos_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cursos.aspx");
    }

    protected void Categoria_Click(object sender, EventArgs e)
    {
        Response.Redirect("CategoriasCursos.aspx");
    }

    protected void Contenido_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContenidoTemas.aspx");
    }

    protected void Temas_Click(object sender, EventArgs e)
    {
        Response.Redirect("Temas.aspx");
    }
}