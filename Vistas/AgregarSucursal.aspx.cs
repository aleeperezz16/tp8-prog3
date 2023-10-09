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
        static private NegocioSurcursales _negocio = new NegocioSurcursales();

        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlprovincias.DataSource = _negocio.ObtenerProvincias();
                ddlprovincias.DataTextField = "DescripcionProvincia";
                ddlprovincias.DataValueField = "Id_Provincia";
                ddlprovincias.DataBind();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Sucursal nuevaSucursal = new Sucursal();

            nuevaSucursal.Nombre = txtNombreSucursal.Text.Trim();
            nuevaSucursal.Descripcion = txtDescripcion.Text.Trim();
            nuevaSucursal.IdProvincia = Convert.ToInt32(ddlprovincias.SelectedValue);
            nuevaSucursal.Direccion = txtDireccion.Text.Trim();
            
            lblResultado.Text = _negocio.agregarSucursal(nuevaSucursal) ? "La sucursal se ha agregado con exito" : "No se pudo agregar la sucursal";
        }

        
    }
}