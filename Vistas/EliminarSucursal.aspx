<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="Vistas.EliminarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 251px;
        }
        .auto-style3 {
            width: 199px;
        }
    </style>
</head>
<body>
    <form id="form2">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
