<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_8___Validation._Default" %>

<form id="form1" runat="server">
    
    <div style="height: 529px; width: 831px">
        <br />
        <center>
            <asp:Label ID="Label6" runat="server" Text="Registration" Font-Size="20pt"></asp:Label>
        </center>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Font-Size="18pt" Text="Name: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"  Width="382px">
        </asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="TextBox1" ErrorMessage="Please enter name!">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Font-Size="18pt" Text="Address: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"  Width="382px" Height="53px" Rows="3" TextMode="MultiLine">
        </asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
            ControlToValidate="TextBox2" ErrorMessage="Please enter address">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Font-Size="18pt" Text="Phone: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"  Width="382px" MaxLength="10">
        </asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
            ControlToValidate="TextBox3" ErrorMessage="Please enter phone number!">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Font-Size="18pt" Text="Age: "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" Width="382px">
        </asp:TextBox>
        <asp:RangeValidator ID="RangeValidator2" runat="server"
            ControlToValidate="TextBox4" ErrorMessage="Please enter age between 18-60"
            MaximumValue="60" MinimumValue="18" Type="Integer">
        </asp:RangeValidator>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Font-Size="18pt" Text="Email: "></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" Width="382px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
            ControlToValidate="TextBox5" ErrorMessage="Please enter correct email id!"
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
        </asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Font-Size="18pt" Text="Password: "></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox6" runat="server"  Width="382px" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
            ControlToValidate="TextBox1" ErrorMessage="Please enter password!">
        </asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Font-Size="18pt" Text="Re-Password: "></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" Width="347px" TextMode="Password">
        </asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox6" ControlToValidate="TextBox7" ErrorMessage="Password not matching!"></asp:CompareValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" Font-Size="18pt" />
        <br />
        <br />
    </div>

</form>


