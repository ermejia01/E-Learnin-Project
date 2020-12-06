using System;
using System.Data;
using WCFElearning;

public partial class Privilegios : System.Web.UI.Page
{
    ServiceClient ws = new ServiceClient();

    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Mostrar_Privilegios();
        }
    }

    private void Mostrar_Privilegios()
    {
        ds = ws.Mostrar_Privilegios();
        gdwPrivilegios.Visible = true;
        gdwPrivilegios.DataSource = ds;
        gdwPrivilegios.DataMember = ds.Tables[0].TableName;
        gdwPrivilegios.DataBind();
    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        ws.Modificar_Privilegio(int.Parse(txtID_Privilegio.Text), txtNombre_privilegio.Text);
        Mostrar_Privilegios();
        txtID_Privilegio.Text = "";
        txtNombre_privilegio.Text = "";
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        if (txtNombre_privilegio.Text == null || txtNombre_privilegio.Text == "")
        {
            lblMensaje.Text = "el nombre no puede estar vacio";
        }
        else
        {
            ws.Insertar_Privilegio(txtNombre_privilegio.Text);
            Mostrar_Privilegios();

            txtNombre_privilegio.Text = "";
            txtID_Privilegio.Text = "";

        }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtID_Privilegio.Text != "" | txtNombre_privilegio.Text != "")
        {
            ds = ws.Buscar_Privilegio(int.Parse(txtID_Privilegio.Text), txtNombre_privilegio.Text);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtID_Privilegio.Text = ds.Tables[0].Rows[0]["ID_PRIVILEGIO"].ToString();
                    txtNombre_privilegio.Text = ds.Tables[0].Rows[0]["NOMBRE_PRIVILEGIO"].ToString();

                }
                else
                {
                    lblMensaje.Text = "No se encontro ningun contenido";
                }
            }
            else
            {
                lblMensaje.Text = "No se encontraron registros";
            }
        }
    }

    protected void Privilegio_Click(object sender, EventArgs e)
    {
        Response.Redirect("Privilegios.aspx");
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

    protected void Usuarios_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroUsuario.aspx");
    }
}