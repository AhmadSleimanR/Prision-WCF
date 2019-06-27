using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirServiciosProyecto_WS
{
    class ServicioVisita
    {
        //Se declara la instancia del ProxyInscripcion con la cual vamos a llamar a los metodos.
        ProxyVisita.ServicioVisitaClient objVisitaCliente = new ProxyVisita.ServicioVisitaClient();

        /**************************   A partir de aquí se encuentran declarados los metodos "logicos" *******************************/

        public List<ProxyVisita.VisitaBE> GetAllVisita()
        {
            return objVisitaCliente.GetAllVisita();
        }

        public List<ProxyVisita.VisitaBE> GetAllVisitaFechas(DateTime fecini, DateTime fecfin)
        {
            return objVisitaCliente.GetAllVisitaFechas(fecini, fecfin);
        }

        public List<ProxyVisita.VisitaBE> GetAllVisitaPreso(string strDNI)
        {
            return objVisitaCliente.GetAllVisitaPreso(strDNI);
        }
    }
}
