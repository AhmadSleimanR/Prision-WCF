using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Consultas_VisitaConsultas : System.Web.UI.Page
{
    ProxyVisita.ServicioVisitaClient objSer = new ProxyVisita.ServicioVisitaClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (Page.IsPostBack == false)
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

    protected void btnFiltrar_Click(object sender, EventArgs e)
    {
        try
        {
            //Este if/else carga la grilla base en caso de que los campos esten vacíos
            if (TextBox1.Text != "" && TextBox2.Text != ""){
                gvVisitas.DataSource = objSer.GetAllVisitaFechas(Convert.ToDateTime(TextBox1.Text), Convert.ToDateTime(TextBox2.Text));
                lblMensaje.Text = "Consultada exitosa";
            }
            else {
                gvVisitas.DataSource = objSer.GetAllVisita();
                lblMensaje.Text = "Ingrese Fechas";
            }
            gvVisitas.DataBind();
            Label4.Text = gvVisitas.Rows.Count.ToString();
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
            if (txtDNI.Text != "") { 
                gvVisitas.DataSource = objSer.GetAllVisitaPreso(txtDNI.Text);
                lblMensaje.Text = "Consulta realizada con exito";
            }
            else {
                gvVisitas.DataSource = objSer.GetAllVisita();
                lblMensaje.Text = "Ingrese un DNI";
            }

            gvVisitas.DataBind();
            Label4.Text = gvVisitas.Rows.Count.ToString();

        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }
    }

    protected void gvVisitas_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }

    protected void gvVisitas_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}