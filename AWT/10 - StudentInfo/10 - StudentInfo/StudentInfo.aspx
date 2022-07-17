<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfo.aspx.cs" Inherits="_10___StudentInfo.StudentInfo" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: cadetblue">
            <center>
                <h2>Student Info</h2>
            </center>
            <asp:Label ID="Label1" runat="server" Text="Name:" Font- Bold="True" Font-Size="15pt"></asp:Label>
            &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Font- Bold="True" Font-Size="15pt"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="RollNo:" FontBold="True" Font- Size="15pt"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox2" runat="server" Font-Bold="True" Font- Size="15pt"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Sem:" Font- Bold="True" Font-Size="15pt"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox3" runat="server" Font-Bold="True" Font-Size="15pt"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Select" Font-Size="15pt" />
            &nbsp;
            <asp:Button ID="Button2" runat="server" Font-Bold="True" Text="Insert" Font-Size="15pt" OnClick="Button2_Click" />
            &nbsp;
            <asp:Button ID="Button3" runat="server" Font-Bold="True" Text="Update" Font-Size="15pt" OnClick="Button3_Click" />
            &nbsp;
            <asp:Button ID="Button4" runat="server" Font-Bold="True" Text="Delete" Font-Size="15pt" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Roll No" Font- Bold="True" Font-Size="15pt"></asp:Label>
            &nbsp;
            <asp:Label ID="Label5" runat="server" Text="Name" Font- Bold="True" Font-Size="15pt"></asp:Label>
            &nbsp;
            <asp:Label ID="Label6" runat="server" Text="Sem" Font- Bold="True" Font-Size="15pt"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Font-Bold="True" FontSize="15pt" Text="Label" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
