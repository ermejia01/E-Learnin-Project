using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFElearning;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    string usuario, contraseña;
    ServiceClient ws = new ServiceClient();
    DataSet ds = new DataSet();
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        CargarValores();
    }
    public void CargarValores()
    {
        if (txtUsuario.Text.Length != 0 | txtContraseña.Text.Length != 0)
        {

            ds = ws.Validar_usuario(txtUsuario.Text,txtContraseña.Text);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    int VALOR = int.Parse(ds.Tables[0].Rows[0]["ID_USUARIO"].ToString());
                    if (VALOR > 0)
                    {
                        Session["ID_Usuario"] = ds.Tables[0].Rows[0]["ID_Usuario"].ToString();
                        Session["Cod_usuario"] = ds.Tables[0].Rows[0]["Cod_Usuario"].ToString();
                        Session["ID_Privilegio"] = ds.Tables[0].Rows[0]["ID_Privilegio"].ToString();

                        if (Session["ID_Privilegio"].ToString() == "1") // tipo administrador
                        {
                            txtUsuario.Text = string.Empty;
                            Response.Redirect("~/PrincipalAdmin.aspx");
                            lblMensaje.Text = "";
                        }
                        if (Session["ID_Privilegio"].ToString() == "2")
                        {
                            txtUsuario.Text = string.Empty;
                            Response.Redirect("~/PrincipalUsuario.aspx");
                            lblMensaje.Text = "";
                        }
                    }
                    else
                    {
                        lblMensaje.Text = "El usuario ingresado no existe";
                        lblMensaje.Visible = true;
                        Session["Cod_usuario"] = null;
                    }
                }
                else
                {
                    lblMensaje.Text = "No se encontro ningun usuario";
                    Session["Cod_Usuario"] = null;
                }
            }
            else
            {
                lblMensaje.Text = "No se encontro ningun registro";
                Session["Cod_Usuario"] = null;
            }
        }
    }
}