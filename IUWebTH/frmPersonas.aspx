﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPersonas.aspx.cs" Inherits="IUWebTH.frmPersonas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listado de personas.</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Listado de persona.<br />
        </div>
        <asp:GridView ID="GridViewPersonas" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:LinkButton ID="LinkRegistrar" runat="server" PostBackUrl="~/PersonaAgregar.aspx">Registrar Personas</asp:LinkButton>
    </form>
</body>
</html>
