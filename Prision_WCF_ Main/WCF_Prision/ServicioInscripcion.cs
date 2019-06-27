using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Prision
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioInscripcion" in both code and config file together.
    public class ServicioInscripcion : IServicioInscripcion
    {
        public void DoWork()
        {
        }

        public List<InscripcionBE> GetAllInscripcion()
        {


            PrisionEntities MiPrision = new PrisionEntities();
            List<InscripcionBE> objListaInscripcionBE = new List<InscripcionBE>();

            try
            {

                var query = (from objIns in MiPrision.vwProgramasIngreso
                             orderby objIns.fecha_ini descending
                             select objIns);



                foreach (var resultado in query)
                {
                    InscripcionBE objInscripcionBE = new InscripcionBE();
                    objInscripcionBE.nomPreso = resultado.nom_preso;
                    objInscripcionBE.apePreso = resultado.ape_preso;

                    objInscripcionBE.nomPrograma = resultado.nom_programa;
                    objInscripcionBE.desPrograma = resultado.des_programa;

                    objInscripcionBE.fecIni = Convert.ToDateTime(resultado.fecha_ini);
                    objInscripcionBE.fecFin = Convert.ToDateTime(resultado.fecha_fin);





                    objListaInscripcionBE.Add(objInscripcionBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaInscripcionBE;
        }

        public List<InscripcionBE> GetAllInscripcionFechas(DateTime fecini, DateTime fecfin)
        {
            PrisionEntities MiPrision = new PrisionEntities();
            List<InscripcionBE> objListaInscripcionBE = new List<InscripcionBE>();
            try
            {
                var query = (from objIns in MiPrision.vwProgramasIngreso
                             where
                             objIns.fecha_ini >= fecini &&
                             objIns.fecha_ini <= fecfin
                             select objIns);
                foreach (var resultado in query)
                {
                    InscripcionBE objInscripcionBE = new InscripcionBE();
                    objInscripcionBE.nomPreso = resultado.nom_preso;
                    objInscripcionBE.apePreso = resultado.ape_preso;

                    objInscripcionBE.nomPrograma = resultado.nom_programa;
                    objInscripcionBE.desPrograma = resultado.des_programa;

                    objInscripcionBE.fecIni = Convert.ToDateTime(resultado.fecha_ini);
                    objInscripcionBE.fecFin = Convert.ToDateTime(resultado.fecha_fin);




                    objListaInscripcionBE.Add(objInscripcionBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objListaInscripcionBE;
        }

        public List<InscripcionBE> GetAllInscripcionPreso(string strDNI)
        {
            PrisionEntities MiPrision = new PrisionEntities();
            List<InscripcionBE> objListaInscripcionBE = new List<InscripcionBE>();
            try
            {
                var query = (from objIns in MiPrision.vwProgramasIngreso
                             where objIns.dni_preso == strDNI
                           
                             select objIns);
                foreach (var resultado in query)
                {
                    InscripcionBE objInscripcionBE = new InscripcionBE();
                    objInscripcionBE.nomPreso = resultado.nom_preso;
                    objInscripcionBE.apePreso = resultado.ape_preso;

                    objInscripcionBE.nomPrograma = resultado.nom_programa;
                    objInscripcionBE.desPrograma = resultado.des_programa;

                    objInscripcionBE.fecIni = Convert.ToDateTime(resultado.fecha_ini);
                    objInscripcionBE.fecFin = Convert.ToDateTime(resultado.fecha_fin);




                    objListaInscripcionBE.Add(objInscripcionBE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objListaInscripcionBE;
        }
    }
}
