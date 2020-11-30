<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContenidoTemas.aspx.cs" Inherits="ContenidoTemas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Proyecto Vicky - Contenidos</title>
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
                        <asp:Button ID="btnUsuarios" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Usuarios" Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" BorderStyle="None" Font-Bold="True" Font-Size="13pt" Font-Underline="True" Text="Contenidos "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnCat" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Categorias de Cursos" Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                    <td class="auto-style12">
                        <asp:Label ID="lblID_Contenido" runat="server" Text="ID Contenido: "></asp:Label>
                        <asp:TextBox ID="txtID_Contenido" runat="server" Width="97px"></asp:TextBox>&nbsp
                        <asp:Label ID="lblCategoria" runat="server" Text="Categoria: "></asp:Label>
                        <asp:DropDownList ID="ddlCategoria" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged" Width="183px">
                        </asp:DropDownList>&nbsp
                        &nbsp
                        &nbsp
                        <asp:Label ID="lblMensajes" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="btnCursos" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Cursos" Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                    <td class="auto-style10">
                        <asp:Label ID="lblCurso" runat="server" Text="Curso: "></asp:Label>
                        <asp:DropDownList ID="ddlCursos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCursos_SelectedIndexChanged" Width="309px">
                        </asp:DropDownList>&nbsp
                        <asp:Label ID="lblTema" runat="server" Text="Tema: "></asp:Label>
                        <asp:DropDownList ID="ddlTema" runat="server" AutoPostBack="True" Width="326px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style5">
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Temas" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Temas" Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                    <td colspan="2">
                        &nbsp
                        <asp:Label ID="lbDescripcion" runat="server" Text="Descripcion:  "></asp:Label>
                        <asp:TextBox ID="txtDescripcion" runat="server" Width="404px"></asp:TextBox>&nbsp
                        <asp:Label ID="lblTipo" runat="server" Text="Tipo: "></asp:Label>
                        <asp:DropDownList ID="ddlTipo" runat="server" Width="107px">
                            <asp:ListItem>Texto</asp:ListItem>
                            <asp:ListItem>Video</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnContenidos" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Contenidos" Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                    <td class="auto-style11">
                        <asp:Label ID="Label2" runat="server" Text="Archivo:   "></asp:Label>
                        <asp:TextBox ID="txtArchivo" runat="server" Height="46px" Width="660px"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnPrivilegios" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Privilegios" Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                    <td>

                        <asp:Button ID="btnAgregar" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Agregar" Font-Size="12pt" OnClick="btnAgregar_Click"  /> &nbsp
                        <asp:Button ID="btnModificar" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Modificar" Font-Size="12pt" OnClick="btnModificar_Click" />&nbsp
                        <asp:Button ID="btnBuscar" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Buscar" Font-Size="12pt" OnClick="btnBuscar_Click" /></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnReportes" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px"  Text="Reportes " Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                    <td rowspan="5">

                        <asp:GridView ID="gdwContenidos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
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
