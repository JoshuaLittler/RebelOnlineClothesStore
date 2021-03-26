<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #CCCCFF;
        }
        .auto-style2 {
            width: 504px;
            text-align: right;
        }
        .auto-style3 {
            width: 504px;
            text-align: right;
            height: 49px;
        }
        .auto-style4 {
            height: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700; text-align: center; height: 69px; background-color: #66CCFF">
            <br />
            Customer Form</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Customer No:</td>
                <td>
                    <asp:TextBox ID="txtCustomerNo" runat="server" Height="39px" Width="315px"></asp:TextBox>
                    <asp:Button ID="btnFind" runat="server" Height="45px" style="font-weight: 700; background-color: #FFFFCC" Text="Find" Width="122px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">First Name:</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Surname:</td>
                <td>
                    <asp:TextBox ID="txtSurname" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtEmail" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">House No:</td>
                <td>
                    <asp:TextBox ID="txtHouseNo" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Street:</td>
                <td>
                    <asp:TextBox ID="txtStreet" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Town:</td>
                <td>
                    <asp:TextBox ID="txtTown" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Post Code:</td>
                <td>
                    <asp:TextBox ID="txtPostCode" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Date Of Birth:</td>
                <td>
                    <asp:TextBox ID="txtDateOfBirth" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Active:</td>
                <td>
                    <asp:TextBox ID="txtActive" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
                <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonCancel" runat="server" Height="45px" style="font-weight: 700; background-color: #FFFFCC" Text="Cancel" Width="122px" />
                    <asp:Button ID="btnOK" runat="server" Height="45px" style="font-weight: 700; background-color: #FFFFCC" Text="OK" Width="122px" />
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
