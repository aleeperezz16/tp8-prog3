<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vistas.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
         .links-container a {
        margin-left: 60px;
        }
         .auto-style2 {
            width: 249px;
            height: 46px;
        }
         .auto-style3 {
            width: 365px;
            height: 11px;
        }
        .auto-style4 {
            width: 249px;
            height: 11px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="links-container">
                        <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                        <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de sucursales</asp:HyperLink>
                        <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                        </div>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblistadosucursales" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Large" Text="Listado de Sucursales"></asp:Label>
                    </td>
                    <td class="auto-style3"> </td>
                    <td> </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="lbbusquedasucursal" runat="server" Text="Busqueda ingrese ID Sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtIdSucursal" runat="server" Width="204px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="RequiredFieldValidator">Ingrese un ID</asp:RequiredFieldValidator>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
