using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ValidacionInscripcion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblUsuario.Text = Session["Cod_Usuario"].ToString();
    }

    protected void btnCerrarSesion_Click(object sender, EventArgs e)
    {
        Session["Cod_Usuario"] = null;
        Response.Redirect("~/Login.aspx");
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PrincipalUsuario.aspx");
    }
}