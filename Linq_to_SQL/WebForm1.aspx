﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Linq_to_SQL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>   
    <form id="form1" runat="server">
        <div style="height: 281px; width: 529px">
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <asp:Label ID="lblDept" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnGetData" runat="server" OnClick="btnGetData_Click" Text="GetData" />
&nbsp;<asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            <br />
            <asp:Button ID="btnGetEmployeesByDepartment" runat="server" OnClick="btnGetEmployeesByDepartment_Click" Text="Get Employees By Department" />
        </div>
    </form>
</body>
</html>
