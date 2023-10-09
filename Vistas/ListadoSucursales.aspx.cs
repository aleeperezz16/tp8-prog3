using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;


namespace Vistas
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        private static NegocioSucursales _negocio = new NegocioSucursales();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gridSucursales.DataSource = _negocio.ObtenerSucursales();
                gridSucursales.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            int idSucursal = Convert.ToInt32(txtIdSucursal.Text.Trim());
            
            if (!_negocio.ExisteSucursal(idSucursal))
            {
                lblResultadoBusqueda.Text = "No se encontró coincidencia con el Id solicitado";
                gridSucursales.DataSource = null;
            }
            else
            {
                gridSucursales.DataSource = _negocio.ObtenerSucursales(idSucursal);
                lblResultadoBusqueda.Text = "";
            }

            gridSucursales.DataBind();
            txtIdSucursal.Text = "";
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            gridSucursales.DataSource = _negocio.ObtenerSucursales();
            gridSucursales.DataBind();
            
            txtIdSucursal.Text = "";
            lblResultadoBusqueda.Text = "";
        }
    }
}