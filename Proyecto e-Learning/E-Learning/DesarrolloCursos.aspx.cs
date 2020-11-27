using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFElearning;
using System.Data;
using System.Text;

public partial class DesarrolloCursos : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    ServiceClient ws = new ServiceClient();
    DataTable datos = new DataTable();
    StringBuilder strbcadena = new StringBuilder();

    string cadena;

    protected void Page_Load(object sender, EventArgs e)
    {
        CargarTemas();

    }

    public void CargarTemas()
    {
        ds = ws.Mostrar_Temas_xCursos(3);

        if (ds != null)
        {
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gdwTemas.Visible = true;
                    gdwTemas.DataSource = ds;
                    gdwTemas.DataMember = ds.Tables[0].TableName;
                    gdwTemas.DataBind();
                }

            }
        }
    }
    
    protected void gdwTemas_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Ver")
        {
            int indicefila = int.Parse(e.CommandArgument.ToString());

            ds = ws.Mostrar_Temas_xCursos(3);
            int ID_Tema = int.Parse(ds.Tables[0].Rows[indicefila]["ID_Tema"].ToString());

            DataSet contenidos = new DataSet();

            contenidos = ws.Mostrar_Contenidos_XTemas(ID_Tema);
            gdwContenidos.Visible = true;
            gdwContenidos.DataSource = contenidos;
            gdwContenidos.DataMember = contenidos.Tables[0].TableName;
            gdwContenidos.DataBind();

            string Tema = ds.Tables[0].Rows[indicefila]["Nombre_Tema"].ToString();

            lblNombre_Tema.Text = Tema;
            this.MostrarContenido.InnerHtml = "<p>Los mejores contenidos<p>";
        }
    }
    
    protected void gdwContenidos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Ver")
        {
            int indicefila = int.Parse(e.CommandArgument.ToString());

            ds = ws.Mostrar_Contenidos_XTemas(1);

            byte[] Archivobyte = (byte[])ds.Tables[0].Rows[indicefila]["Archivo"];

            string archivo;

            archivo = ws.RetornarByteEnString(Archivobyte);
            string tipo = ds.Tables[0].Rows[indicefila]["Tipo"].ToString();

            if (tipo == "Video")
            {
                cadena = "<iframe src = " + archivo + ">" + "</iframe>";
                strbcadena.Append(cadena);
                this.MostrarContenido.InnerHtml = cadena.ToString();
            }

            if (tipo == "Texto")
            {
                cadena = "<p>"+archivo+"</p>";
                strbcadena.Append(cadena);
                this.MostrarContenido.InnerHtml = cadena.ToString();
            }
        }
    }
}