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

            if (cvSucursalID.IsValid)
            {
                Sucursal sucursal = new Sucursal();
                ManejoDeSurcursales manejoSuc = new ManejoDeSurcursales();
                sucursal.IdSucursal = int.Parse(tbIngresaridsuc.Text.Trim());
                bool sucursalEliminada = manejoSuc.eliminarSucursal(sucursal);

                if (sucursalEliminada)
                {
                    lbResultado.Text = "La sucursal se ha eliminado con éxito";
                }
                else
                {
                    lbResultado.Text = "El ID ingresado es inexistente";
                }
            }
            tbIngresaridsuc.Text = "";
        }

        protected void cvSucursalID_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (tbIngresaridsuc.Text.Trim().Length < 1)
            {
                args.IsValid = false;
                cvSucursalID.Text = "Ingrese un ID";
                return;
            }

            try
            {
                int.Parse(tbIngresaridsuc.Text);
            }
            catch (Exception)
            {
                args.IsValid = false;
                cvSucursalID.Text = "Ingrese un ID valido";
            }
        }
    }
}