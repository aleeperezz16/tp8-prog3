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
        ManejoDeSurcursales MDS = new ManejoDeSurcursales();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /* // prueba ddl
                DataTable sucursales = new DataTable();
                sucursales = MDS.ObtenerSucursales();

                ddlprovincias.DataSource = sucursales;
                ddlprovincias.DataTextField = "Provincia";
                ddlprovincias.DataValueField = "Id_ProvinciaSucursal";
                ddlprovincias.DataBind();*/
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Sucursal NuevaSucursal = new Sucursal();
            
            NuevaSucursal = CrearSucursalDesdePagina();
            
            lblResultado.Text = MDS.agregarSucursal(NuevaSucursal) ? "La sucursal se ha agregado con exito" : "No se pudo agregar la sucursal";
            
        }
        
        private Sucursal CrearSucursalDesdePagina()
        {
            Sucursal sucursal = new Sucursal();

            string nombre = txtNombreSucursal.Text;
            string descripcion = txtDescripcion.Text;
            int idProvincia = ddlprovincias.SelectedIndex;
            string direccion = txtDescripcion.Text;

            sucursal.Nombre = nombre;
            sucursal.Descripcion = descripcion;
            sucursal.IdProvincia = idProvincia;
            sucursal.Direccion = direccion;

            return sucursal;
        }
    }
}