<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_19___Web_Services.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ENTER NAME:
            <asp:TextBox ID="TextBox1" runat="server"> </asp:TextBox>
            <br />
            <br />
            ENTER ACCOUNT NO:
            <asp:TextBox ID="TextBox2" runat="server"> </asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text=" "> </asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text=" "> </asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
