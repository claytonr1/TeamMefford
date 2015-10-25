<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 48%;
            height: 183px;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body style="height: 182px">
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td style="text-align: center">&nbsp;<asp:Button ID="Button1" runat="server" PostBackUrl="~/View.aspx" Text="View existing information" />
            </td>
        </tr>
        <tr>
            <td style="text-align: center">Create new reservation</td>
        </tr>
        <tr>
            <td style="text-align: center">Add new data (employee, planes, etc)</td>
        </tr>
        <tr>
            <td class="auto-style2">admin</td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:Button ID="Button2" runat="server" Text="Clear cookies (currently broken)" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
