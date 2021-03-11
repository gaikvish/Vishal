<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginPage.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #ffeae2">
    <form id="form1" runat="server">
        <div style="margin-left: 20%; width: 100%;">
            <div style="width: 60%; text-align: center; margin-top: 10%;">
                 <table style="width: 60%; margin-left: 20%;">
                    <tr>
                        <td colspan="2"><h1>AWS Demo</h1></td>
                    </tr>
                     </table>
                <table style="width: 60%; margin-left: 20%; border: 5px solid black; border-radius: 10px">
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 30%">Username</td>
                        <td style="width: 30%; text-align: left">:
                            <asp:TextBox runat="server" ID="txtUsername" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Password</td>
                        <td style="text-align: left">:
                            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button runat="server" ID="btnLogin" OnClick="btnLogin_Click" Text="Login" BackColor="#b74f0b" ForeColor="White" Width="120px" Style="border-radius: 10px; cursor: pointer" /></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                </table>
                <br />
                <table style="width: 60%; margin-left: 20%;">
                    <tr>
                        <td colspan="2">Status : <asp:Label Font-Bold="true" Font-Size="Large" ID="lblStatus" Text="Not Logged In" runat="server"></asp:Label></td>
                    </tr>
                </table>

            </div>
        </div>
    </form>
</body>
</html>
