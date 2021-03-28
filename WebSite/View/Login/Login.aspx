<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PruebaTecnica.WebSite.View.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style5 {
            height: 23px;
            width: 269px;
            text-align: center;
        }
        .auto-style7 {
            height: 23px;
            width: 360px;
        }
        .auto-style8 {
            width: 269px;
            text-align: center;
        }
        .auto-style9 {
            height: 23px;
            width: 360px;
            text-align: center;
        }
        .auto-style10 {
            width: 360px;
            text-align: center;
        }
        .auto-style11 {
            width: 360px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table style="width:100%;">
                
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Font-Names="Comic Sans MS" Text="Inicio de sesión" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>

            </table>
            
        </div>
    <div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Label ID="Label2" runat="server" Font-Names="Comic Sans MS" Text="Usuario(cedula)"></asp:Label>
                </td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Label ID="Label4" runat="server" Font-Names="Comic Sans MS" Text="Contraseña"></asp:Label>
                </td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="Button1" runat="server" Text="Ingresar" OnClick="Button1_Click" />
                </td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style9">¿Usuario nuevo? <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Crear cuenta</asp:LinkButton>
                </td>
                <td class="auto-style7"></td>
            </tr>
        </table>
    </div>
    </form>
    </body>
</html>
