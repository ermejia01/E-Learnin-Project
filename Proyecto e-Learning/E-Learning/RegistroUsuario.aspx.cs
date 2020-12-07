using System;
using System.Data;
using WCFElearning;

public partial class RegistroUsuario : System.Web.UI.Page
{
    ServiceClient ws = new ServiceClient();
    DataSet ds = new DataSet();
    DataSet dsPrivilegio = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Mostrar_Usuarios();

            dsPrivilegio = ws.Mostrar_Privilegios();
            if (dsPrivilegio.Tables.Count > 0)
            {
                if (dsPrivilegio.Tables[0].Rows.Count > 0)
                {
                    ddlPrivilegio.DataSource = dsPrivilegio;
                    ddlPrivilegio.DataMember = "DataContenidos";
                    ddlPrivilegio.DataValueField = "Codigo";
                    ddlPrivilegio.DataTextField = "Privilegio";
                    ddlPrivilegio.DataBind();
                    lblMensajes.Text = "";
                }
                else
                {
                    lblMensajes.Text = "No se encontro ningun privilegio";
                }
            }
            else
            {
                lblMensajes.Text = "No se encontraron datos";
            }

        }
    }

    private void Mostrar_Usuarios()
    {
        ds = ws.Mostrar_Usuarios();
        gdwUsuarios.Visible = true;
        gdwUsuarios.DataSource = ds;
        gdwUsuarios.DataMember = ds.Tables[0].TableName;
        gdwUsuarios.DataBind();
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {

         
        if (txtID_Codigo.Text == null || txtID_Codigo.Text == "")
        {
            lblMensajes.Text = "Codigo puede estar vacio";
        }
        if (txtNombre.Text == null || txtNombre.Text == "")
        {
            lblMensajes.Text = "Nombre puede estar vacio";
        }
       
        else
        {
            DateTime fecharegistro = DateTime.Today;
            DateTime fechanac = Calendar_usuario.SelectedDate;
            ws.Insertar_Usuarios(txtID_Codigo.Text, txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), ddlSexo.SelectedValue, fechanac, txtPais.Text, txtDepartamento.Text,txt_telefono.Text, txt_correo.Text, txt_password.Text, FileUpload_image.FileName.ToString(), int.Parse(ddlPrivilegio.SelectedValue), fecharegistro);
           
            Mostrar_Usuarios();
           
            txtID_Codigo.Text = "";
            txtNombre.Text = ""; 
            txtApellido.Text = ""; 
            txt_password.Text = "";
            txt_correo.Text = "";
            txt_password.Text = "";
            txt_telefono.Text = ""; 
            txtPais.Text = "";
            txtDepartamento.Text = "";
            txtEdad.Text = "";



        }


    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        DateTime fecharegistro = DateTime.Today;
        DateTime fechanac = Calendar_usuario.SelectedDate;

        ws.Modificar_Usuarios(txtID_Codigo.Text, txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), ddlSexo.SelectedValue, fechanac, txtPais.Text, txtDepartamento.Text, txt_telefono.Text, txt_correo.Text, txt_password.Text, FileUpload_image.FileName.ToString(), int.Parse(ddlPrivilegio.SelectedValue), fecharegistro);
        Mostrar_Usuarios(); 
        txtID_Codigo.Text = "";
        txtNombre.Text = "";
        txtApellido.Text = ""; 
        txt_password.Text = "";
        txt_correo.Text = "";
        txt_password.Text = "";
        txt_telefono.Text = "";
        txtPais.Text = "";
        txtDepartamento.Text = "";
        txtEdad.Text = "";
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtID_Codigo.Text != "" || txtNombre.Text != "")
        {
           ds = ws.Buscar_Usuarios( txtID_Codigo.Text );
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtID_Codigo.Text = ds.Tables[0].Rows[0]["COD_USUARIO"].ToString();
                    txtNombre.Text = ds.Tables[0].Rows[0]["NOMBRE"].ToString();
                    txtApellido.Text = ds.Tables[0].Rows[0]["APELLIDO"].ToString(); 
                    txt_password.Text = ds.Tables[0].Rows[0]["PASWORD"].ToString();
                    txt_correo.Text = ds.Tables[0].Rows[0]["EMAIL"].ToString();
                     
                    txt_telefono.Text = ds.Tables[0].Rows[0]["TELEFONO"].ToString();
                    txtPais.Text = ds.Tables[0].Rows[0]["PAIS"].ToString();
                    txtDepartamento.Text = ds.Tables[0].Rows[0]["DEPTO"].ToString();
                    txtEdad.Text = ds.Tables[0].Rows[0]["EDAD"].ToString();
                    ddlSexo.SelectedValue = ds.Tables[0].Rows[0]["SEXO"].ToString();
                    ddlPrivilegio.SelectedValue = ds.Tables[0].Rows[0]["ID_PRIVILEGIO"].ToString();
                     
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

    protected void Usuarios_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroUsuario.aspx");
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
}