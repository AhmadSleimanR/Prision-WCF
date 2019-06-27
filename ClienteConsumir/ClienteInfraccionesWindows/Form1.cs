using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfraccionesWS;

namespace ClienteInfraccionesWindows
{
    public partial class Form1 : Form
    {
        Class1 objServicioInfracciones = new Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            try
            {
                dtgInfracciones.DataSource = objServicioInfracciones.ObtenerPapeletasFechas(Convert.ToDateTime(txtFecIni.Text), Convert.ToDateTime(txtFecFin.Text));
                if (dtgInfracciones.Rows.Count == 0)
                {
                    throw new Exception("No hay papeletas en la fecha seleccionada.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);

            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            try
            {
                dtgInfracciones.DataSource = objServicioInfracciones.ObtenerPapeletasImpagasVehiculo(txtPlaca.Text);
                if (dtgInfracciones.Rows.Count == 0)
                {
                    throw new Exception("La placa no tiene infracciones sin pagar.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);

            }
        }
    }
}
