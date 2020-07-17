<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConcurrencyDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
            <table border="1">
                <tr>
                    <td>
                        <b>Account Number</b>
                    </td>
                    <td>
                        <asp:Label ID="lblAccountNumber" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Account Name</b>
                    </td>
                    <td>
                        <asp:Label ID="lblAccountName" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Account Balance</b>
                    </td>
                    <td>
                        <asp:Label ID="lblAccountBalance" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnDeposit" runat="server" Text="Deposit $500"
                OnClick="btnDeposit_Click" />
        </div>
    </form>
</body>
</html>
