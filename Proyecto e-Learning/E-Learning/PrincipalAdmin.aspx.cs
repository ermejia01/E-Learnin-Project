using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PrincipalAdmin : System.Web.UI.Page
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

    protected void btnUsuarios_Click(object sender, EventArgs e)
    {
        lblUsuario.Text = Session["Cod_Usuario"].ToString();
        Response.Redirect("~/RegistroUsuario.aspx");
    }

    protected void btnCat_Click(object sender, EventArgs e)
    {
        lblUsuario.Text = Session["Cod_Usuario"].ToString();
        Response.Redirect("~/CategoriasCursos.aspx");
    }

    protected void btnCursos_Click(object sender, EventArgs e)
    {
        lblUsuario.Text = Session["Cod_Usuario"].ToString();
        Response.Redirect("~/Cursos.aspx");
    }

    protected void Temas_Click(object sender, EventArgs e)
    {
        lblUsuario.Text = Session["Cod_Usuario"].ToString();
        Response.Redirect("~/TemasCursos.aspx");
    }

    protected void btnContenidos_Click(object sender, EventArgs e)
    {
        lblUsuario.Text = Session["Cod_Usuario"].ToString();
        Response.Redirect("~/ContenidoTemas.aspx");
    }
}