<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vistas.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 300px;
            height: 26px;
        }
        .auto-style3 {
            width: 199px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style6 {
            width: 300px;
            height: 29px;
            text-align: center;
        }
        .auto-style7 {
            width: 199px;
            height: 29px;
        }
        .auto-style8 {
            height: 29px;
        }
        .auto-style9 {
            width: 300px;
            height: 57px;
            text-align: center;
        }
        .auto-style10 {
            width: 199px;
            height: 57px;
        }
        .auto-style11 {
            height: 57px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style4">
                        <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    </td>
                    <td class="auto-style3">
                    </td>
                    <td class="auto-style4">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="lblistadosucursales" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Text="Listado de Sucursales"></asp:Label>
                    </td>
                    <td class="auto-style7">
                    </td>
                    <td class="auto-style8">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="lbbusquedasucursal" runat="server" Text="Busqueda ingrese ID Sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style10">
                    </td>
                    <td class="auto-style11">
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
