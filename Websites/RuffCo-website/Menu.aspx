<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
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
        .menuPaddingAndCenter {
            text-align: center;
            padding: 40px 0px;
        }
        .tdBackgroundColor {
            background-color: #e3f5fa;
            width: 300px;
        }
        .menuTable {
            padding: 20px 0px 30px 0px;
            margin: 0 auto;
        }
    </style>
</head>

<!-- margin 0 auto is to center the content -->

<body style="margin: 0 auto; display: table; background-color: #ededed;">

<!-- Container is to make the page 1100px -->
     <div class="container">
    <form id="form1" runat="server">
        <table  class="auto-style1">

<!--  The header including the logo -->
             <tr class="header">
                <td class="logo"><img src="/properties/images/Logo.png" width="260"/></td>
                <td class="headerTitle"><strong>Ruffco Airlines</strong><br />
                    <span class="fontSize20"><em>&quot;Rough air made easy&quot;</em></span></td>
             </tr>
        </table>
        
<!--  The menu buttons -->        
        <table class="menuTable">
        <tr class="centerMenu tdBackgroundColor">
            
            <td class="menuPaddingAndCenter">&nbsp;<asp:Button ID="btnViewExistingInformation" runat="server" PostBackUrl="~/View.aspx" Text="View existing information" OnClick="btnViewExistingInformation_Click" />
            </td>
        </tr>
        <tr class="centerMenu tdBackgroundColor">
            <td class="menuPaddingAndCenter">
                <asp:Button ID="btnNewReservation" runat="server" Text="Create new reservation" Width="194px" OnClick="btnNewReservation_Click" PostBackUrl="~/Reservation.aspx" />
            </td>
            
        </tr>
       
        <tr class="centerMenu tdBackgroundColor">
            <td class="menuPaddingAndCenter">
                <asp:Button ID="btnAdmin" runat="server" Text="admin" />
            </td>
        </tr>
        <tr class="centerMenu tdBackgroundColor">
            <td class="menuPaddingAndCenter">
                <asp:Button ID="Button2" runat="server" Text="Clear cookies" OnClick="Button2_Click" />
            </td>
        </tr>
           
    </table>
    </form>
         </div>
</body>
</html>
