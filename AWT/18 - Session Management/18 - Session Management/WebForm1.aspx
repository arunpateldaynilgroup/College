<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_18___Session_Management.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp; &nbsp; &nbsp;
            <table style="width: 568px; height: 103px">
                <tr>
                    <td style="width: 209px">
                        <asp:Label ID="lblstr" runat="server" Text="Enter a String" Style="width: 94px">
                        </asp:Label>
                    </td>
                    <td style="width: 317px">
                        <asp:TextBox ID="txtstr" runat="server" Style="width: 227px"> </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 209px"></td>
                    <td style="width: 317px"></td>
                </tr>
                <tr>
                    <td style="width: 209px">
                        <asp:Button ID="btnnrm" runat="server" Text="No action button" Style="width: 128px" />
                    </td>
                    <td style="width: 317px">
                        <asp:Button ID="btnstr" runat="server" OnClick="btnstr_Click" Text="Submit the String" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 209px"></td>
                    <td style="width: 317px"></td>
                </tr>
                <tr>
                    <td style="width: 209px">
                        <asp:Label ID="lblsession" runat="server" Style="width: 231px"> </asp:Label>
                    </td>
                    <td style="width: 317px"></td>
                </tr>
                <tr>
                    <td style="width: 209px">
                        <asp:Label ID="lblshstr" runat="server"> </asp:Label>
                    </td>
                    <td style="width: 317px"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
