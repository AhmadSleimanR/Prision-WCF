using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirServiciosProyecto_WS
{
    class ServicioIgreso
    {
        //Se declara la instancia del ProxyIngreso con la cual vamos a llamar a los metodos.
        ProxyIngreso.ServicioIngresoClient objIngresoCliente = new ProxyIngreso.ServicioIngresoClient();

        /**************************   A partir de aquí se encuentran declarados los metodos "logicos" *******************************/
        public List<ProxyIngreso.IngresoBE> GetAllIngreso()
        {
            return objIngresoCliente.GetAllIngreso();
        }

        public List<ProxyIngreso.IngresoBE> GetAllPresoPorSalirFechas(DateTime fecini, DateTime fecfin)
        {
            return objIngresoCliente.GetAllPresoPorSalirFechas(fecini, fecfin);
        }

        public List<ProxyIngreso.IngresoBE> GetIngresoFechas(DateTime fecIni, DateTime fecFin)
        {
            return objIngresoCliente.GetIngresoFechas(fecIni, fecFin);
        }

        public List<ProxyIngreso.IngresoBE> GetIngresosPreso(string strDNI)
        {
            return objIngresoCliente.GetIngresosPreso(strDNI);
        }

        public List<ProxyIngreso.DelitoBE> GetAllDelitosDNI(string strDNI)
        {
            return objIngresoCliente.GetAllDelitosDNI(strDNI);
        }

        public List<ProxyIngreso.DelitoBE> GetAllDelitosDNIFechas(string strDNI, DateTime fecIni, DateTime fecFin)
        {
            return objIngresoCliente.GetAllDelitosDNIFechas(strDNI, fecIni, fecFin);
        }

    }
}
