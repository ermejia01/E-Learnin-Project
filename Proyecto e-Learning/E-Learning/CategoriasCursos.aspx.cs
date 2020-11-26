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
}