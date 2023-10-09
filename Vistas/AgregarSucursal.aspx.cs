using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;
using System.Data;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        static private NegocioSucursales _negocio = new NegocioSucursales();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProvincias.DataSource = _negocio.ObtenerProvincias();
                ddlProvincias.DataTextField = "DescripcionProvincia";
                ddlProvincias.DataValueField = "Id_Provincia";
                ddlProvincias.DataBind();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Sucursal nuevaSucursal = new Sucursal();

            nuevaSucursal.Nombre = txtNombreSucursal.Text.Trim();
            nuevaSucursal.Descripcion = txtDescripcion.Text.Trim();
            nuevaSucursal.IdProvincia = Convert.ToInt32(ddlProvincias.SelectedValue);
            nuevaSucursal.Direccion = txtDireccion.Text.Trim();
            
            lblResultado.Text = _negocio.AgregarSucursal(nuevaSucursal) ? "La sucursal se ha agregado con exito" : "No se pudo agregar la sucursal";
        }
    }
}