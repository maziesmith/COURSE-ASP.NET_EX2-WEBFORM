<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="COURSE_ASP.NET_EX2_WEBFORM.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 593px;
        }
        .auto-style4 {
            width: 593px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 593px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2"><strong>Ejercicio 2</strong></td>
            </tr>
            <tr>
                <td class="auto-style3">Seleccione Un Articulo </td>
                <td>
                    <asp:DropDownList ID="ddlImages" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Image ID="Img1" runat="server" Width="200px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style6">Precio Al Contado </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Meses de pago en </td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="6" />
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="12" />
                    <asp:RadioButton ID="RadioButton3" runat="server" Text="18" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ver Plataforma " />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Button2" runat="server" Text="Limpiar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
