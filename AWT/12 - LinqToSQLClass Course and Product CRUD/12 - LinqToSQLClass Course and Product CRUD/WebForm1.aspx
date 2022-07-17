<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_12___LinqToSQLClass_Course_and_Product_CRUD.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: Aqua">
            <h1>Fetching data using LINQ</h1>
            Enter product id:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            Enter product name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            Enter product price:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
            <br />
            <br />
            
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="_12___LinqToSQLClass_Course_and_Product_CRUD.DataClasses1DataContext" EntityTypeName=""
                TableName="Products">
            </asp:LinqDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
