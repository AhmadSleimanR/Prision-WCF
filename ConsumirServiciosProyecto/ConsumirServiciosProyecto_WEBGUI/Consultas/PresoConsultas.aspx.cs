using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Consultas_PresoConsultas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConsultar_Click(object sender, EventArgs e)
    {
        try
        {
            ProxyIngreso.ServicioIngresoClient objSer = new ProxyIngreso.ServicioIngresoClient();
            if (txtDNI.Text != "") { 
                String strDNI = txtDNI.Text;
                grvIngresos.DataSource = objSer.GetIngresosPreso(strDNI);
                grvIngresos.DataBind();

                grvDelitos.DataSource = objSer.GetAllDelitosDNI(strDNI);
                grvDelitos.DataBind();
                lblNombre.Text = objSer.GetIngresosPreso(strDNI)[0].apePreso + " , " + objSer.GetIngresosPreso(strDNI)[0].nomPreso;
                lblDistrito.Text = objSer.GetIngresosPreso(strDNI)[0].disPreso;
                lblMensaje.Text = "Consultar exitosa";
            }
            else
                lblMensaje.Text = "Ingrese un DNI";
            

        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se produjo el error..." + ex.Message;
            lblDistrito.Text = "";
            lblNombre.Text = "";
        }
    }

    protected void grvIngresos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            String strDNI = txtDNI.Text;
            int indicefila;

            //Se obtiene el indice de la fila seleccionada en el gridview
            indicefila = Convert.ToInt16(e.CommandArgument);
            // Si se hizo click en el boton ver
            if (e.CommandName == "delitos")
            {
                String grvFecIni = (grvIngresos.Rows[indicefila].Cells[1].Text);
                String grvFecFin = (grvIngresos.Rows[indicefila].Cells[2].Text);
                ProxyIngreso.ServicioIngresoClient objSer = new ProxyIngreso.ServicioIngresoClient();
                grvDelitos.DataSource = objSer.GetAllDelitosDNIFechas(
                                         strDNI, Convert.ToDateTime(grvFecIni), Convert.ToDateTime(grvFecFin));
                grvDelitos.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = ex.Message;
        }
    }
}