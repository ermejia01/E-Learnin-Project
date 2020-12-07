<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistroUsuario.aspx.cs" Inherits="RegistroUsuario" %>

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
        .auto-style10 {
            height: 64px;
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
            height: 59px;
        }
        .auto-style15 {
            height: 59px;
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
                        <asp:Label ID="Label1" runat="server" BorderStyle="None" Font-Bold="True" Font-Size="13pt" Font-Underline="True" Text="Usuarios "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnCat" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Categorias de Cursos" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Categoria_Click" />
                    </td>
                    <td class="auto-style12">
                        <asp:Label   runat="server" Text="Codigo: "></asp:Label>
                        <asp:TextBox ID="txtID_Codigo" runat="server" Width="97px"></asp:TextBox>&nbsp&nbsp&nbsp
                        &nbsp&nbsp
                         <asp:Label   runat="server" Text="Password: "></asp:Label>
                        <asp:TextBox ID="txt_password" runat="server" Width="107px"></asp:TextBox>&nbsp&nbsp&nbsp 
                        <asp:Label  runat="server" Text="Privilegios: "></asp:Label>
                        <asp:DropDownList ID="ddlPrivilegio" runat="server" Width="137px"> 
                        </asp:DropDownList>

                        &nbsp
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
                        <asp:Label   runat="server" Text="Nombre: "></asp:Label>                        
                        <asp:TextBox ID="txtNombre" runat="server" Width="150px"></asp:TextBox>&nbsp&nbsp  
                         <asp:Label   runat="server" Text="Apellido: "></asp:Label>                      
                        <asp:TextBox ID="txtApellido" runat="server" Width="150px"></asp:TextBox>&nbsp&nbsp&nbsp
                         <asp:Label   runat="server" Text="Correo: "></asp:Label>                      
                        <asp:TextBox ID="txt_correo" runat="server" Width="150px"></asp:TextBox>&nbsp&nbsp&nbsp
                         <asp:Label   runat="server" Text="Telefono: "></asp:Label>                        
                        <asp:TextBox ID="txt_telefono" runat="server" Width="150px"></asp:TextBox>
                    </td>
                     
                </tr>
                <tr>
                    <td class="auto-style14">
                        <asp:Button   runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Temas" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Temas_Click" />
                    </td>
                    <td colspan="2" class="auto-style15" >
                        &nbsp
                        <asp:Label  runat="server" Text="Sexo: "></asp:Label>
                        <asp:DropDownList ID="ddlSexo" runat="server" Width="107px">
                            <asp:ListItem>Masculino</asp:ListItem>
                            <asp:ListItem>Femenino</asp:ListItem>
                        </asp:DropDownList>&nbsp&nbsp&nbsp
                          <asp:Label   runat="server" Text="Pais: "></asp:Label>                        
                        <asp:TextBox ID="txtPais" runat="server" Width="150px"></asp:TextBox>&nbsp&nbsp    
                        <asp:Label   runat="server" Text="Departamento: "></asp:Label>                        
                        <asp:TextBox ID="txtDepartamento" runat="server" Width="150px"></asp:TextBox>
                         <asp:Label   runat="server" Text="Edad: "></asp:Label>        &nbsp&nbsp                   
                        <asp:TextBox ID="txtEdad" runat="server" Width="50px"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnContenidos" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Contenidos" Width="286px" BorderColor="Aqua" BorderWidth="1px" OnClick="Contenido_Click" />
                    </td>
                  <td rowspan="5">
                     
                        <asp:Label   runat="server" Text="Fecha de Nacimiento   "></asp:Label>
                        <asp:Calendar ID="Calendar_usuario" runat="server"></asp:Calendar> &nbsp&nbsp  
                       
                       
                  </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnPrivilegios" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px" Text="Privilegios" Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                   
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnReportes" runat="server" BackColor="#0E176B" BorderStyle="Solid" Font-Bold="False" Font-Names="Roboto" Font-Size="12pt" ForeColor="White" Height="60px"  Text="Reportes " Width="286px" BorderColor="Aqua" BorderWidth="1px" />
                    </td>
                  
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>

                  
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                       <td> 
                      <asp:Label   runat="server" Text="Fotografia   "></asp:Label>
                      <asp:FileUpload ID="FileUpload_image" runat="server" />
                    </td>


                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>

                    
                     <td>

                        <asp:Button ID="btnAgregar" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Agregar" Font-Size="12pt" OnClick="btnAgregar_Click"  /> &nbsp
                        <asp:Button ID="btnModificar" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Modificar" Font-Size="12pt" OnClick="btnModificar_Click" />&nbsp
                        <asp:Button ID="btnBuscar" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Text="Buscar" Font-Size="12pt" OnClick="btnBuscar_Click" />

                    </td>


                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    
                      <td rowspan="5">

                        <asp:GridView ID="gdwUsuarios" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            </table>

        </div>
        <div class="footer">
            Derechos reservados Proyecto Viky
        </div>
    </div>
    </form>
</body>
</html>
