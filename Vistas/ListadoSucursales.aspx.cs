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
                ManejoDeSurcursales manejoSuc = new ManejoDeSurcursales();
                gridSucursales.DataSource = manejoSuc.ObtenerSucursales();
                gridSucursales.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            Sucursal suc = new Sucursal();
            ManejoDeSurcursales manejoSuc = new ManejoDeSurcursales();
        }
    }
}