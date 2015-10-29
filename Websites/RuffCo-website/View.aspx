<%@ Page Language="C#" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/Menu.aspx" Text="Back" />
        <br />
        <br />
        Your current login info: //currently broken, out of context saving cookie<br />
   
        <br />
        <br />
        <br />
        Destinations:</div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="dest_id" DataSourceID="RuffcoDestinations" Height="271px" style="margin-top: 41px" Width="473px">
            <Columns>
                <asp:BoundField DataField="dest_id" HeaderText="dest_id" InsertVisible="False" ReadOnly="True" SortExpression="dest_id" />
                <asp:BoundField DataField="location" HeaderText="location" SortExpression="location" />
                <asp:BoundField DataField="distance_from_LR" HeaderText="distance_from_LR" SortExpression="distance_from_LR" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="RuffcoDestinations" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [RuffCoDestinations]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        Employees:<br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="employee_id" DataSourceID="RuffcoEmployees">
            <Columns>
                <asp:BoundField DataField="employee_id" HeaderText="employee_id" InsertVisible="False" ReadOnly="True" SortExpression="employee_id" />
                <asp:BoundField DataField="f_name" HeaderText="f_name" SortExpression="f_name" />
                <asp:BoundField DataField="l_name" HeaderText="l_name" SortExpression="l_name" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                <asp:BoundField DataField="user_name" HeaderText="user_name" SortExpression="user_name" />
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="RuffcoEmployees" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [RuffCoEmployees]"></asp:SqlDataSource>
        <br />
        Planes:<br />
        <br />
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="plane_id" DataSourceID="RuffcoPlanes">
            <Columns>
                <asp:BoundField DataField="plane_id" HeaderText="plane_id" InsertVisible="False" ReadOnly="True" SortExpression="plane_id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="model" HeaderText="model" SortExpression="model" />
                <asp:BoundField DataField="capacity" HeaderText="capacity" SortExpression="capacity" />
                <asp:BoundField DataField="mile_range" HeaderText="mile_range" SortExpression="mile_range" />
                <asp:BoundField DataField="current_location" HeaderText="current_location" SortExpression="current_location" />
                <asp:BoundField DataField="cruise_speed" HeaderText="cruise_speed" SortExpression="cruise_speed" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="RuffcoPlanes" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [RuffCoPlanes]"></asp:SqlDataSource>
        <br />
        <br />
        Reservations:<br />
        <br />
        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="reservation_id" DataSourceID="RuffcoReservations">
            <Columns>
                <asp:BoundField DataField="reservation_id" HeaderText="reservation_id" InsertVisible="False" ReadOnly="True" SortExpression="reservation_id" />
                <asp:BoundField DataField="plane_id" HeaderText="plane_id" SortExpression="plane_id" />
                <asp:BoundField DataField="employee_id" HeaderText="employee_id" SortExpression="employee_id" />
                <asp:BoundField DataField="dest_id" HeaderText="dest_id" SortExpression="dest_id" />
                <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="RuffcoReservations" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [RuffCoReservations]"></asp:SqlDataSource>
    </form>
</body>
</html>
