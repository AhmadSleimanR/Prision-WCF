using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Consultas_InscripcionConsultas : System.Web.UI.Page
{
    ProxyInscripcion.ServicioInscripcionClient objSer = new ProxyInscripcion.ServicioInscripcionClient();

    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            if (Page.IsPostBack == false)
            {
                gvInscripciones.DataSource = objSer.GetAllInscripcion();
                gvInscripciones.DataBind();
                Label5.Text = gvInscripciones.Rows.Count.ToString();

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
            //Este if/else carga la grilla base en caso de que los campos esten vacíos
            if (txtIni.Text != "" && txtFin.Text != "")
                gvInscripciones.DataSource = objSer.GetAllInscripcionFechas(Convert.ToDateTime(txtIni.Text), Convert.ToDateTime(txtFin.Text));
            else
                gvInscripciones.DataSource = objSer.GetAllInscripcion();
            gvInscripciones.DataBind();
            Label5.Text = gvInscripciones.Rows.Count.ToString();
            lblMensaje.Text = "Consulta realizadacon  exito";
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se produjo un error :  " + ex.Message;
            gvInscripciones.DataSource = null;
            gvInscripciones.DataBind();
        }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {
            //Este if/else carga la grilla base en caso de que los campos esten vacíos
            if (txtDNI.Text != "")
                gvInscripciones.DataSource = objSer.GetAllInscripcionPreso(txtDNI.Text);
            else 
                gvInscripciones.DataSource = objSer.GetAllInscripcion();
            gvInscripciones.DataBind();
            Label5.Text = gvInscripciones.Rows.Count.ToString();
            lblMensaje.Text = "Consulta realizada con  exito";
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se produjo un error :  " + ex.Message;
            gvInscripciones.DataSource = null;
            gvInscripciones.DataBind();
        }
    }
}