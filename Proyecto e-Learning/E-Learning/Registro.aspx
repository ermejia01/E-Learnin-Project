<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="/Estilos/EstilosPrincipalUsuario.css"/>
    <title>Proyecto Viky - Registro</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            width: 224px;
        }
        .auto-style4 {
            height: 22px;
            width: 224px;
        }
        .auto-style5 {
            width: 216px;
        }
        .auto-style6 {
            height: 22px;
            width: 216px;
        }
        .auto-style25 {
            width: 216px;
            height: 47px;
        }
        .auto-style26 {
            width: 224px;
            height: 47px;
        }
        .auto-style27 {
            height: 47px;
        }
        .auto-style34 {
            width: 216px;
            height: 59px;
        }
        .auto-style35 {
            width: 224px;
            height: 59px;
        }
        .auto-style36 {
            height: 59px;
        }
        .auto-style37 {
            height: 31px;
            width: 216px;
        }
        .auto-style38 {
            height: 31px;
            width: 224px;
        }
        .auto-style39 {
            height: 31px;
        }
        .auto-style40 {
            height: 30px;
            width: 216px;
        }
        .auto-style41 {
            height: 30px;
            width: 224px;
        }
        .auto-style42 {
            height: 30px;
        }
        .auto-style43 {
            height: 28px;
            width: 216px;
        }
        .auto-style44 {
            height: 28px;
            width: 224px;
        }
        .auto-style45 {
            height: 28px;
        }
        .auto-style46 {
            height: 21px;
            width: 216px;
        }
        .auto-style47 {
            height: 21px;
            width: 224px;
        }
        .auto-style48 {
            height: 21px;
        }
        .auto-style49 {
            height: 24px;
            width: 216px;
        }
        .auto-style50 {
            height: 24px;
            width: 224px;
        }
        .auto-style51 {
            height: 24px;
        }
        .auto-style52 {
            height: 29px;
            width: 216px;
        }
        .auto-style53 {
            height: 29px;
            width: 224px;
        }
        .auto-style54 {
            height: 29px;
        }
        .auto-style55 {
            height: 23px;
            width: 216px;
        }
        .auto-style56 {
            height: 23px;
            width: 224px;
        }
        .auto-style57 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="bodyglobal">
        <div class="header">
            <img id="Vikyimage" src="Imagenes/VikyAzul.png" alt="" />
            <nav>
                <ul>
                    <li>Proyecto Vicky</li>
                </ul>
            </nav>
        </div>
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="True" Font-Overline="False" Font-Size="16pt" ForeColor="#000099" Text="Formulario de Registro"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style37"></td>
                    <td class="auto-style38">CODIGO DE USUARIO:</td>
                    <td class="auto-style39">
                        <asp:TextBox ID="txtCodigo" runat="server" Width="227px"></asp:TextBox>
                    </td>
                    <td class="auto-style39"></td>
                </tr>
                <tr>
                    <td class="auto-style40"></td>
                    <td class="auto-style41">NOMBRES:</td>
                    <td class="auto-style42">
                        <asp:TextBox ID="txtNombres" runat="server" Width="350px"></asp:TextBox>
                    </td>
                    <td class="auto-style42"></td>
                </tr>
                <tr>
                    <td class="auto-style43"></td>
                    <td class="auto-style44">APELLIDOS:</td>
                    <td class="auto-style45">
                        <asp:TextBox ID="txtApellido" runat="server" Width="350px"></asp:TextBox>
                    </td>
                    <td class="auto-style45"></td>
                </tr>
                <tr>
                    <td class="auto-style46"></td>
                    <td class="auto-style47">EDAD:</td>
                    <td class="auto-style48">
                        <asp:TextBox ID="txtEdad" runat="server" Width="131px"></asp:TextBox>
                    </td>
                    <td class="auto-style48"></td>
                </tr>
                <tr>
                    <td class="auto-style49"></td>
                    <td class="auto-style50">SEXO:</td>
                    <td class="auto-style51">
                        <asp:DropDownList ID="ddlSexo" runat="server">
                            <asp:ListItem>Masculino</asp:ListItem>
                            <asp:ListItem>Femenino</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style51"></td>
                </tr>
                <tr>
                    <td class="auto-style52"></td>
                    <td class="auto-style53">FECHA DE NACIMIENTO:</td>
                    <td class="auto-style54">
                        <asp:TextBox ID="txtFechaNac" runat="server" Width="140px"></asp:TextBox>
                    </td>
                    <td class="auto-style54"></td>
                </tr>
                <tr>
                    <td class="auto-style49"></td>
                    <td class="auto-style50">PAIS:</td>
                    <td class="auto-style51">
                        <asp:TextBox ID="txtPais" runat="server" Width="205px"></asp:TextBox>
                    </td>
                    <td class="auto-style51"></td>
                </tr>
                <tr>
                    <td class="auto-style25"></td>
                    <td class="auto-style26">DEPARTAMENTO:</td>
                    <td class="auto-style27">
                        <asp:DropDownList ID="ddlDepto" runat="server">
                            <asp:ListItem>Santa Ana</asp:ListItem>
                            <asp:ListItem>Ahuachapan</asp:ListItem>
                            <asp:ListItem>San Salvador</asp:ListItem>
                            <asp:ListItem>La Paz</asp:ListItem>
                            <asp:ListItem>Sonsonate</asp:ListItem>
                            <asp:ListItem>La Union</asp:ListItem>
                            <asp:ListItem>Usulutan</asp:ListItem>
                            <asp:ListItem>Cabañas</asp:ListItem>
                            <asp:ListItem>San Miguel</asp:ListItem>
                            <asp:ListItem>San Vicente</asp:ListItem>
                            <asp:ListItem>Morazan</asp:ListItem>
                            <asp:ListItem>Chalatenango</asp:ListItem>
                            <asp:ListItem>La Libertad</asp:ListItem>
                            <asp:ListItem>Cuscatlan</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style27"></td>
                </tr>
                <tr>
                    <td class="auto-style55"></td>
                    <td class="auto-style56">TELEFONO:</td>
                    <td class="auto-style57">
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style57"></td>
                </tr>
                <tr>
                    <td class="auto-style49"></td>
                    <td class="auto-style50">MAIL:</td>
                    <td class="auto-style51">
                        <asp:TextBox ID="txtMail" runat="server" Width="350px"></asp:TextBox>
                    </td>
                    <td class="auto-style51"></td>
                </tr>
                <tr>
                    <td class="auto-style37"></td>
                    <td class="auto-style38">PASSWORD:</td>
                    <td class="auto-style39">
                        <asp:TextBox ID="txtPasword" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style39"></td>
                </tr>
                <tr>
                    <td class="auto-style34"></td>
                    <td class="auto-style35"></td>
                    <td class="auto-style36">
                        <asp:Button ID="btnEnviar" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="#000099" Height="48px" OnClick="btnEnviar_Click" Text="Enviar" Width="201px" />
                    </td>
                    <td class="auto-style36"></td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style2">
                        <asp:Label ID="lblMensajes" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnEnviar0" runat="server" BackColor="White" BorderColor="#00CCFF" BorderStyle="Solid" BorderWidth="0px" Font-Bold="False" Font-Overline="False" ForeColor="#000099" Height="25px" OnClick="btnEnviar0_Click" Text="Volver al Login" Width="168px" Font-Underline="True" />
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
