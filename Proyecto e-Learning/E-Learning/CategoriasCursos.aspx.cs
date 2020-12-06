using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFElearning;
using System.Data;

public partial class CategoriasCursos : System.Web.UI.Page
{
    ServiceClient ws = new ServiceClient();
    DataSet ds = new DataSet();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Mostrar_Categorias();
        }
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        if (txtNombre_cat.Text == null | txtNombre_cat.Text == "")
        {
            lblMensaje.Text = "el nombre no puede estar vacio";
        }
        else
        {
            ws.Insertar_Categorias(txtNombre_cat.Text);
            Mostrar_Categorias();

            txtNombre_cat.Text = "";
            txtID_Cat.Text = ""; 

        }
    }

    public void Mostrar_Categorias()
    {
       ds = ws.Mostrar_Categorias();
        gdwCategorias.Visible = true;
        gdwCategorias.DataSource = ds;
        gdwCategorias.DataMember = ds.Tables[0].TableName;
        gdwCategorias.DataBind();
    }

    protected void btnModificar_Click(object sender, EventArgs e)
    { 
        ws.Modificar_Categorias(int.Parse(txtID_Cat.Text), txtNombre_cat.Text); 
        Mostrar_Categorias(); 
        txtID_Cat.Text = "";
        txtNombre_cat.Text = ""; 

    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtID_Cat.Text != "" | txtNombre_cat.Text != "")
        {
            ds = ws.Buscar_Categoria(int.Parse(txtID_Cat.Text), txtNombre_cat.Text);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtID_Cat.Text = ds.Tables[0].Rows[0]["ID_CATEGORIA"].ToString();
                    txtNombre_cat.Text = ds.Tables[0].Rows[0]["NOMBRE_CAT"].ToString();
                     
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

    protected void IrUsuarios_Click(object sender, EventArgs e)
    {
        //Response.Redirect("Page.aspx");
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