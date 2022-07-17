<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="category.aspx.cs" Inherits="_9___Master_and_themes_and_skin.category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <h3>Categories Viva!</h3>
    </center>
    <asp:Button ID="Button1" runat="server" Text="Categories" />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>MBA</asp:ListItem>
        <asp:ListItem>MCA</asp:ListItem>
    </asp:DropDownList>
</asp:Content>

