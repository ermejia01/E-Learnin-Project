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
    DataSet dsInscripcion = new DataSet();
    int enviado = 0;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        lblUsuario.Text = Session["Cod_Usuario"].ToString();
        Mostrar_Cursos_Usuario();
    }

    public void Mostrar_Cursos_Usuario()
    {
        ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()),1);

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

        ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()), 2);
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


        ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()), 3);
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

        ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()), 4);
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
            int indicefila = int.Parse(e.CommandArgument.ToString());
            
            ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()), 1);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int ID_Curso = int.Parse(ds.Tables[0].Rows[indicefila]["CODIGO"].ToString());
                        string Estado = ds.Tables[0].Rows[indicefila]["ESTADO"].ToString();

                        if (Estado == "Inscrito")
                        {
                            lblInscripcion.Text = "Ya estas inscrito al Curso Seleccionado";
                        }
                        else
                        {
                            dsInscripcion = ws.Insertar_Inscripciones(enviado,int.Parse(Session["ID_Usuario"].ToString()),ID_Curso);
                            Response.Redirect("~/ValidacionInscripcion.aspx");
                        }

                    }
                }
                else
                {
                    lblMensaje1.Text = "No se encontraron Datos";
                }
            }
            else
            {
                lblMensaje1.Text = "No se Cargo la Consulta";
            }
        }
        if (e.CommandName == "Ver")
        {
            int indicefila = int.Parse(e.CommandArgument.ToString());

            ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()), 1);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int ID_Curso = int.Parse(ds.Tables[0].Rows[indicefila]["CODIGO"].ToString());
                        string Estado = ds.Tables[0].Rows[indicefila]["ESTADO"].ToString();
                        string Descripcion = ds.Tables[0].Rows[indicefila]["NOMBRE"].ToString();

                        if (Estado == "Inscrito")
                        {
                            Session["ID_Curso"] = ID_Curso;
                            Session["Nombre_Curso"] = Descripcion;
                            Response.Redirect("~/DesarrolloCursos.aspx");
                            lblInscripcion.Text = "";
                        }
                        else
                        {
                            lblInscripcion.Text = "No estas Inscrito al curso seleccionado";
                        }

                    }
                }
                else
                {
                    lblMensaje1.Text = "No se encontraron Datos";
                }
            }
            else
            {
                lblMensaje1.Text = "No se Cargo la Consulta";
            }
        }
    }

    protected void gdvCategoria2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Inscribir")
        {
            int indicefila = int.Parse(e.CommandArgument.ToString());

            ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()), 2);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int ID_Curso = int.Parse(ds.Tables[0].Rows[indicefila]["CODIGO"].ToString());
                        string Estado = ds.Tables[0].Rows[indicefila]["ESTADO"].ToString();

                        if (Estado == "Inscrito")
                        {
                            lblInscripcion.Text = "Ya estas inscrito al Curso Seleccionado";
                        }
                        else
                        {
                            dsInscripcion = ws.Insertar_Inscripciones(enviado, int.Parse(Session["ID_Usuario"].ToString()), ID_Curso);
                            Response.Redirect("~/ValidacionInscripcion.aspx");
                        }

                    }
                }
                else
                {
                    lblMensaje1.Text = "No se encontraron Datos";
                }
            }
            else
            {
                lblMensaje1.Text = "No se Cargo la Consulta";
            }
        }
        if (e.CommandName == "Ver")
        {
            int indicefila = int.Parse(e.CommandArgument.ToString());

            ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()), 2);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int ID_Curso = int.Parse(ds.Tables[0].Rows[indicefila]["CODIGO"].ToString());
                        string Estado = ds.Tables[0].Rows[indicefila]["ESTADO"].ToString();
                        string Descripcion = ds.Tables[0].Rows[indicefila]["NOMBRE"].ToString();

                        if (Estado == "Inscrito")
                        {
                            Session["ID_Curso"] = ID_Curso;
                            Session["Nombre_Curso"] = Descripcion;
                            Response.Redirect("~/DesarrolloCursos.aspx");
                            lblInscripcion.Text = "";
                        }
                        else
                        {
                            lblInscripcion.Text = "No estas Inscrito al curso seleccionado";
                        }

                    }
                }
                else
                {
                    lblMensaje1.Text = "No se encontraron Datos";
                }
            }
            else
            {
                lblMensaje1.Text = "No se Cargo la Consulta";
            }
        }
    }

    protected void btnCerrarSesion_Click(object sender, EventArgs e)
    {
        Session["Cod_Usuario"] = null;
        Response.Redirect("~/Login.aspx");
    }

    protected void gdvCategoria3_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Inscribir")
        {
            int indicefila = int.Parse(e.CommandArgument.ToString());

            ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()), 3);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int ID_Curso = int.Parse(ds.Tables[0].Rows[indicefila]["CODIGO"].ToString());
                        string Estado = ds.Tables[0].Rows[indicefila]["ESTADO"].ToString();

                        if (Estado == "Inscrito")
                        {
                            lblInscripcion.Text = "Ya estas inscrito al Curso Seleccionado";
                        }
                        else
                        {
                            dsInscripcion = ws.Insertar_Inscripciones(enviado, int.Parse(Session["ID_Usuario"].ToString()), ID_Curso);
                            Response.Redirect("~/ValidacionInscripcion.aspx");
                        }

                    }
                }
                else
                {
                    lblMensaje1.Text = "No se encontraron Datos";
                }
            }
            else
            {
                lblMensaje1.Text = "No se Cargo la Consulta";
            }
        }
        if (e.CommandName == "Ver")
        {
            int indicefila = int.Parse(e.CommandArgument.ToString());

            ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()), 3);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int ID_Curso = int.Parse(ds.Tables[0].Rows[indicefila]["CODIGO"].ToString());
                        string Estado = ds.Tables[0].Rows[indicefila]["ESTADO"].ToString();
                        string Descripcion = ds.Tables[0].Rows[indicefila]["NOMBRE"].ToString();

                        if (Estado == "Inscrito")
                        {
                            Session["ID_Curso"] = ID_Curso;
                            Session["Nombre_Curso"] = Descripcion;
                            Response.Redirect("~/DesarrolloCursos.aspx");
                            lblInscripcion.Text = "";
                        }
                        else
                        {
                            lblInscripcion.Text = "No estas Inscrito al curso seleccionado";
                        }

                    }
                }
                else
                {
                    lblMensaje1.Text = "No se encontraron Datos";
                }
            }
            else
            {
                lblMensaje1.Text = "No se Cargo la Consulta";
            }
        }
    }

    protected void gdvCategoria4_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Inscribir")
        {
            int indicefila = int.Parse(e.CommandArgument.ToString());

            ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()), 4);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int ID_Curso = int.Parse(ds.Tables[0].Rows[indicefila]["CODIGO"].ToString());
                        string Estado = ds.Tables[0].Rows[indicefila]["ESTADO"].ToString();

                        if (Estado == "Inscrito")
                        {
                            lblInscripcion.Text = "Ya estas inscrito al Curso Seleccionado";
                        }
                        else
                        {
                            dsInscripcion = ws.Insertar_Inscripciones(enviado, int.Parse(Session["ID_Usuario"].ToString()), ID_Curso);
                            Response.Redirect("~/ValidacionInscripcion.aspx");
                        }

                    }
                }
                else
                {
                    lblMensaje1.Text = "No se encontraron Datos";
                }
            }
            else
            {
                lblMensaje1.Text = "No se Cargo la Consulta";
            }
        }
        if (e.CommandName == "Ver")
        {
            int indicefila = int.Parse(e.CommandArgument.ToString());

            ds = ws.Mostrar_Cursos_Usuario(int.Parse(Session["ID_Usuario"].ToString()), 4);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int ID_Curso = int.Parse(ds.Tables[0].Rows[indicefila]["CODIGO"].ToString());
                        string Estado = ds.Tables[0].Rows[indicefila]["ESTADO"].ToString();
                        string Descripcion = ds.Tables[0].Rows[indicefila]["NOMBRE"].ToString();

                        if (Estado == "Inscrito")
                        {
                            Session["ID_Curso"] = ID_Curso;
                            Session["Nombre_Curso"] = Descripcion;
                            Response.Redirect("~/DesarrolloCursos.aspx");
                            lblInscripcion.Text = "";
                        }
                        else
                        {
                            lblInscripcion.Text = "No estas Inscrito al curso seleccionado";
                        }

                    }
                }
                else
                {
                    lblMensaje1.Text = "No se encontraron Datos";
                }
            }
            else
            {
                lblMensaje1.Text = "No se Cargo la Consulta";
            }
        }
    }
}