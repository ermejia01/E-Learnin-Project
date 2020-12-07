<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DesarrolloCursos.aspx.cs" Inherits="DesarrolloCursos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Proyecto Vicky - Desarrollo del Curso</title>
    <!--<link rel="stylesheet" type="text/css" href="/Estilos/EstilosSecundarioUsuario.css"/>-->
    <link rel="stylesheet" type="text/css" href="/Estilos/EstilosSecundarioUsuario.css"/>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            padding: 20px;
            display: inline-block;
            width: 23%;
            height: 100px;
        }
        .auto-style4 {
            padding: 20px;
            display: inline-block;
            width: 33%;
            height: 270px;
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
                        <td>
                            <asp:Panel ID="pnTemas" runat="server">
                                <asp:Label ID="lblNombreCurso" runat="server"></asp:Label>
                                <asp:GridView ID="gdwTemas" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" CellPadding="4" ShowHeader="False" OnRowCommand="gdwTemas_RowCommand">
                                    <Columns>
                                        <asp:ButtonField CommandName="Ver" Text="Ver" />
                                    </Columns>
                                    <EditRowStyle BorderStyle="None" />
                                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                                    <RowStyle BackColor="White" ForeColor="#003399" />
                                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                                    <SortedDescendingHeaderStyle BackColor="#002876" />
                                </asp:GridView>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnContenido" runat="server">
                                <asp:Label ID="lblNombre_Tema" runat="server" Text="Elige tu contenido"></asp:Label>
                                <asp:GridView ID="gdwContenidos" runat="server" OnRowCommand="gdwContenidos_RowCommand">
                                    <Columns>
                                        <asp:ButtonField Text="Ver" CommandName="Ver">
                                        <ControlStyle BorderStyle="None" />
                                        </asp:ButtonField>
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>

            </div>
            <div>
                <div class="auto-style3">

                </div>
                <div class="auto-style4" id="MostrarContenido" runat="server">
                                
                </div>
                <div class="contenidos">

                </div>
            </div>
            <div>
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>
            <div>

                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2"></td>
                        <td class="auto-style2"></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="0px" Font-Bold="True" Font-Underline="True" ForeColor="#0099CC" Height="27px" OnClick="Button1_Click" Text="Regresar a los Cursos" Width="220px" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
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
