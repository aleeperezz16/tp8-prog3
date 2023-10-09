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
                                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="GRUPO N° 6"></asp:Label>
                                </td>
                                <td class="auto-style14"></td>
                                <td class="auto-style8"></td>
                            </tr>
                            <tr>
                                <td class="auto-style9"></td>
                                <td class="auto-style10">
                                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Agregar Sucursal"></asp:Label>
                                </td>
                                <td class="auto-style15"></td>
                                <td class="auto-style12"></td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style3">
                                    <asp:Label ID="Label3" runat="server" Text="Nombre Sucursal:"></asp:Label>
                                </td>
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
                                    <asp:Label ID="Label4" runat="server" Text="Descripción:"></asp:Label>
                                </td>
                                <td class="auto-style13">
                                    <asp:TextBox ID="txtDescripcion" runat="server" Height="35px" Width="210px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvdescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Ingrese una Descripcion"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style3">
                                    <asp:Label ID="lbprovincia" runat="server" Text="Provincias:"></asp:Label>
                                </td>
                                <td class="auto-style13">
                                    <asp:DropDownList ID="ddlprovincias" runat="server" CssClass="auto-style21">
                                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvprovincias" runat="server" ControlToValidate="ddlprovincias" ErrorMessage="Seleccione una Provincia" InitialValue="--Seleccionar--"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style3">
                                    <asp:Label ID="lbdireccion" runat="server" Text="Dirección:"></asp:Label>
                                </td>
                                <td class="auto-style13">
                                    <asp:TextBox ID="txtDireccion" runat="server" Height="43px" Width="206px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvdireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Ingrese una Dirección"></asp:RequiredFieldValidator>
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
