<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mcq.aspx.cs" Inherits="_11___MCQ.Mcq" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label5" runat="server" Font-Bold="True" FontUnderline="True" Text="Quiz Compatation"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Q.1]National animal of India?"></asp:Label>
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Lion" GroupName ="animal"/>
            &nbsp;
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Dog" GroupName ="animal"/>
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Tiger" GroupName ="animal"/>
            &nbsp;<asp:RadioButton ID="RadioButton4" runat="server" Text="Deer" GroupName ="animal"/>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Q.2]National bird of India?"></asp:Label>
            <br />
            <br />
            <asp:RadioButton ID="RadioButton5" runat="server" Text="Peacock" GroupName ="bird" />
            &nbsp;
            <asp:RadioButton ID="RadioButton7" runat="server" Text="Eagle" GroupName ="bird"/>
            <br />
            <asp:RadioButton ID="RadioButton6" runat="server" Text="Crow" GroupName ="bird"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton8" runat="server" Text="Kite" GroupName ="bird"/>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Q.3]National fruit of India?"></asp:Label>
            <br />
            <br />
            <asp:RadioButton ID="RadioButton9" runat="server" Text="Apple" GroupName ="fruit"/>
            &nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton12" runat="server" Text="Cherry" GroupName ="fruit"/>
            <br />
            <asp:RadioButton ID="RadioButton10" runat="server" Text="Mango" GroupName ="fruit"/>
            &nbsp;<asp:RadioButton ID="RadioButton11" runat="server" Text="Orange" GroupName ="fruit"/>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Q.4]National tree of India?"></asp:Label>
            <br />
            <br />
            <asp:RadioButton ID="RadioButton13" runat="server" Text="Neem Tree" GroupName ="tree"/>
            &nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton16" runat="server" Text="Peepal Tree" GroupName ="tree"/>
            <br />
            <asp:RadioButton ID="RadioButton14" runat="server" Text="Banyan Tree" GroupName ="tree"/>
            &nbsp;
            <asp:RadioButton ID="RadioButton15" runat="server" Text="Mango Tree" GroupName ="tree"/>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Submit" style="height: 26px" />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
