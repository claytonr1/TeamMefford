<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Results.aspx.cs" Inherits="Results" %>

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
          p {
              text-align: center;
          }
           h2 {
              text-align: center;
          }
            h3 {
              text-align: center;
          }
    </style>
</head>
<body style="margin: 0 auto; display: table; background-color: #ededed;">

<!-- Container is to make the page 1100px -->
     <div class="container">
    <form id="form1" runat="server">
        <table  class="auto-style1">

<!--  The header including the logo -->
             <tr class="header">
                <td class="logo"><img src="/properties/images/Logo.png" width="260"/></td>
                <td class="headerTitle"><strong>Ruff Co. Airlines</strong><br />
                    <span class="fontSize20"><em>&quot;Rough air made easy&quot;</em></span></td>
             </tr>
        </table>
       
        <div class="container" style="margin: 0 auto;">
    <h2>
        <br />
        Thank you for booking on Ruff Co. Airlines!</h2>
    <h3>
        This is your reservation, please print this page for your records.</h3>
    
        <p>
            <asp:Label ID="labelName" runat="server" Text="Name"></asp:Label>
        </p>
        <p>
            <asp:Label ID="labelJet" runat="server" Text="Jet"></asp:Label>
        </p>
        <p>
            <asp:Label ID="labelDestination" runat="server" Text="Destination"></asp:Label>
        </p>
        <p>
            <asp:Label ID="labelDate" runat="server" Text="Date"></asp:Label>
        </p>
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Properties/images/QR_Code.jpg" />
        </p>
        <p>
            <asp:Button ID="btnPrint" runat="server" Height="62px" Text="Print" Width="297px" OnClientClick="javascript:window.print();" />
        </p>
        <p>
            <asp:Button ID="btnMenu" runat="server" Height="48px" PostBackUrl="~/Menu.aspx" Text="Return to Menu" Width="299px" />
        </p>
    <div style="padding-bottom: 20px; margin: 0 auto;">
         <a href="credits.html">Credits</a>
    </div>
           
    </div>
    </form>
        </div>
</body>
</html>
