<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_13___Implement_Simple_Stored_Procedure.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label2" runat="server"
            Text="Welcome to Stored Procedure Example"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Top Rankers"></asp:Label>

        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Show Result" OnClick="Button1_Click" />
    </form>
</body>
</html>
