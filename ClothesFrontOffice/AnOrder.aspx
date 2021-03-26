<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700; text-align: center; height: 69px; background-color: #66CCFF">
            <br />
            Order Form</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Order_ID:</td>
                <td>
                    <asp:TextBox ID="txtOrderID" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Order_Date:</td>
                <td>
                    <asp:TextBox ID="txtOrderDate" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Order_Type:</td>
                <td>
                    <asp:TextBox ID="txtOrderType" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Order_Cus_No:</td>
                <td>
                    <asp:TextBox ID="txtOrderCusNo" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Order_Product_No:</td>
                <td>
                    <asp:TextBox ID="txtOrderProNo" runat="server" Height="39px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="ButtonOK" runat="server" Height="45px" style="font-weight: 700; background-color: #FFFFCC" Text="OK" Width="122px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonCancel" runat="server" Height="45px" style="font-weight: 700; background-color: #FFFFCC" Text="Cancel" Width="122px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
