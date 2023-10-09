using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Vistas
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";

            if (cvSucursalId.IsValid)
            {
                NegocioSurcursales negocio = new NegocioSurcursales();
                lblResultado.Text = negocio.EliminarSucursal(Convert.ToInt32(txtIdSucursal.Text.Trim())) ? 
                    "La sucursal se ha eliminado con éxito" : "El ID ingresado es inexistente";
            }

            txtIdSucursal.Text = "";
        }

        protected void cvSucursalID_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string idSucursal = txtIdSucursal.Text.Trim();

            if (idSucursal.Length < 1)
            {
                args.IsValid = false;
                cvSucursalId.Text = "Ingrese un ID";

                return;
            }

            try
            {
                int.Parse(idSucursal);
            }
            catch
            {
                args.IsValid = false;
                cvSucursalId.Text = "Ingrese un ID válido";
            }
        }
    }
}