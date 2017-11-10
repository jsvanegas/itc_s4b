<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="categorias.aspx.cs" Inherits="Tienda.categorias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox runat="server" ID="lstCategorias">
            </asp:ListBox>
        </div>
        <div>

            <asp:TextBox runat="server" ID="txtNombre" placeholder="Nombre." />
            <asp:TextBox runat="server" ID="txtImagen" placeholder="URL Imagen" />
            <asp:Button Text="Enviar" runat="server" ID="btnEnviar" OnClick="btnEnviar_Click" />

        </div>
    </form>
</body>
</html>
