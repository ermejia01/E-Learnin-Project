<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrincipalUsuario.aspx.cs" Inherits="Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!--<link rel="stylesheet" type="text/css" href="/Estilos/EstilosPrincipalUsuario.css"/>-->
    <link rel="stylesheet" type="text/css" href="/Estilos/EstilosPrincipalUsuario.css"/>
    <title>Proyecto Viky</title>
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
                <asp:Button ID="btnCerrarSesion" runat="server" Font-Size="8pt" Height="23px" OnClick="btnCerrarSesion_Click" Text="Cerrar Sesion" Width="115px" />
            </nav>
        </div>
        <div class="ContenedorCursos">
            <div>
                <h2>Cursos</h2>
            </div>
            <div>
                <div class="OcultarInfo">
                    <a href="#DivgdvCategoria1">
                        <asp:Label ID="lblCat1" runat="server" Text="Informatica"></asp:Label>
                    </a>
                </div>
                <div class="divOcultarInfo" id="DivgdvCategoria1">
                    <div class="auto-style1">
                    <asp:GridView ID="gdvCategoria1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" ShowHeader="False" OnRowCommand="gdvCategoria1_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Inscribir" Text="Inscribir" >
                            <ControlStyle BackColor="White" BorderColor="#33CCCC" BorderStyle="Solid" BorderWidth="1px" />
                            </asp:ButtonField>
                            <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver">
                            <ControlStyle BackColor="White" BorderColor="#33CCCC" BorderStyle="Solid" BorderWidth="1px" />
                            </asp:ButtonField>
                        </Columns>
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
                    </div>
                    <asp:Label ID="lblMensaje1" runat="server" ForeColor="#CC0000"></asp:Label>
                </div>
                <div class="Intermedio"></div>
                <div class="OcultarInfo">
                    <a href="#DivgdvCategoria2">
                        <asp:Label ID="lblCat2" runat="server" Text="Matematicas"></asp:Label>
                    </a>
                </div>
                <div class="divOcultarInfo" id="DivgdvCategoria2">
                    <asp:GridView ID="gdvCategoria2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" ShowHeader="False" OnRowCommand="gdvCategoria2_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Inscribir" Text="Inscribir">
                            <ControlStyle BackColor="White" BorderColor="#33CCCC" BorderStyle="Solid" BorderWidth="1px" />
                            </asp:ButtonField>
                            <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver">
                            <ControlStyle BackColor="White" BorderColor="#33CCCC" BorderStyle="Solid" BorderWidth="1px" />
                            </asp:ButtonField>
                        </Columns>
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
                    <asp:Label ID="lblMensaje2" runat="server" ForeColor="#CC0000"></asp:Label>
                </div>
                <div class="Intermedio"></div>
                <div class="OcultarInfo">
                    <a href="#DivgdvCategoria3">
                        <asp:Label ID="lblCat3" runat="server" Text="Electronica"></asp:Label>
                    </a>
                </div>
                <div class="divOcultarInfo" id="DivgdvCategoria3">
                    <asp:GridView ID="gdvCategoria3" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" ShowHeader="False">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ButtonType="Button" SelectText="Inscribir" ShowSelectButton="True">
                            <ControlStyle BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" />
                            </asp:CommandField>
                            <asp:CommandField ButtonType="Button" SelectText="Ver" ShowSelectButton="True">
                            <ControlStyle BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" />
                            </asp:CommandField>
                        </Columns>
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
                    <asp:Label ID="lblMensaje3" runat="server" ForeColor="#CC0000"></asp:Label>
                </div>
                <div class="Intermedio"></div>
                <div class="OcultarInfo">
                    <a href="#DivgdvCategoria4">
                        <asp:Label ID="lblCat4" runat="server" Text="Idiomas"></asp:Label>
                    </a>
                </div>
                <div class="divOcultarInfo" id="DivgdvCategoria4">
                    <asp:GridView ID="gdvCategoria4" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" ShowHeader="False">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ButtonType="Button" SelectText="Inscribir" ShowSelectButton="True">
                            <ControlStyle BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" />
                            </asp:CommandField>
                            <asp:CommandField ButtonType="Button" SelectText="Ver" ShowSelectButton="True">
                            <ControlStyle BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" />
                            </asp:CommandField>
                        </Columns>
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
                    <asp:Label ID="lblMensaje4" runat="server" ForeColor="#CC0000"></asp:Label>
                </div>
            </div>
        </div>
        <div class="footer">
            Derechos reservados Proyecto Viky
        </div>    
    </div>
    </form>
</body>
</html>
