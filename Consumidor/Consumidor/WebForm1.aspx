<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Consumidor.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingresar nombre de articulo</div>
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="199px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
        <asp:GridView ID="view" runat="server" Height="143px" Width="313px">
        </asp:GridView>
    </form>
</body>
</html>
