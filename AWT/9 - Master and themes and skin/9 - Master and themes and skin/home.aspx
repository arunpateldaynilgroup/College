<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="home.aspx.cs" Inherits="_9___Master_and_themes_and_skin.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    Welcome to viva!
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label">Name: </asp:Label>
    &nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" />
    <br />
</asp:Content>
