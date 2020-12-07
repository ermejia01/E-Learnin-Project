<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrincipalAdmin.aspx.cs" Inherits="PrincipalAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Proyecto Viki - Administracion</title>
    <link rel="stylesheet" type="text/css" href="Estilos/EstilosPrincipalAdmin.css"/>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: left;
            width: 341px;
        }
        .auto-style3 {
            width: 341px;
        }
        .auto-style4 {
            width: 341px;
            height: 54px;
        }
        .auto-style5 {
            height: 54px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="btnMenu" runat="server" BackColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Roboto" Font-Size="20pt" ForeColor="#0099CC" Text="Menu" Width="286px" />
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnUsuarios" runat="server" BackColor="#000099" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Usuarios" Width="286px" OnClick="btnUsuarios_Click" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                    <td rowspan="8">
                        <asp:Image ID="Image1" runat="server" Height="395px" ImageUrl="~/Imagenes/Portada.jpg" Width="790px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnCat" runat="server" BackColor="#000099" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Categorias de Cursos" Width="286px" OnClick="btnCat_Click" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnCursos" runat="server" BackColor="#000099" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Cursos" Width="286px" OnClick="btnCursos_Click" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Temas" runat="server" BackColor="#000099" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Temas" Width="286px" OnClick="Temas_Click" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnContenidos" runat="server" BackColor="#000099" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Contenidos" Width="286px" OnClick="btnContenidos_Click" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnPrivilegios" runat="server" BackColor="#000099" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Privilegios" Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
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
