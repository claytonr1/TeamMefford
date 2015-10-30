<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        .auto-style2 {
            text-align: center;
        }
         .auto-style1 {
            width: 100%;
            
        }
       
          .logo {
           
            width: 30%;
        }
        .headerTitle {
            font-size: 36px;
            width: 70%;
            text-align: center;
            color: #002063;
        }
         .header {
            
            background-color: #8cf7dd;
        }
        .fontSize20 {
            font-size: 20px;
        }
        .container {
            width: 1100px;
            background-color: white;
        }
        .centerMenu {
            margin: 0 auto;
            display: table;
        }
    </style>
</head>
<body style="margin: 0 auto; display: table; background-color: #ededed;">
     <div class="container">
    <form id="form1" runat="server">
        <table  class="auto-style1">

             <tr class="header">
                <td class="logo"><img src="/properties//images/Logo.png" width="260"/></td>
                <td class="headerTitle"><strong>Ruffco Airlines</strong><br />
                    <span class="fontSize20"><em>&quot;Rough air made easy&quot;</em></span></td>
                
            </tr>
          </table> 
        <table  class="auto-style1">
        <tr class="centerMenu">
            
            <td style="text-align: center">&nbsp;<asp:Button ID="btnViewExistingInformation" runat="server" PostBackUrl="~/View.aspx" Text="View existing information" />
            </td>
        </tr>
        <tr class="centerMenu">
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
         </div>
</body>
</html>
