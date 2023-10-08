<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="EliminarSucursal.aspx.cs" Inherits="Vistas.EliminarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: x-large;
            width: 188px;
            height: 48px;
            padding-left:10px;
        }
        .auto-style3 {
            width: 269px;
            height: 48px;
        }
        .auto-style4 {
            height: 26px;
            width: 188px;
            padding-left: 10px;
        }
        .auto-style5{
            height: 26px;
            width: 269px;
        }
        .auto-style6 {
            height: 26px;
        }
        .links-container a {
        margin-left: 60px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="links-container">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style2"><strong>Eliminar Sucursal</strong></td>
                            <td class="auto-style3"></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Ingresar ID sucursal:</td>
                            <td class="auto-style5">
                                <asp:TextBox ID="tbIngresaridsuc" runat="server" Width="234px"></asp:TextBox>
                            </td>
                            <td class="auto-style6">
                                <asp:Button ID="btnEliminar" runat="server" class="auto-style12" OnClick="btnEliminar_Click" Text="Eliminar" Width="73px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                    <asp:Label ID="lbResultado" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td class="auto-style6">
                                <asp:CustomValidator ID="cvSucursalID" runat="server" ControlToValidate="tbIngresaridsuc" OnServerValidate="cvSucursalID_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
                            </td>
                            <td class="auto-style6"></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
