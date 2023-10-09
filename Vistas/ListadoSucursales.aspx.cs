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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NegocioSurcursales manejoSuc = new NegocioSurcursales();
                gridSucursales.DataSource = manejoSuc.ObtenerSucursales();
                gridSucursales.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            lbresultadobusqueda.Text = "";
            NegocioSurcursales manejoSuc = new NegocioSurcursales();
            int IdSucursal = Convert.ToInt32(txtIDSucursal.Text.ToString());
            gridSucursales.DataSource= manejoSuc.ObtenerSucursal(IdSucursal);
            gridSucursales.DataBind();

            if(!manejoSuc.ExisteSucursal(IdSucursal))
            {
                lbresultadobusqueda.Text = " No se encontró coincidencia con el ID solicitado";
            }

        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtIDSucursal.Text = "";
            lbresultadobusqueda.Text = "";
            Sucursal suc = new Sucursal();
            NegocioSurcursales manejoSuc = new NegocioSurcursales();

            gridSucursales.DataSource = manejoSuc.ObtenerSucursales();
            gridSucursales.DataBind();
        }
    }
}