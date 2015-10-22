<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 96%;
            height: 398px;
        }
        .auto-style2 {
            height: 93px;
        }
        .auto-style3 {
            height: 93px;
            width: 131px;
        }
        .auto-style4 {
            width: 131px;
        }
        .auto-style5 {
            height: 93px;
            width: 451px;
            text-align: center;
        }
        .auto-style6 {
            width: 451px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Ruffco logo here</td>
                <td class="auto-style5"><strong>Ruffco Airlines</strong><br />
                    &quot;Rough air made easy&quot;</td>
                <td class="auto-style2">
                    <asp:Button ID="btnLogin" runat="server" PostBackUrl="~/login.aspx" Text="log in" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Links possibly?</td>
                <td class="auto-style6">Info about company here</td>
                <td style="text-align: center">Recent news/<br />
                    current promotion</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
