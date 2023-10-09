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
            width: 347px;
            text-align: center;
            height: 40px;
            font-size: large;
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
        .auto-style7 {
            width: 319px;
            height: 23px;
        }
        .auto-style12 {
            width: 69px;
            height: 23px;
        }
        .auto-style19 {
            width: 347px;
            height: 34px;
            text-align: center;
        }
        .auto-style20 {
            width: 347px;
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
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <strong>Listado de Sucursales</strong></td>
                    <td class="auto-style16"></td>
                    <td class="auto-style17"></td>
                    <td class="auto-style18"></td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        Búsqueda ingrese Id sucursal:</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtIdSucursal" runat="server" ValidationGroup="filtro" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvIdSucursal" runat="server" ControlToValidate="txtIdSucursal" ValidationGroup="filtro">Ingrese un Id</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style14">
                        <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" ValidationGroup="filtro" />
                    </td>
                    <td class="auto-style15">
                        <asp:Button ID="btnMostrarTodos" runat="server" OnClick="btnMostrarTodos_Click" Text="Mostrar Todos" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20"></td>
                    <td class="auto-style7">
                        <asp:CompareValidator ID="cvId" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="El Id debe ser un número" Operator="DataTypeCheck" Type="Integer" ValidationGroup="filtro"></asp:CompareValidator>
                    </td>
                    <td class="auto-style12"></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:Label ID="lblResultadoBusqueda" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="gridSucursales" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
