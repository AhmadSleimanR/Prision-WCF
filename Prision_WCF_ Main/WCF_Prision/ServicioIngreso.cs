using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


using System.Data.SqlClient;


namespace WCF_Prision
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioIngreso" in both code and config file together.
    public class ServicioIngreso : IServicioIngreso
    {
        public void DoWork()
        {
        }
        SqlConnection cnx =
          new SqlConnection("server=.; Database=Prision; Integrated Security=true");
        SqlCommand cmd = new SqlCommand();


        public List<IngresoBE> GetAllIngreso()
        {
            PrisionEntities MiPrision = new PrisionEntities();
            List<IngresoBE> objListaIngresoBE = new List<IngresoBE>();

            try
            {

                var query = (from objIng in MiPrision.vwIngresosPreso
                             orderby objIng.fec_ingreso descending
                             select objIng);


                foreach (var resultado in query)
                {
                    IngresoBE objIngresoBE = new IngresoBE();

                    objIngresoBE.nomPreso = resultado.nom_preso;
                    objIngresoBE.apePreso = resultado.ape_preso;
                    objIngresoBE.dniPreso = resultado.dni_preso;
                    objIngresoBE.disPreso = resultado.nom_distrito;
                    objIngresoBE.codCelda = resultado.cod_celda;
                    objIngresoBE.fecIngreso = Convert.ToDateTime(resultado.fec_ingreso);
                    objIngresoBE.fecSalida = Convert.ToDateTime(resultado.fec_salida);
                    objIngresoBE.estado = resultado.estado;

                    var query2 = (from objIng in MiPrision.vwProgramasIngreso
                                  where objIng.cod_ingreso == resultado.cod_ingreso
                                  orderby objIng.fec_ingreso descending
                                  select objIng);

                    objIngresoBE.inscripciones = new List<InscripcionBE>();


                    foreach (var dato in query2)
                    {
                        InscripcionBE objIncripcionBE = new InscripcionBE();
                       // objIncripcionBE.nomPreso = (dato.nom_preso);
                        //objIncripcionBE.apePreso = (dato.ape_preso);
                        objIncripcionBE.nomPrograma = (dato.nom_programa);
                        objIncripcionBE.desPrograma = (dato.des_programa);
                        objIncripcionBE.fecIni = (Convert.ToDateTime(dato.fecha_ini));
                        objIncripcionBE.fecFin = (Convert.ToDateTime(dato.fecha_fin));

                        objIngresoBE.inscripciones.Add(objIncripcionBE);
                    }


                    //************************VISITAS
                 /*   var query3 = (from objVi in MiPrision.vwVisitasIngreso
                                  where objVi.cod_ingreso == resultado.cod_ingreso
                                  orderby objVi.fec_visita descending
                                  select objVi);
                    objIngresoBE.visitas = new List<VisitaBE>();




                    foreach (var dato in query3)
                    {
                        VisitaBE objVisitaBE = new VisitaBE();
                      // objVisitaBE.nomPreso = (dato.nom_preso);
                     //   objVisitaBE.apePreso = (dato.ape_preso);
                        objVisitaBE.nomVisitante = (dato.nom_visitante);
                        objVisitaBE.apeVisitante = (dato.ape_visitante);
                        objVisitaBE.disVisitante = (dato.nom_distrito);
                        objVisitaBE.dirVisitante = (dato.dir_visitante);
                        objVisitaBE.dniVisitante = (dato.dni_visitante);

                        objVisitaBE.fecVisita = (Convert.ToDateTime(dato.fec_visita));
                        objVisitaBE.motVisita = (dato.motivo_visita);


                        objIngresoBE.visitas.Add(objVisitaBE);
                    }*/

                    //************************Delitos
                    var query4 = (from objDeli in MiPrision.vwDelitosIngreso
                                  where objDeli.cod_ingreso == resultado.cod_ingreso
                                  orderby objDeli.fec_ingreso descending
                                  select objDeli);
                    objIngresoBE.delitos = new List<DelitoBE>();
                   



                    foreach (var dato in query4)
                    {
                        DelitoBE objDelitoBE = new DelitoBE();
                     
                        objDelitoBE.nomDelito = (dato.des_delito);
                        objDelitoBE.participacion = (dato.participacion);

                    

                        objIngresoBE.delitos.Add(objDelitoBE);
                    }

                    //agregamos la instancia al alista de data contractual a la lista de 
                    objListaIngresoBE.Add(objIngresoBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaIngresoBE;
        }

        public List<IngresoBE> GetAllPresoPorSalirFechas(DateTime fecini, DateTime fecfin)
        {
            



            PrisionEntities MiPrision = new PrisionEntities();
            List<IngresoBE> objListaIngresoBE = new List<IngresoBE>();

            try
            {

                var query = (from objIng in MiPrision.vwIngresosPreso
                             where objIng.fec_salida >= fecini && objIng.fec_salida <= fecfin
                             orderby objIng.fec_ingreso descending
                             select objIng);


                foreach (var resultado in query)
                {
                    IngresoBE objIngresoBE = new IngresoBE();

                    objIngresoBE.nomPreso = resultado.nom_preso;
                    objIngresoBE.apePreso = resultado.ape_preso;
                   // objIngresoBE.dniPreso = resultado.dni_preso;
                    objIngresoBE.disPreso = resultado.nom_distrito;
                    objIngresoBE.codCelda = resultado.cod_celda;
                    objIngresoBE.fecIngreso = Convert.ToDateTime(resultado.fec_ingreso);
                    objIngresoBE.fecSalida = Convert.ToDateTime(resultado.fec_salida);
                    objIngresoBE.estado = resultado.estado;

                    var query2 = (from objIng in MiPrision.vwProgramasIngreso
                                  where objIng.cod_ingreso == resultado.cod_ingreso
                                  orderby objIng.fec_ingreso descending
                                  select objIng);

                    objIngresoBE.inscripciones = new List<InscripcionBE>();


                    foreach (var dato in query2)
                    {
                        InscripcionBE objIncripcionBE = new InscripcionBE();
                         objIncripcionBE.nomPreso =   (dato.nom_preso);
                        objIncripcionBE.apePreso=(dato.ape_preso);
                        objIncripcionBE.nomPrograma = (dato.nom_programa);
                        objIncripcionBE.desPrograma = (dato.des_programa);
                        objIncripcionBE.fecIni = (Convert.ToDateTime(dato.fecha_ini));
                        objIncripcionBE.fecFin = (Convert.ToDateTime(dato.fecha_fin));

                        objIngresoBE.inscripciones.Add(objIncripcionBE);
                    }


                    //************************VISITAS
                /*  var query3 = (from objVi in MiPrision.vwVisitasIngreso
                                  where objVi.cod_ingreso == resultado.cod_ingreso
                                  orderby objVi.fec_visita descending
                                  select objVi);
                    objIngresoBE.visitas = new List<VisitaBE>();




                    foreach (var dato in query3)
                    {
                        VisitaBE objVisitaBE = new VisitaBE();
                        objVisitaBE.nomPreso =   (dato.nom_preso);
                        objVisitaBE.apePreso=(dato.ape_preso);
                        objVisitaBE.nomVisitante = (dato.nom_visitante);
                        objVisitaBE.apeVisitante = (dato.ape_visitante);
                        objVisitaBE.disVisitante = (dato.nom_distrito);
                        objVisitaBE.dirVisitante = (dato.dir_visitante);
                        objVisitaBE.dniVisitante = (dato.dni_visitante);

                        objVisitaBE.fecVisita = (Convert.ToDateTime(dato.fec_visita));
                        objVisitaBE.motVisita = (dato.motivo_visita);


                        objIngresoBE.visitas.Add(objVisitaBE);
                    }*/

                    //************************Delitos
                    var query4 = (from objDeli in MiPrision.vwDelitosIngreso
                                  where objDeli.cod_ingreso == resultado.cod_ingreso
                                  orderby objDeli.fec_ingreso descending
                                  select objDeli);
                    objIngresoBE.delitos = new List<DelitoBE>();
                    //objIngresoBE.listaInscripcion.Add((InscripcionBE)query3);



                    foreach (var dato in query4)
                    {
                        DelitoBE objDelitoBE = new DelitoBE();
                        // objVisitaBE.nomPreso =   (dato.nom_preso);
                        //objVisitaBE.apePreso=(dato.ape_preso);
                        objDelitoBE.nomDelito = (dato.des_delito);
                        objDelitoBE.participacion = (dato.participacion);



                        objIngresoBE.delitos.Add(objDelitoBE);
                    }

                    //agregamos la instancia al alista de data contractual a la lista de 
                    objListaIngresoBE.Add(objIngresoBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaIngresoBE;

        }

        public List<IngresoBE> GetIngresoFechas(DateTime fecIni, DateTime fecFin)
        {



            PrisionEntities MiPrision = new PrisionEntities();
            List<IngresoBE> objListaIngresoBE = new List<IngresoBE>();

            try
            {

                var query = (from objIng in MiPrision.vwIngresosPreso
                             where objIng.fec_ingreso >= fecIni && objIng.fec_ingreso <= fecFin
                             orderby objIng.fec_ingreso descending
                             select objIng);


                foreach (var resultado in query)
                {
                    IngresoBE objIngresoBE = new IngresoBE();

                    objIngresoBE.nomPreso = resultado.nom_preso;
                    objIngresoBE.apePreso = resultado.ape_preso;
                    objIngresoBE.dniPreso = resultado.dni_preso;
                    objIngresoBE.disPreso = resultado.nom_distrito;
                    objIngresoBE.codCelda = resultado.cod_celda;
                    objIngresoBE.fecIngreso = Convert.ToDateTime(resultado.fec_ingreso);
                    objIngresoBE.fecSalida = Convert.ToDateTime(resultado.fec_salida);
                    objIngresoBE.estado = resultado.estado;

                    var query2 = (from objIng in MiPrision.vwProgramasIngreso
                                  where objIng.cod_ingreso == resultado.cod_ingreso
                                  orderby objIng.fec_ingreso descending
                                  select objIng);

                    objIngresoBE.inscripciones = new List<InscripcionBE>();


                    foreach (var dato in query2)
                    {
                        InscripcionBE objIncripcionBE = new InscripcionBE();
                         objIncripcionBE.nomPreso =   (dato.nom_preso);
                        objIncripcionBE.apePreso=(dato.ape_preso);
                        objIncripcionBE.nomPrograma = (dato.nom_programa);
                        objIncripcionBE.desPrograma = (dato.des_programa);
                        objIncripcionBE.fecIni = (Convert.ToDateTime(dato.fecha_ini));
                        objIncripcionBE.fecFin = (Convert.ToDateTime(dato.fecha_fin));

                        objIngresoBE.inscripciones.Add(objIncripcionBE);
                    }


                    //************************VISITAS
                  /*  var query3 = (from objVi in MiPrision.vwVisitasIngreso
                                  where objVi.cod_ingreso == resultado.cod_ingreso
                                  orderby objVi.fec_visita descending
                                  select objVi);
                    objIngresoBE.visitas = new List<VisitaBE>();




                    foreach (var dato in query3)
                    {
                        VisitaBE objVisitaBE = new VisitaBE();
                         objVisitaBE.nomPreso =   (dato.nom_preso);
                        objVisitaBE.apePreso=(dato.ape_preso);
                        objVisitaBE.nomVisitante = (dato.nom_visitante);
                        objVisitaBE.apeVisitante = (dato.ape_visitante);
                        objVisitaBE.disVisitante = (dato.nom_distrito);
                        objVisitaBE.dirVisitante = (dato.dir_visitante);
                        objVisitaBE.dniVisitante = (dato.dni_visitante);

                        objVisitaBE.fecVisita = (Convert.ToDateTime(dato.fec_visita));
                        objVisitaBE.motVisita = (dato.motivo_visita);


                        objIngresoBE.visitas.Add(objVisitaBE);
                    }*/

                    //************************Delitos
                    var query4 = (from objDeli in MiPrision.vwDelitosIngreso
                                  where objDeli.cod_ingreso == resultado.cod_ingreso
                                  orderby objDeli.fec_ingreso descending
                                  select objDeli);
                    objIngresoBE.delitos = new List<DelitoBE>();
                    //objIngresoBE.listaInscripcion.Add((InscripcionBE)query3);



                    foreach (var dato in query4)
                    {
                        DelitoBE objDelitoBE = new DelitoBE();
                        // objVisitaBE.nomPreso =   (dato.nom_preso);
                        //objVisitaBE.apePreso=(dato.ape_preso);
                        objDelitoBE.nomDelito = (dato.des_delito);
                        objDelitoBE.participacion = (dato.participacion);



                        objIngresoBE.delitos.Add(objDelitoBE);
                    }

                    //agregamos la instancia al alista de data contractual a la lista de 
                    objListaIngresoBE.Add(objIngresoBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaIngresoBE;


        }

        public List<IngresoBE> GetIngresosPreso(string strDNI)
        {


            PrisionEntities MiPrision = new PrisionEntities();
            List<IngresoBE> objListaIngresoBE = new List<IngresoBE>();

            try
            {

              

                var query = (from objIng in MiPrision.vwIngresosPreso
                             where objIng.dni_preso == strDNI
                             orderby objIng.fec_ingreso descending
                             select objIng);

                foreach (var resultado in query)
                {
                    IngresoBE objIngresoBE = new IngresoBE();

                    objIngresoBE.nomPreso = resultado.nom_preso;
                    objIngresoBE.apePreso = resultado.ape_preso;
                       objIngresoBE.dniPreso = resultado.dni_preso;
                    objIngresoBE.disPreso = resultado.nom_distrito;
                    objIngresoBE.codCelda = resultado.cod_celda;
                    objIngresoBE.fecIngreso = Convert.ToDateTime(resultado.fec_ingreso);
                    objIngresoBE.fecSalida = Convert.ToDateTime(resultado.fec_salida);
                    objIngresoBE.estado = resultado.estado;

                    var query2 = (from objIng in MiPrision.vwProgramasIngreso
                                  where objIng.cod_ingreso == resultado.cod_ingreso
                                  orderby objIng.fec_ingreso descending
                                  select objIng);

                    objIngresoBE.inscripciones = new List<InscripcionBE>();


                    foreach (var dato in query2)
                    {
                        InscripcionBE objIncripcionBE = new InscripcionBE();
                        objIncripcionBE.nomPreso =   (dato.nom_preso);
                        objIncripcionBE.apePreso=(dato.ape_preso);
                        objIncripcionBE.nomPrograma = (dato.nom_programa);
                        objIncripcionBE.desPrograma = (dato.des_programa);
                        objIncripcionBE.fecIni = (Convert.ToDateTime(dato.fecha_ini));
                        objIncripcionBE.fecFin = (Convert.ToDateTime(dato.fecha_fin));

                        objIngresoBE.inscripciones.Add(objIncripcionBE);
                    }


                    //************************VISITAS
                /*    var query3 = (from objVi in MiPrision.vwVisitasIngreso
                                  where objVi.cod_ingreso == resultado.cod_ingreso
                                  orderby objVi.fec_visita descending
                                  select objVi);
                    objIngresoBE.visitas = new List<VisitaBE>();




                    foreach (var dato in query3)
                    {
                        VisitaBE objVisitaBE = new VisitaBE();
                         objVisitaBE.nomPreso =   (dato.nom_preso);
                        objVisitaBE.apePreso=(dato.ape_preso);
                        objVisitaBE.nomVisitante = (dato.nom_visitante);
                        objVisitaBE.apeVisitante = (dato.ape_visitante);
                        objVisitaBE.disVisitante = (dato.nom_distrito);
                        objVisitaBE.dirVisitante = (dato.dir_visitante);
                        objVisitaBE.dniVisitante = (dato.dni_visitante);

                        objVisitaBE.fecVisita = (Convert.ToDateTime(dato.fec_visita));
                        objVisitaBE.motVisita = (dato.motivo_visita);


                        objIngresoBE.visitas.Add(objVisitaBE);
                    }*/

                    //************************Delitos
                    var query4 = (from objDeli in MiPrision.vwDelitosIngreso
                                  where objDeli.cod_ingreso == resultado.cod_ingreso
                                  orderby objDeli.fec_ingreso descending
                                  select objDeli);
                    objIngresoBE.delitos = new List<DelitoBE>();
                    //objIngresoBE.listaInscripcion.Add((InscripcionBE)query3);



                    foreach (var dato in query4)
                    {
                        DelitoBE objDelitoBE = new DelitoBE();
                        // objVisitaBE.nomPreso =   (dato.nom_preso);
                        //objVisitaBE.apePreso=(dato.ape_preso);
                        objDelitoBE.nomDelito = (dato.des_delito);
                        objDelitoBE.participacion = (dato.participacion);



                        objIngresoBE.delitos.Add(objDelitoBE);
                    }

                    //agregamos la instancia al alista de data contractual a la lista de 
                    objListaIngresoBE.Add(objIngresoBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaIngresoBE;
        }

        //dELITOS
        public List<DelitoBE> GetAllDelitosDNI(string strDNI)
        {
            PrisionEntities MiPrision = new PrisionEntities();
            List<DelitoBE> objListaDelitoBE = new List<DelitoBE>();

            try
            {

                var query = (from objDeli in MiPrision.vwDelitosIngreso
                             where objDeli.dni_preso == strDNI
                             orderby objDeli.fec_ingreso descending
                             select objDeli);



                foreach (var resultado in query)
                {
                    DelitoBE objDelitoBE = new DelitoBE();
                    objDelitoBE.nomDelito = resultado.des_delito;
                    objDelitoBE.participacion = resultado.participacion;







                    objListaDelitoBE.Add(objDelitoBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaDelitoBE;
        }

        public List<DelitoBE> GetAllDelitosDNIFechas(string strDNI, DateTime fecIni, DateTime fecFin)
        {
            PrisionEntities MiPrision = new PrisionEntities();
            List<DelitoBE> objListaDelitoBE = new List<DelitoBE>();

            try
            {

                var query = (from objDeli in MiPrision.vwDelitosIngreso
                             where objDeli.dni_preso == strDNI && objDeli.fec_ingreso >= fecIni && objDeli.fec_ingreso <= fecFin
                             orderby objDeli.fec_ingreso descending
                             select objDeli);



                foreach (var resultado in query)
                {
                    DelitoBE objDelitoBE = new DelitoBE();
                    objDelitoBE.nomDelito = resultado.des_delito;
                    objDelitoBE.participacion = resultado.participacion;







                    objListaDelitoBE.Add(objDelitoBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListaDelitoBE;
        }

      
    }
    

   }
