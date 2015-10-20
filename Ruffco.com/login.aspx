<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 65%;
            height: 274px;
        }
        .auto-style2 {
            height: 51px;
        }
        .auto-style3 {
            width: 100px;
        }
        .auto-style4 {
            height: 51px;
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>Please log in to continue:</td>
            </tr>
            <tr>
                <td class="auto-style3">Username:</td>
                <td>
                    <asp:TextBox ID="txtboxUsername" runat="server" Height="46px" Width="283px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtboxPassword" runat="server" TextMode="Password" Width="285px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" PostBackUrl="~/Menu.aspx" Text="Submit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
