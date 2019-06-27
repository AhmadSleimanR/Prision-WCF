using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Consultas_InscripcionConsultas : System.Web.UI.Page
{
    ProxyInscripciones.ServicioInscripcionClient objSer = new ProxyInscripciones.ServicioInscripcionClient();

   

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            

            if (Page.IsPostBack == false )
            {
                gvInscripciones.DataSource = objSer.GetAllInscripcion();
                gvInscripciones.DataBind();
                Label5.Text = gvInscripciones.Rows.Count.ToString();

              /*  cboProgramas.DataSource = objSerP.GetAllPrograma();
                //esos nomDistritos son
                cboProgramas.DataTextField = "nomPrograma"; //q se muesstra
                cboProgramas.DataValueField = "codPrograma"; //q usa
                cboProgramas.DataBind();*/

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
            //ProxyInscripciones.ServicioInscripcionClient objSer = new ProxyInscripciones.ServicioInscripcionClient();
            gvInscripciones.DataSource = objSer.GetAllInscripcionFechas(Convert.ToDateTime(txtIni.Text), Convert.ToDateTime(txtFin.Text));
            gvInscripciones.DataBind();
            Label5.Text = gvInscripciones.Rows.Count.ToString();
            lblMensaje.Text = "Consulta realizadacon  exito";
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "sE PRODujo un error :  " + ex.Message;
            gvInscripciones.DataSource = null;
            gvInscripciones.DataBind();
        }
    }



    protected void btnBuscar_Click(object sender, EventArgs e)
    {   
        try
        {
           //ProxyInscripciones.ServicioInscripcionClient objSer = new ProxyInscripciones.ServicioInscripcionClient();
            gvInscripciones.DataSource = objSer.GetAllInscripcionPreso(txtDNI.Text);
            gvInscripciones.DataBind();
            Label5.Text = gvInscripciones.Rows.Count.ToString();
            lblMensaje.Text = "Consulta realizada con  exito";
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "sE PRODujo un error :  " + ex.Message;
            gvInscripciones.DataSource = null;
            gvInscripciones.DataBind();
        }
    }
}