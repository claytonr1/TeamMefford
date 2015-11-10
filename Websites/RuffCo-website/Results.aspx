<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Results.aspx.cs" Inherits="Results" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
        Thank you for booking on Ruffco Airlines!</p>
    <p>
        This is your reservation, please print this page for your records.</p>
    <form id="form1" runat="server">
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
            <asp:Button ID="btnMenu" runat="server" Height="48px" PostBackUrl="~/Menu.aspx" Text="Return to menu" Width="299px" />
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
