using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using WCFElearning;

public partial class Registro : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    ServiceClient ws = new ServiceClient();
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEnviar0_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Login.aspx");
    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        ds = ws.Registro_usuario(txtCodigo.Text, txtNombres.Text, txtApellido.Text,int.Parse(txtEdad.Text),ddlSexo.SelectedValue, txtFechaNac.Text, txtPais.Text, ddlDepto.SelectedValue, txtTelefono.Text, txtMail.Text,txtPasword.Text);

        if (ds.Tables.Count > 0)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                int valor = int.Parse(ds.Tables[0].Rows[0]["Resultado"].ToString());
                if (valor > 0)
                {
                    lblMensajes.Text = "Registro Guardado Correctamente, clic en regresar al login";
                    LimpiarValores();
                }

                if (valor == -1)
                {
                    lblMensajes.Text = "Codigo ya se encuentra en nuestros registro coloque otro Codigo";
                }
            }
        }
    }

    public void LimpiarValores()
    {
        txtCodigo.Text = "";
        txtNombres.Text = "";
        txtApellido.Text = "";
        txtEdad.Text = "";
        ddlSexo.SelectedValue ="Masculino";
        txtFechaNac.Text = "";
        txtPais.Text = "";
        ddlDepto.SelectedValue = "San Salvador";
        txtTelefono.Text = "";
        txtMail.Text = "";
        txtPasword.Text = "";
    }
}