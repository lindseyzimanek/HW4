﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet.css" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Net Pay Calculator</h1><br />
        Hourly wage:
        <asp:TextBox ID="txbxHourlyWage" runat="server"></asp:TextBox>
        <br />
        <br />
        Hours worked this week:
        <asp:TextBox ID="txbxHoursWorked" runat="server"></asp:TextBox>
        <br />
        <br />
        Pre-tax deductions:
        <asp:TextBox ID="txbxPretaxDeductions" runat="server"></asp:TextBox>
        <br />
        <br />
        After tax deductions:
        <asp:TextBox ID="txbxAfterTaxDeductions" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" />
        &nbsp;<asp:Button ID="btnClear" runat="server" Text="Clear" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
