<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeerXML.aspx.cs" Inherits="LeerXML.LeerXML" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Message" runat="server"></asp:Label>
        <br />
        <br />
     <asp:Button ID="bt_crear_XML" runat="server" Text="Crear XML" onClick="bt_crear_XML_Click"/>
        <br />
        <br />
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
            Text="Buscar" />
        <asp:Button ID="btnEliminar" runat="server" onclick="btnEliminar_Click" 
            Text="Eliminar" />
    </div>
    </form>
</body>
</html>
