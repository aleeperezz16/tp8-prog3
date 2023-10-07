<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="Vistas.EliminarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 172px;
        }
        .auto-style5 {
            width: 179px;
            text-align: center;
        }
        .auto-style11 {
            text-align: left;
        }
        .auto-style2 {
            font-size: x-large;
            width: 172px;
            height: 48px;
            padding-left:10px;
        }
        .auto-style6 {
            width: 179px;
            height: 48px;
        }
        .auto-style7 {
            height: 48px;
        }
        .auto-style9 {
            height: 26px;
            width: 172px;
            padding-left:10px;
        }
        .auto-style10 {
            height: 26px;
            width: 179px;
        }
        .auto-style8 {
            height: 26px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style4" style="padding-left: 40px">
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                            </td>
                            <td class="auto-style5">
                                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                            </td>
                            <td class="auto-style11">
                                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2"><strong>Eliminar Sucursal</strong></td>
                            <td class="auto-style6"></td>
                            <td class="auto-style7"></td>
                        </tr>
                        <tr>
                            <td class="auto-style9">Ingresar ID sucursal:</td>
                            <td class="auto-style10">
                                <asp:TextBox ID="tbIngresaridsuc" runat="server" Width="292px"></asp:TextBox>
                            </td>
                            <td class="auto-style8">
                                <asp:Button ID="btnEliminar" runat="server" class="auto-style12" OnClick="btnEliminar_Click" Text="Eliminar" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
