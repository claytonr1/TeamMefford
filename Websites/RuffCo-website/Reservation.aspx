<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reservation.aspx.cs" Inherits="RuffCoJetReservationSystem.Reservation" %>

<!DOCTYPE html>
<script runat="server">

  
    
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reservations</title>
    <style type="text/css">
        .auto-style1 {
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
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Reservations
    </h3>
    </div>
        <table style="width: 100%; height: 206px;">
            <tr>
                <td class="auto-style4">Name</td>
                <td class="auto-style1">
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
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Make Reservation" />
        </p>
    </form>
</body>
</html>
