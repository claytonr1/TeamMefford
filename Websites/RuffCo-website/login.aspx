<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

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
    </style>
</head>
<body style="margin: 0 auto; display: table; background-color: #ededed;">

    <div class="container">
    <form id="form1" runat="server">
        <table  class="auto-style1">

             <tr class="header">
                <td class="logo"><img src="/properties/images/Logo.png" width="260"/></td>
                <td class="headerTitle"><strong>Ruffco Airlines</strong><br />
                    <span class="fontSize20"><em>&quot;Rough air made easy&quot;</em></span></td>
                
            </tr>
            </table>
        <table  class="auto-style1">
            <tr class="centerMenu">
               
                <td>Please log in to continue:<asp:Label ID="labelErrorBox" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr class="centerMenu">
                
                <td>
                   &nbsp;
                       <asp:Label ID="Label1" runat="server" Text="User Name:"></asp:Label>
                    &nbsp;
                     <asp:TextBox ID="txtboxUsername" runat="server" Height="30px" Width="283px"></asp:TextBox>
                    &nbsp;
                </td>
            </tr>
            <tr class="centerMenu">
                
                <td class="loginPassword">
                    &nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>

                    &nbsp;&nbsp;

                    &nbsp;

                    <asp:TextBox ID="txtboxPassword" runat="server" TextMode="Password" Width="285px" Height="30px"></asp:TextBox>
                    &nbsp;
                </td>
            </tr>
            <tr class="centerMenu">
                <td class="auto-style3">
                    Username/pass to use (or any in database)<br />
                    timglor1 123456 </td>
                &nbsp;
                <td>

                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                </td>
            </tr>
        </table>
    </form>
        </div>
    </body>
</html>
