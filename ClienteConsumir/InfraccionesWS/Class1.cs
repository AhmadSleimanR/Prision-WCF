using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraccionesWS
{
    public class Class1
    {
        ProxyInfracciones.Service1Client objInfraccionesCliente = new ProxyInfracciones.Service1Client();

        public List<ProxyInfracciones.PapeletaBE> ObtenerPapeletasFechas(DateTime fecIni, DateTime fecFin) {
                return objInfraccionesCliente.ObtenerPapeletasFechas(fecIni, fecFin);
        }

        public List<ProxyInfracciones.PapeletaBE> ObtenerPapeletasImpagasVehiculo(String numPlaca)
        {
            return objInfraccionesCliente.ObtenerPapeletasImpagasVehiculo(numPlaca);
        }
    }
}
