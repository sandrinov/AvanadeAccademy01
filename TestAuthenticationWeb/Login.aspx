<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TestAuthenticationWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>User Name</td>
                <td><asp:TextBox ID="Txt_UserName" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Password</td>
                <td><asp:TextBox ID="Txt_Psw" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Remember Me</td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" /> </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Lbl_Error" runat="server" ForeColor="#CC3300"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
    </form>
</body>
</html>
