using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Consultas_IngresoConsultas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {


            ProxyIngreso.ServicioIngresoClient objSer = new ProxyIngreso.ServicioIngresoClient();


            if (Page.IsPostBack == false)
            {
                grvIngresos.DataSource = objSer.GetAllIngreso();
                grvIngresos.DataBind();
                Label2.Text = grvIngresos.Rows.Count.ToString();


            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }
    }

    protected void btnConsultar_Click(object sender, EventArgs e)
    {
        try
        {
            ProxyIngreso.ServicioIngresoClient objSer = new ProxyIngreso.ServicioIngresoClient();
            //Este if/else carga la grilla base en caso de que los campos esten vacíos
            if (txtIni.Text != "" && txtFin.Text != "")
                grvIngresos.DataSource = objSer.GetIngresoFechas(Convert.ToDateTime(txtIni.Text), Convert.ToDateTime(txtFin.Text));
            else
                grvIngresos.DataSource = objSer.GetAllIngreso();
            grvIngresos.DataBind();

            grvDelitos.DataSource = null;
            grvDelitos.DataBind();

            Label2.Text = grvIngresos.Rows.Count.ToString();

            lblMensaje.Text = "Consulta Exitosa";





        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
            grvIngresos.DataSource = null;
            grvIngresos.DataBind();

            grvDelitos.DataSource = null;
            grvDelitos.DataBind();
        }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {

            grvDelitos.DataSource = null;
            grvDelitos.DataBind();

            ProxyIngreso.ServicioIngresoClient objSer = new ProxyIngreso.ServicioIngresoClient();

            //Este if/else carga la grilla base en caso de que los campos esten vacíos
            if (txtDNI.Text != "")
                grvIngresos.DataSource = objSer.GetIngresosPreso(txtDNI.Text);
            else
                grvIngresos.DataSource = objSer.GetAllIngreso();
            grvIngresos.DataBind();
            Label2.Text = grvIngresos.Rows.Count.ToString();

            lblMensaje.Text = "Consulta Exitosa";





        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
            grvIngresos.DataSource = null;
            grvIngresos.DataBind();
        }
    }

    protected void grvIngresos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {

            int indicefila;

            //Se obtiene el indice de la fila seleccionada en el gridview
            indicefila = Convert.ToInt16(e.CommandArgument);
            // Si se hizo click en el boton ver
            if (e.CommandName == "detalles")
            {
                String strDNI = (grvIngresos.Rows[indicefila].Cells[0].Text);
                String grvFecIni = (grvIngresos.Rows[indicefila].Cells[4].Text);
                String grvFecFin = (grvIngresos.Rows[indicefila].Cells[5].Text);
                //Mostrar delitos
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