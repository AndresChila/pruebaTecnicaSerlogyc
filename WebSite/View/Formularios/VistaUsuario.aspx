<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaUsuario.aspx.cs" Inherits="PruebaTecnica.WebSite.View.Formularios.VistaUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 467px;
            text-align: right;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3{
            width: 467px;
            text-align: left;
        }
        .auto-style4{
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="XX-Large" Text="Información del usuario"></asp:Label>
            </div>
        <div>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Tipo de documento:" Font-Names="Comic Sans MS"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="LTipoDocumento" runat="server" Font-Names="Consolas"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Identificación:" Font-Names="Comic Sans MS"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="LIdentificacion" runat="server" Font-Names="Consolas"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Nombre:" Font-Names="Comic Sans MS"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="LNombre" runat="server" Font-Names="Consolas"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Apellido:" Font-Names="Comic Sans MS"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="LApellido" runat="server" Font-Names="Consolas"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Text="Fecha nacimiento:" Font-Names="Comic Sans MS"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="LFechaNacimiento" runat="server" Font-Names="Consolas"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" Text="Estado civil:" Font-Names="Comic Sans MS"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="LEstadoCivil" runat="server" Font-Names="Consolas"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Regresar al inicio de sesión</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
