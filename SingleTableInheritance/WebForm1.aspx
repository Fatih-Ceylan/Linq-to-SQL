<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SingleTableInheritance.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

   <div style="font-family: Arial">
<asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True"
    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
    <asp:ListItem Text="Load all Employees" Value="All"></asp:ListItem>
    <asp:ListItem Text="Load Permanent Employees" Value="Permanent">
    </asp:ListItem>
    <asp:ListItem Text="Load Contract Employees" Value="Contract">
    </asp:ListItem>
</asp:RadioButtonList>
<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="129px" Width="333px">
    <AlternatingRowStyle BackColor="White" />
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
       <br />
       <asp:Button ID="btnAddEmployees" runat="server" OnClick="btnAddEmployees_Click" Text="Add Employees" />
</div>

    </form>
</body>
</html>
