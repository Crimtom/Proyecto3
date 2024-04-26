<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaPokemon.aspx.cs" Inherits="Proyecto_WEB_API.CSU.ConsultaUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="img_pokemon_sprite" runat="server" Height="126px" Width="148px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre "></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="195px"></asp:TextBox>
        <br />
        <br />
&nbsp;
        <br />
        <asp:Button ID="Button1" runat="server" Text="Consultar Datos" Width="165px" OnClick="Button1_Click" />
        <br />
        
    </form>
</body>
</html>
