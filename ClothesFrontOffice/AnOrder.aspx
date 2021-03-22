<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 350px;
            text-align: right;
        }
        .auto-style2 {
            height: 257px;
        }
        .auto-style3 {
            width: 100%;
            height: 217px;
        }
        .auto-style4 {
            width: 350px;
            text-align: right;
            height: 44px;
        }
        .auto-style5 {
            height: 44px;
        }
        .auto-style7 {
            background-color: #CCFFFF;
        }
        .auto-style9 {
            width: 350px;
        }
        .auto-style10 {
            height: 44px;
            width: 350px;
        }
        .auto-style12 {
            font-weight: bold;
            background-color: #66CCFF;
        }
    </style>
</head>
<body style="height: 266px">
    <form id="form1" runat="server">
        <div class="auto-style2">
            <table class="auto-style3">
                <tr>
                    <td class="auto-style1">
                        <strong>
            <asp:Label ID="LabelOrderID" runat="server" Text="Order_ID" CssClass="auto-style7"></asp:Label>
                        </strong>
                    </td>
                    <td class="auto-style9">
            <asp:TextBox ID="txtOrderID" runat="server" Height="34px" style="margin-bottom: 0px" Width="274px"></asp:TextBox>
            
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
            
                        <strong>
            
            <asp:Label ID="LabelOrderDate" runat="server" Text="Order_Date" CssClass="auto-style7"></asp:Label>
                        </strong>
                    </td>
                    <td class="auto-style9">
            <asp:TextBox ID="TxtOrderDate" runat="server" Height="34px" style="margin-bottom: 0px" Width="270px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
            
                        <strong>
            
            <asp:Label ID="LabelOrderCusNO" runat="server" Text="Order_Cus_No" CssClass="auto-style7"></asp:Label>
                        </strong>
                    </td>
                    <td class="auto-style9">
            <asp:TextBox ID="TxtOrderCusNO" runat="server" Height="34px" style="margin-bottom: 0px" Width="270px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
            
                        <strong>
            
            <asp:Label ID="LabelOrderProductNO" runat="server" Text="Order_Product_No" CssClass="auto-style7"></asp:Label>
                        </strong>
                    </td>
                    <td class="auto-style10">
            <asp:TextBox ID="TxtOrderProductNO" runat="server" Height="34px" style="margin-bottom: 0px" Width="270px"></asp:TextBox>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style1">
            
                        &nbsp;</td>
                    <td class="auto-style9">
                        </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
            
                        &nbsp;</td>
                    <td class="auto-style9">&nbsp;<strong><asp:Button ID="ButtonOK" runat="server" CssClass="auto-style12" Height="41px" Text="OK" Width="125px" />
                        </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
                        <asp:Button ID="ButtonCancel" runat="server" CssClass="auto-style12" Height="41px" Text="Cancel" Width="125px" />
                        </strong> </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>