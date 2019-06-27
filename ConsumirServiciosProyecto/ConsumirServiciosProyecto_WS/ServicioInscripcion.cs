using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirServiciosProyecto_WS
{
    class ServicioInscripcion
    {
        //Se declara la instancia del ProxyInscripcion con la cual vamos a llamar a los metodos.
        ProxyInscripcion.ServicioInscripcionClient objInscripcionCliente = new ProxyInscripcion.ServicioInscripcionClient();

        /**************************   A partir de aquí se encuentran declarados los metodos "logicos" *******************************/
        public List<ProxyInscripcion.InscripcionBE> GetAllInscripcion()
        {
            return objInscripcionCliente.GetAllInscripcion();
        }

        public List<ProxyInscripcion.InscripcionBE> GetAllInscripcionFechas(DateTime fecini, DateTime fecfin)
        {
            return objInscripcionCliente.GetAllInscripcionFechas(fecini, fecfin);
        }

        public List<ProxyInscripcion.InscripcionBE> GetAllInscripcionPreso(string strDNI)
        {
            return objInscripcionCliente.GetAllInscripcionPreso(strDNI);
        }
    }
}
