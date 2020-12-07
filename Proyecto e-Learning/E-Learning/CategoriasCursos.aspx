<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CategoriasCursos.aspx.cs" Inherits="CategoriasCursos" %>

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
            width: 381px;
        }
        .auto-style3 {
            width: 381px;
        }
        .auto-style4 {
            width: 381px;
            height: 64px;
        }
        .auto-style5 {
            height: 64px;
        }
        .auto-style6 {
            width: 193px;
        }
        .auto-style7 {
            text-align: center;
        }
        .auto-style8 {
            text-align: left;
        }
        .auto-style9 {
            width: 381px;
            height: 43px;
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
                <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                    <asp:Button ID="btnCerrarSesion" runat="server" Font-Overline="False" Font-Size="8pt" Text="Cerrar Sesion" OnClick="btnCerrarSesion_Click" />
            </nav>
        </div>
        <div>

            <table class="auto-style1">
                <tr>
                    <td colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnMenu" runat="server" BackColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Roboto" Font-Size="20pt" ForeColor="#0099CC" Text="Menu" Width="286px" />
                    </td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                              <asp:Button ID="btnUsuarios" runat="server" OnClick="Usuarios_Click" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt"  ForeColor="White" Height="60px" Text="Usuarios" Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                     </td>
                    <td colspan="3">
                        <asp:Label ID="Label1" runat="server" BorderStyle="None" Font-Bold="True" Font-Size="12pt" Font-Underline="True" Text="Categorias de Cursos"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"> 
                         <asp:Button ID="btnCat" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Categorias de Cursos" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Categoria_Click" />
                     </td>
                    <td class="auto-style6">
                        <asp:Label ID="lblID_Categoria" runat="server" Text="ID de la Categoria:" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtID_Cat" runat="server" Width="127px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                         <asp:Button ID="btnCursos" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Cursos" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Cursos_Click" />
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="lblNombre_Cat" runat="server" Text="Nombre de la Categoria:" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="auto-style5" colspan="2">
                        <asp:TextBox ID="txtNombre_cat" runat="server" Width="391px"></asp:TextBox><br />
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Temas" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Temas" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Temas_Click" />
                     </td>
                    <td colspan="3" class="auto-style8">
                        <asp:Button ID="btnAgregar" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Agregar" Font-Size="12pt" OnClick="btnAgregar_Click" />&nbsp 
                        <asp:Button ID="btnModificar" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Modificar" Font-Size="12pt" OnClick="btnModificar_Click" />&nbsp
                        <asp:Button ID="btnBuscar" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Buscar" Font-Size="12pt"  OnClick="btnBuscar_Click"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnContenidos" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Contenidos" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Contenido_Click" />
                     </td>
                    <td colspan="3" class="auto-style7" rowspan="4">
                        <asp:GridView ID="gdwCategorias" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                            <FooterStyle BackColor="White" ForeColor="#000066" />
                            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                            <RowStyle ForeColor="#000066" />
                            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#007DBB" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#00547E" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                         <asp:Button ID="btnPrivilegios" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Privilegios" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Privilegios_click" />
                      </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
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

