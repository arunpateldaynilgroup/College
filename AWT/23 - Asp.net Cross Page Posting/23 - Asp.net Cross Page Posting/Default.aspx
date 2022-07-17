<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_23___Asp.net_Cross_Page_Posting.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter your name:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Style="margin-left: 27px" Width="160px"></asp:TextBox>
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Same Page Post Back" Width="182px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Style="margin-left: 76px" Text="Cross Page Post Back" Width="163px" PostBackUrl="~/WebForm1.aspx" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
