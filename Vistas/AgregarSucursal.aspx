<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Vistas.AgregarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 29px;
        }
        .auto-style3 {
            width: 214px;
        }
        .auto-style13 {
            width: 220px;
        }
        .auto-style5 {
            width: 29px;
            height: 60px;
        }
        .auto-style6 {
            width: 214px;
            height: 60px;
            font-size: xx-large;
        }
        .auto-style14 {
            width: 220px;
            height: 60px;
        }
        .auto-style8 {
            height: 60px;
        }
        .auto-style9 {
            width: 29px;
            height: 50px;
        }
        .auto-style10 {
            width: 214px;
            height: 50px;
            font-size: x-large;
        }
        .auto-style15 {
            width: 220px;
            height: 50px;
        }
        .auto-style12 {
            height: 50px;
        }
        .auto-style16 {
            width: 29px;
            height: 25px;
        }
        .auto-style17 {
            width: 214px;
            height: 25px;
        }
        .auto-style18 {
            width: 220px;
            height: 25px;
        }
        .auto-style19 {
            height: 25px;
        }
        .auto-style21 {
            margin-left: 0px;
        }
        .auto-style22 {
            width: 29px;
            height: 53px;
        }
        .auto-style23 {
            width: 214px;
            height: 53px;
        }
        .auto-style24 {
            width: 220px;
            height: 53px;
        }
        .auto-style25 {
            height: 53px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style16"></td>
                                <td class="auto-style17" style="text-align: right">
                                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                                </td>
                                <td class="auto-style18" style="text-align: center">
                                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                                </td>
                                <td class="auto-style19">
                                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5"></td>
                                <td class="auto-style6">
                                    <strong>GRUPO N°6</strong></td>
                                <td class="auto-style14"></td>
                                <td class="auto-style8"></td>
                            </tr>
                            <tr>
                                <td class="auto-style9"></td>
                                <td class="auto-style10">
                                    <strong>Agregar Sucursal</strong></td>
                                <td class="auto-style15"></td>
                                <td class="auto-style12"></td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style3">
                                    Nombre Sucursal:</td>
                                <td class="auto-style13">
                                    <asp:TextBox ID="txtNombreSucursal" runat="server" Width="210px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server" ControlToValidate="txtNombreSucursal">Ingrese un nombre de sucursal</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style3">
                                    Descripción:</td>
                                <td class="auto-style13">
                                    <asp:TextBox ID="txtDescripcion" runat="server" Height="35px" Width="210px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion">Ingrese una descripción</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style3">
                                    Provincias:</td>
                                <td class="auto-style13">
                                    <asp:DropDownList ID="ddlProvincias" runat="server" CssClass="auto-style21" AppendDataBoundItems="True">
                                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvProvincias" runat="server" ControlToValidate="ddlprovincias" InitialValue="--Seleccionar--">Seleccione una provincia</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style22"></td>
                                <td class="auto-style23">
                                    Dirección:</td>
                                <td class="auto-style24">
                                    <asp:TextBox ID="txtDireccion" runat="server" Height="43px" Width="206px"></asp:TextBox>
                                </td>
                                <td class="auto-style25">
                                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion">Ingrese una dirección</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style3">
                                    &nbsp;</td>
                                <td class="auto-style13">
                                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                                </td>
                                <td>
                                    <asp:Label ID="lblResultado" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style3">
                                    &nbsp;</td>
                                <td class="auto-style13">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
