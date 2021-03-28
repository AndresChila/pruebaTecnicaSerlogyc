<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="PruebaTecnica.WebSite.View.Formularios.CrearUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 455px;
            text-align: right;
        }
        .auto-style2 {
            width: 455px;
            text-align: left;
        }
        .auto-style3{
            text-align:center;
        }
        .auto-style4 {
            width: 455px;
            text-align: right;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="XX-Large" Text="Crear usuario"></asp:Label>
            </div>
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Font-Names="Comic Sans MS" Text="Tipo de identificación:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Font-Names="Comic Sans MS" Text="Numero identificación:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TBNumeroId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Font-Names="Comic Sans MS" Text="Nombre:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Font-Names="Comic Sans MS" Text="Apellido:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TBApellido" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Font-Names="Comic Sans MS" Text="Fecha de nacimiento:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TBFechaNacimiento" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" Font-Names="Comic Sans MS" Text="Estado civil:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList2" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label7" runat="server" Font-Names="Comic Sans MS" Text="Contraseña:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TBContraseña" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="color: #C0C0C0">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Crear usuario" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Regresar al inicio de sesión</asp:LinkButton>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
