<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cursos.aspx.cs" Inherits="Cursos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Proyecto Vicky - Cursos</title>
    <%--<link rel="stylesheet" type="text/css" href="Estilos/EstilosElearning.css"/>--%>
     <link rel="stylesheet" type="text/css" href="Estilos/EstilosPrincipalAdmin.css"/>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: left;
            width: 332px;
        }
        .auto-style3 {
            width: 332px;
        }
        .auto-style4 {
            width: 332px;
            height: 64px;
        }
        .auto-style5 {
            height: 64px;
        }
        .auto-style10 {
            height: 64px;
            width: 981px;
        }
        .auto-style11 {
            text-align: left;
            width: 981px;
        }
        .auto-style12 {
            width: 1000px;
        }
        .auto-style13 {
            width: 332px;
            height: 39px;
        }
        .auto-style14 {
            width: 332px;
            height: 47px;
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
            </nav>
        </div>
         <div>

            <table class="auto-style1">
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnMenu" runat="server" BackColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Roboto" Font-Size="20pt" ForeColor="#0099CC" Text="Menu" Width="286px" />
                    </td>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnUsuarios" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Usuarios" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Usuarios_Click" />
                    </td>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" BorderStyle="None" Font-Bold="True" Font-Size="13pt" Font-Underline="True" Text="Cursos "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnCat" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Categorias de Cursos" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Categoria_Click" />
                    </td>
                    <td class="auto-style12">
                        <asp:Label  runat="server" Text="ID Curso: "></asp:Label>
                        <asp:TextBox ID="txtID_Curso" runat="server" Width="97px"></asp:TextBox>&nbsp
                        <asp:Label  runat="server" Text="Categoria: "></asp:Label>
                        <asp:DropDownList ID="ddlCategoria" runat="server" AutoPostBack="True" Width="183px">
                        </asp:DropDownList>&nbsp
                        &nbsp
                        &nbsp
                        <asp:Label ID="lblMensajes" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="btnCursos" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Cursos" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Cursos_Click" />
                    </td>
                    <td class="auto-style10">
                         &nbsp
                        <asp:Label ID="lbDescripcion" runat="server" Text="Descripcion:  "></asp:Label>
                        <asp:TextBox ID="txtDescripcion" runat="server" Width="404px"></asp:TextBox>&nbsp
                        <asp:Label   runat="server" Text="Estatus: "></asp:Label>
                        <asp:DropDownList ID="ddlEstatus" runat="server" Width="107px">
                            <asp:ListItem Value="True">Activo</asp:ListItem>
                            <asp:ListItem Value="False">Inactivo</asp:ListItem>
                        </asp:DropDownList>


                    </td>
                    <td class="auto-style5">
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button   runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Temas" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Temas_Click" />
                    </td>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Agregar" Font-Size="12pt" OnClick="btnAgregar_Click"  /> &nbsp
                        <asp:Button ID="Button2" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Modificar" Font-Size="12pt" OnClick="btnModificar_Click" />&nbsp
                        <asp:Button ID="Button3" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Buscar" Font-Size="12pt" OnClick="btnBuscar_Click" />

                        </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnContenidos" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Contenidos" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Contenido_Click" />
                    </td>
                    <td class="auto-style11" rowspan="5">
                        <asp:GridView ID="gdwCursos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                           <asp:Label ID="lblMensajesGrid" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="Red"></asp:Label>

                    </td>
                
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnPrivilegios" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Privilegios" Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                    </td>


                  </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td></td>
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
