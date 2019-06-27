using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Consultas_VisitaConsultas : System.Web.UI.Page
{
   
   
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            ProxyVisitas.ServicioVisitaClient objSer = new ProxyVisitas.ServicioVisitaClient();
           // ProxyVisitas.Visita objVisi = new ProxyVisitas.Visita();

            if (Page.IsPostBack == false )
            {
                gvVisitas.DataSource = objSer.GetAllVisita();
                gvVisitas.DataBind();
                Label4.Text = gvVisitas.Rows.Count.ToString();
            }
        }
        catch (Exception ex)
        { 
        lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }

    }

   

    protected void gvVisitas_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      /*  try
        {
        int indicefila;

        //Se obtiene el indice de la fila seleccionada en el gridview
        indicefila = Convert.ToInt16 (e.CommandArgument);

        // Si se hizo click en el boton Editar
        if (e.CommandName == "visitante")
            {
             //Guardamos en una variable de sesion el codigo del f seleccionado
            int codVisitante = Convert.ToInt16(gvVisitas.Rows[indicefila].Cells[3].Text);
                ProxyVisitantes.ServicioVisitanteClient obJVisit = new ProxyVisitantes.ServicioVisitanteClient();


                ProxyDistritos.ServicioDistritoClient objD = new ProxyDistritos.ServicioDistritoClient();

                Label14.Text = obJVisit.GetVisitante(codVisitante).apeVisitante + " , " + obJVisit.GetVisitante(codVisitante).nomVisitante;
                Label16.Text = obJVisit.GetVisitante(codVisitante).dniVisitante;
                Label20.Text = objD.GetDistrito(Convert.ToInt16(obJVisit.GetVisitante(codVisitante).disVisitante)).nomDistrito;
                Label18.Text = obJVisit.GetVisitante(codVisitante).dirVisitante;


                
            }
        
        }
        catch (Exception ex)
        {
         lblMensaje.Text = "Se produjo el error..." + ex.Message; 
        }*/
     }




    protected void btnFiltrar_Click(object sender, EventArgs e)
    {
        try
        {
            ProxyVisitas.ServicioVisitaClient objSer = new ProxyVisitas.ServicioVisitaClient();
            gvVisitas.DataSource = objSer.GetAllVisitaFechas(Convert.ToDateTime(TextBox1.Text), Convert.ToDateTime(TextBox2.Text));
            gvVisitas.DataBind();
            Label4.Text = gvVisitas.Rows.Count.ToString();
            lblMensaje.Text = "Consultada exitosa";
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
            gvVisitas.DataSource = null;
            gvVisitas.DataBind();
        }

    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {
            ProxyVisitas.ServicioVisitaClient objSer = new ProxyVisitas.ServicioVisitaClient();       

                 
                gvVisitas.DataSource = objSer.GetAllVisitaPreso(txtDNI.Text);
                gvVisitas.DataBind();
                Label4.Text = gvVisitas.Rows.Count.ToString();
            lblMensaje.Text = "Consulta realizada con exito";
            
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }
    }
}