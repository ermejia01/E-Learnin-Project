using System;
using System.Linq;
using System.Data;
using System.Web.UI;
using WCFElearning;

public partial class Cursos : System.Web.UI.Page
{
    ServiceClient ws = new ServiceClient();
    DataSet ds = new DataSet();
    DataSet dsCategorias = new DataSet();

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
                        ddlCategoria.DataValueField = "Codigo";
                        ddlCategoria.DataTextField = "Nombre";
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
            }

            ds = ws.Mostrar_Cursos();

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                   Mostrar_Curso();
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
        catch (Exception ex)
        {
            lblMensajes.Text = ex.Message;
        }
    }

    private void Mostrar_Curso()
    {
        ds = ws.Mostrar_Cursos();
        if (ds.Tables.Count > 0)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                gdwCursos.Visible = true;
                gdwCursos.DataSource = ds;
                gdwCursos.DataMember = ds.Tables[0].TableName;
                gdwCursos.DataBind();
            }
            else
            {
                lblMensajesGrid.Text = "No se encontro ningun Contenido";
            }
        } 
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {

        string estatus = ddlEstatus.SelectedValue;
        int valorestatus = estatus == "True" ? 1 : 0;
        if (txtDescripcion.Text == null || txtDescripcion.Text == "")
        {
            lblMensajes.Text = "el nombre del curso no puede estar vacio";
        }
        else
        {
            ws.Insertar_Cursos(txtDescripcion.Text, int.Parse(ddlCategoria.SelectedValue), valorestatus);
            Mostrar_Curso();
            dsCategorias = ws.Mostrar_Categorias();
            txtDescripcion.Text = "";
            txtID_Curso.Text = "";
        }
    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        string estatus =   ddlEstatus.SelectedValue;
        int valorestatus = estatus == "True" ? 1 : 0;
        ws.Modificar_Cursos(int.Parse(txtID_Curso.Text), txtDescripcion.Text, int.Parse(ddlCategoria.SelectedValue), valorestatus);
        Mostrar_Curso();
        txtID_Curso.Text = "";
        txtDescripcion.Text = "";
         
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtID_Curso.Text != "" | txtDescripcion.Text != "")
        {
            ds = ws.Buscar_Cursos(int.Parse(txtID_Curso.Text), txtDescripcion.Text);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtID_Curso.Text = ds.Tables[0].Rows[0]["ID_CURSO"].ToString();
                    txtDescripcion.Text = ds.Tables[0].Rows[0]["NOMBRE_CURSO"].ToString();
                    ddlCategoria.SelectedValue = ds.Tables[0].Rows[0]["ID_CATEGORIA"].ToString(); 
                    ddlEstatus.SelectedValue = ds.Tables[0].Rows[0]["ESTADO"].ToString();
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