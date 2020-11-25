<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="Estilos/EstilosInicio.css"/>
</head>
<body>
    <form id="Inicio" runat="server">
    <div class="bodyglobal">
        <div class="header">
            <div>
                Proyecto Viky
            </div>
        </div>
        <div class="body">
            <div class="bodycolumna">
                
            </div>
            <div class="bodycolumna">
                <div class="bodycolumnaitems">
                    <div>
                        <asp:Label ID="lblLogin" runat="server" Text="Ingresa tus Credenciales" Font-Bold="True" Font-Size="Large" ForeColor="#17ACCC"></asp:Label>
                    </div>
                    <div>
                        Usuario
                    </div>
                    <div>
                        <asp:TextBox cssClass="txtinfoinicio" ID ="txtUsuario" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        Contraseña
                    </div>
                    <div>
                        <asp:TextBox cssClass="txtinfoinicio" ID="txtContraseña" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Button CssClass="btnIngresar" ID="btnIngresar" runat="server" Text="Iniciar Sesion" OnClick="btnIngresar_Click" />
                    </div>
                    <div>
                        <div style="display:inline-block;">
                            <asp:CheckBox CssClass="textosalpie" ID="chkRecordar" runat="server" Text="Recordar Usuario" />
                        </div>
                        <div style="display:inline-block;">
                            <a class="textosalpie" href="Cambiarcontraseña.aspx" >Reestablecer contraseña</a>
                        </div>
                        <br /><asp:Label CssClass="lblMensajeError" ID="lblMensaje" runat="server" Text="mensaje" Visible="False"></asp:Label>
                    </div>
                    <div style="background-color:#17accc;">
                        <a class="textosalpie2" href="Index.html">Volver al inicio</a>
                    </div>
                </div>
            </div>
            <div class="bodycolumna">
               
            </div>
        </div>
        <div class="footer">
            Derechos reservados Proyecto Viky
        </div>    
    </div>
    </form>
</body>
</html>
