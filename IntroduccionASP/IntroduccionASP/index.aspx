<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="IntroduccionASP.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txtCaja1" />
            <asp:Button Text="Enviar" runat="server" ID="btnEnviar" OnClick="btnEnviar_Click" />
            <asp:Button Text="Enviar JS" runat="server" ID="btnEnviarJS" OnClientClick="copiarTexto(event)" />
            <asp:TextBox runat="server" ID="txtCaja2" />

        </div>
    </form>

    <script type="text/javascript">
        function copiarTexto(event) {
            event.preventDefault();
            var txtCaja1 = document.getElementById("txtCaja1");
            var txtCaja2 = document.getElementById("txtCaja2");
            txtCaja2.value = txtCaja1.value;
            txtCaja1.value = "";
        }

    </script>

</body>
</html>
