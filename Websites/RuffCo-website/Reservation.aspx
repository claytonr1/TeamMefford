<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reservation.aspx.cs" Inherits="RuffCoJetReservationSystem.Reservation" %>

<!DOCTYPE html>
<script runat="server">

  
    
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reservations</title>
    <style type="text/css">

       
       
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
            padding: 0px 0px 30px 0px;
        }

         .auto-style1 {
            width: 100%;
            
        }
        .auto-style8 {
            height: 29px;
        }
        .auto-style2 {
            height: 42px;
        }
        .auto-style3 {
            height: 36px;
        }
        .auto-style4 {
            height: 29px;
            width: 103px;
        }
        .auto-style5 {
            height: 36px;
            width: 103px;
        }
        .auto-style6 {
            height: 42px;
            width: 103px;
        }
        .auto-style7 {
            width: 103px;
        }
        #Select1 {
            width: 115px;
        }
        #destinationSelect {
            width: 110px;
        }
        #jetSelect {
            width: 109px;
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

        <table style=" height: 206px; margin: 0 auto;">
            <tr>
                <td class="auto-style4">Name</td>
                <td class="auto-style8">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Destination</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="destinationDropDownList" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Departure Date</td>
                <td class="auto-style2">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                        <TodayDayStyle BackColor="#CCCCCC" />
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Departure Time</td>
                <td>
                    <h3>
                        <asp:TextBox ID="hourBox" runat="server" Width="30px">12</asp:TextBox>
&nbsp;:
                        <asp:TextBox ID="minuteBox" runat="server" Width="30px">00</asp:TextBox>
&nbsp;<asp:DropDownList ID="ampmDropDownList" runat="server">
                            <asp:ListItem>AM</asp:ListItem>
                            <asp:ListItem>PM</asp:ListItem>
                        </asp:DropDownList>
                    </h3>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Available Jets</td>
                <td>
                    <asp:DropDownList ID="jetsDropDownList" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <p style="margin: 0 auto; display: table; padding-left: 210px; ">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnMakeReservation" runat="server" OnClick="Button1_Click" Text="Make Reservation" />
    
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/Menu.aspx" Text="Back" />
        </p>
    </form>
  </div>
</body>
</html>
