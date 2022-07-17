<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_14___Parameterized_Stored_Procedure.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: cadetblue">
            <center>
                <h2>WELCOME TO STORED PROCEDURE EXAMPLE-2!!</h2>
                <asp:Table ID="Table1" runat="server" Font-Bold="True" Font-Size="15pt">
                    <asp:TableRow>
                        <asp:TableCell Text="Enter Start Range"></asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="TextBox1" runat="server">
                            </asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell Text="Enter End Range"></asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="TextBox2" runat="server">
                            </asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Button ID="Button1" runat="server" Text="Show Result" OnClick="Button1_Click" /></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font- Size="15pt"></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>
