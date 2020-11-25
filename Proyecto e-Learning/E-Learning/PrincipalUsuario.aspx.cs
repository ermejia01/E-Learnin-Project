using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFElearning;
using System.Data;

public partial class Principal : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    ServiceClient ws = new ServiceClient();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Mostrar_Cursos_Usuario();
    }

    public void Mostrar_Cursos_Usuario()
    {

        ds = ws.Mostrar_Cursos_Usuario(1,1);

        if (ds != null)
        {
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gdvCategoria1.Visible = true;
                    gdvCategoria1.DataSource = ds;
                    gdvCategoria1.DataMember = ds.Tables[0].TableName;
                    gdvCategoria1.DataBind();
                }
                else
                    lblMensaje1.Text = "No se encontro ningun curso";
            }
            else
                lblMensaje1.Text = "No se encontro datos";
        }
        else
            lblMensaje1.Text = "No se encontraron datos";

        ds = ws.Mostrar_Cursos_Usuario(1, 2);
        if (ds != null)
        {
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gdvCategoria2.Visible = true;
                    gdvCategoria2.DataSource = ds;
                    gdvCategoria2.DataMember = ds.Tables[0].TableName;
                    gdvCategoria2.DataBind();
                }
                else
                    lblMensaje2.Text = "No se encontro ningun curso";
            }
            else
                lblMensaje2.Text = "No se encontro datos";
        }
        else
            lblMensaje2.Text = "No se encontro datos";


        ds = ws.Mostrar_Cursos_Usuario(1, 3);
        if (ds != null)
        {
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gdvCategoria3.Visible = true;
                    gdvCategoria3.DataSource = ds;
                    gdvCategoria3.DataMember = ds.Tables[0].TableName;
                    gdvCategoria3.DataBind();
                }
                else
                    lblMensaje3.Text = "No se encontro ningun curso";
            }
            else
                lblMensaje3.Text = "No se encontro datos";
        }
        else
            lblMensaje3.Text = "No se encontro datos";

        ds = ws.Mostrar_Cursos_Usuario(1, 4);
        if (ds != null)
        {
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gdvCategoria4.Visible = true;
                    gdvCategoria4.DataSource = ds;
                    gdvCategoria4.DataMember = ds.Tables[0].TableName;
                    gdvCategoria4.DataBind();
                }
                else
                    lblMensaje4.Text = "No se encontro ningun curso";
            }
            else
                lblMensaje4.Text = "No se encontro datos";
        }
        else
            lblMensaje4.Text = "No se encontro datos";
    }

    protected void gdvCategoria1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Inscribir")
        {
            Response.Redirect("~/ValidacionInscripcion.aspx");
        }
        if (e.CommandName == "Ver")
        {
            Response.Redirect("~/DesarrolloCursos.aspx");
        }
    }

    protected void gdvCategoria2_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
}