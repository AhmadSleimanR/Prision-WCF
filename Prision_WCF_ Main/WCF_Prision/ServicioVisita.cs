using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Prision
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioVisita" in both code and config file together.
    public class ServicioVisita : IServicioVisita
    {
        public void DoWork()
        {
        }

        public List<VisitaBE> GetAllVisita()
        {

            PrisionEntities MiPrision = new PrisionEntities();
            List<VisitaBE> objListaVisitaBE = new List<VisitaBE>();

            try
            {

                var query = (from objVisita in MiPrision.vwVisitasIngreso
                             orderby objVisita.fec_visita descending
                             select objVisita);



                foreach (var resultado in query)
                {
                    VisitaBE objVisitaBE = new VisitaBE();
                    objVisitaBE.nomVisitante = resultado.nom_visitante;
                    objVisitaBE.apeVisitante = resultado.ape_visitante;
                    objVisitaBE.dniVisitante = resultado.dni_visitante;
                    objVisitaBE.dirVisitante = resultado.dir_visitante;
                    objVisitaBE.disVisitante = resultado.nom_distrito;

                    objVisitaBE.fecVisita = Convert.ToDateTime(resultado.fec_visita);
                    objVisitaBE.motVisita = (resultado.motivo_visita);

                    objVisitaBE.nomPreso = resultado.nom_preso;
                    objVisitaBE.apePreso = resultado.ape_preso;
                    objVisitaBE.dniPreso = resultado.dni_preso;



                    objListaVisitaBE.Add(objVisitaBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaVisitaBE;
        }

        public List<VisitaBE> GetAllVisitaFechas(DateTime fecini, DateTime fecfin)
        {

            PrisionEntities MiPrision = new PrisionEntities();
            List<VisitaBE> objListaVisitaBE = new List<VisitaBE>();
            try
            {
                var query = (from ObjVis in MiPrision.vwVisitasIngreso
                             where
                             ObjVis.fec_visita >= fecini &&
                             ObjVis.fec_visita <= fecfin
                             select ObjVis);
                foreach (var resultado in query)
                {
                    VisitaBE objVisitaBE = new VisitaBE();
                    objVisitaBE.nomVisitante = resultado.nom_visitante;
                    objVisitaBE.apeVisitante = resultado.ape_visitante;
                    objVisitaBE.dniVisitante = resultado.dni_visitante;
                    objVisitaBE.dirVisitante = resultado.dir_visitante;
                    objVisitaBE.disVisitante = resultado.nom_distrito;

                    objVisitaBE.fecVisita = Convert.ToDateTime(resultado.fec_visita);
                    objVisitaBE.motVisita = (resultado.motivo_visita);

                    objVisitaBE.nomPreso = resultado.nom_preso;
                    objVisitaBE.apePreso = resultado.ape_preso;
                    objVisitaBE.dniPreso = resultado.dni_preso;



                    objListaVisitaBE.Add(objVisitaBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objListaVisitaBE;
        }

        public List<VisitaBE> GetAllVisitaPreso(string strDNI)
        {
            PrisionEntities MiPrision = new PrisionEntities();
            List<VisitaBE> objListaVisitaBE = new List<VisitaBE>();
            try
            {
                var query = (from ObjVis in MiPrision.vwVisitasIngreso
                             where ObjVis.dni_preso == strDNI
                              
                             select ObjVis);
                foreach (var resultado in query)
                {
                    VisitaBE objVisitaBE = new VisitaBE();
                    objVisitaBE.nomVisitante = resultado.nom_visitante;
                    objVisitaBE.apeVisitante = resultado.ape_visitante;
                    objVisitaBE.dniVisitante = resultado.dni_visitante;
                    objVisitaBE.dirVisitante = resultado.dir_visitante;
                    objVisitaBE.disVisitante = resultado.nom_distrito;

                    objVisitaBE.fecVisita = Convert.ToDateTime(resultado.fec_visita);
                    objVisitaBE.motVisita = (resultado.motivo_visita);

                    objVisitaBE.nomPreso = resultado.nom_preso;
                    objVisitaBE.apePreso = resultado.ape_preso;
                    objVisitaBE.dniPreso = resultado.dni_preso;



                    objListaVisitaBE.Add(objVisitaBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objListaVisitaBE;
        }
    }
}
