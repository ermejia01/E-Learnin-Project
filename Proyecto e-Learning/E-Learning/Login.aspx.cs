using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    string usuario, contraseña;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        CargarValores();
    }
    public void CargarValores()
    {
        if (txtUsuario.Text.ToString().Length == 0 | txtContraseña.Text.ToString().Length == 0)
        {
            lblMensaje.Text = "usuario o contraseña vacios";
            lblMensaje.Visible = true;
            return;
        }
        else
        {
            lblMensaje.Visible = false;
            Response.Redirect("~/PrincipalUsuario.aspx");
        }
    }
}