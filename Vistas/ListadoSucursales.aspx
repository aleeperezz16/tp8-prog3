<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vistas.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
         .links-container a {
        margin-left: 60px;
        }
         .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 243px;
            text-align: center;
            height: 40px;
        }
        .auto-style16 {
            width: 319px;
            height: 40px;
        }
        .auto-style17 {
            width: 69px;
            height: 40px;
        }
        .auto-style18 {
            height: 40px;
        }
        .auto-style9 {
            width: 243px;
            height: 34px;
        }
        .auto-style13 {
            width: 319px;
            height: 34px;
        }
        .auto-style14 {
            width: 69px;
            height: 34px;
        }
        .auto-style15 {
            height: 34px;
        }
        .auto-style10 {
            width: 243px;
            height: 23px;
        }
        .auto-style7 {
            width: 319px;
            height: 23px;
        }
        .auto-style12 {
            width: 69px;
            height: 23px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListarSucursal.aspx">Listado de Sucursales</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="lbListadodesucursales" runat="server" Font-Bold="True" Font-Size="Large" Text="Listado de Sucursales"></asp:Label>
                    </td>
                    <td class="auto-style16"></td>
                    <td class="auto-style17"></td>
                    <td class="auto-style18"></td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="lbbusquedaidsucur" runat="server" Text="Busqueda ingrese Id sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtIDSucursal" runat="server" ValidationGroup="filtro" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="txtIDSucursal" ValidationGroup="filtro">Ingrese un ID</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style14">
                        <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" ValidationGroup="filtro" />
                    </td>
                    <td class="auto-style15">
                        <asp:Button ID="btnMostrarTodos" runat="server" OnClick="btnMostrarTodos_Click" Text="Mostrar Todos" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style7">
                        <asp:CompareValidator ID="cmpvID" runat="server" ControlToValidate="txtIDSucursal" ErrorMessage="El ID debe ser un numero" Operator="DataTypeCheck" Type="Integer" ValidationGroup="filtro"></asp:CompareValidator>
                    </td>
                    <td class="auto-style12"></td>
                    <td></td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="gridSucursales" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
