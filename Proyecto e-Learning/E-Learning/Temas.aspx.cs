using System; 
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFElearning;

public partial class Temas : System.Web.UI.Page
{
    ServiceClient ws = new ServiceClient();
    DataSet ds = new DataSet();
    DataSet dsCategorias = new DataSet();
    DataSet dsCursos = new DataSet(); 

    protected void Page_Load(object sender, EventArgs e)
    {
        lblUsuario.Text = Session["Cod_Usuario"].ToString();
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

                ds = ws.Mostrar_Temas();

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Mostrar_Temas();
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

    private void Mostrar_Temas()
    {
        ds = ws.Mostrar_Temas();
        if (ds.Tables.Count > 0)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                gdwTemas.Visible = true;
                gdwTemas.DataSource = ds;
                gdwTemas.DataMember = ds.Tables[0].TableName;
                gdwTemas.DataBind();
            }
            else
            {
                lblMensajesGrid.Text = "No se encontro ningun Contenido";
            }
        }
    }

    protected void Categoria_Click(object sender, EventArgs e)
    {
        Response.Redirect("CategoriasCursos.aspx");
    }

    protected void Cursos_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cursos.aspx");
    }


    protected void Temas_Click(object sender, EventArgs e)
    {
        Response.Redirect("Temas.aspx");
    }


    protected void Contenido_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContenidoTemas.aspx");
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    { 
        if (txtDescripcion.Text == null || txtDescripcion.Text == "")
        {
            lblMensajes.Text = "el nombre del tema no puede estar vacio";
        }
        else
        {
            ws.Insertar_Temas(txtDescripcion.Text, int.Parse(ddlCurso.SelectedValue),int.Parse(ddlCategoria.SelectedValue));
            Mostrar_Temas();
            dsCategorias = ws.Mostrar_Categorias();
            txtDescripcion.Text = "";
            txtID_Tema.Text = "";
        }
    }

    protected void btnModificar_Click(object sender, EventArgs e)
    { 
        ws.Modificar_Temas(int.Parse(txtID_Tema.Text), txtDescripcion.Text, int.Parse(ddlCurso.SelectedValue),int.Parse(ddlCategoria.SelectedValue));
        Mostrar_Temas();
        dsCategorias = ws.Mostrar_Categorias();
        txtDescripcion.Text = "";
        txtID_Tema.Text = "";
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtID_Tema.Text != "" | txtDescripcion.Text != "")
        {
            ds = ws.Buscar_Temas(int.Parse(txtID_Tema.Text), txtDescripcion.Text);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtID_Tema.Text = ds.Tables[0].Rows[0]["ID_TEMA"].ToString();
                    txtDescripcion.Text = ds.Tables[0].Rows[0]["NOMBRE_TEMA"].ToString();
                    ddlCategoria.SelectedValue = ds.Tables[0].Rows[0]["ID_CATEGORIA"].ToString();

                    dsCursos = ws.Mostrar_Cursos_xCategoria(int.Parse(ds.Tables[0].Rows[0]["ID_CURSO"].ToString()));
                    if (dsCursos.Tables.Count > 0)
                    {
                        if (dsCursos.Tables[0].Rows.Count > 0)
                        {
                            ddlCurso.DataSource = dsCursos;
                            ddlCurso.DataMember = "DataCursos";
                            ddlCurso.DataValueField = "ID_Curso";
                            ddlCurso.DataTextField = "Nombre_Curso";
                            ddlCurso.DataBind();
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

                     ddlCurso.SelectedValue = ds.Tables[0].Rows[0]["ID_CURSO"].ToString();
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

    protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
        int Codigo;

        Codigo = int.Parse(ddlCategoria.SelectedValue);

        dsCursos = ws.Mostrar_Cursos_xCategoria(Codigo);
        if (dsCursos.Tables.Count > 0)
        {
            if (dsCursos.Tables[0].Rows.Count > 0)
            {
                ddlCurso.DataSource = dsCursos;
                ddlCurso.DataMember = "DataCursos";
                ddlCurso.DataValueField = "ID_Curso";
                ddlCurso.DataTextField = "Nombre_Curso";
                ddlCurso.DataBind();
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

    protected void Usuarios_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroUsuario.aspx");
    }

    protected void btnCerrarSesion_Click(object sender, EventArgs e)
    {
        Session["Cod_Usuario"] = null;
        Response.Redirect("~/Login.aspx");
    }
}