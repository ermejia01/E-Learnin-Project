<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidacionInscripcion.aspx.cs" Inherits="ValidacionInscripcion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title>Proyecto Vicky - Inscripcion</title>
    <link rel="stylesheet" type="text/css" href="/Estilos/EstilosPrincipalUsuario.css"/>

    <style type="text/css">
        .auto-style1 {
            height: 21px;
        }
        .auto-style2 {
            height: 38px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div class="bodyglobal">
        <div class="header">
            <a href="PrincipalUsuario.aspx"><img id="Vikyimage" src="Imagenes/VikyAzul.png" alt="" /></a>
            <nav>
                <ul>
                    <li>Proyecto Vicky</li>
                </ul>
            </nav>
            <nav style="float:right; padding-top:10px; margin-right:0;">
                <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>&nbsp
                <asp:Button ID="btnCerrarSesion" runat="server" Font-Overline="False" Font-Size="8pt" Text="Cerrar Sesion" OnClick="btnCerrarSesion_Click" />
            </nav>
        </div>
        <div>

            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#000099" Text="Validacion!!"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/Felicidades.jpg" Height="434px" Width="1101px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnVolver" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="0px" Font-Bold="False" Font-Overline="False" ForeColor="#000099" Height="25px" OnClick="btnVolver_Click" Text="Volver a Cursos" Width="168px" Font-Underline="True" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
        <div class="footer">
            Derechos reservados Proyecto Viky
        </div>    
    </div>
    </form>
</body>
</html>
