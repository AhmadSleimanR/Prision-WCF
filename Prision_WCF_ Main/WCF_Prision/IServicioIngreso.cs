using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


using System.Data;
using System.Data.SqlClient;
namespace WCF_Prision
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioIngreso" in both code and config file together.
    [ServiceContract]
    public interface IServicioIngreso
    {
        [OperationContract]
        void DoWork();
        //va
        [OperationContract]
        List<IngresoBE> GetAllIngreso();
        //va
        [OperationContract]
        List<IngresoBE> GetIngresosPreso(String strDNI);

        [OperationContract]
        List<IngresoBE> GetIngresoFechas(DateTime fecIni, DateTime fecFin);

        [OperationContract]
        List<IngresoBE> GetAllPresoPorSalirFechas(DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<DelitoBE> GetAllDelitosDNI(String strDNI);
        [OperationContract]
        List<DelitoBE> GetAllDelitosDNIFechas(String strDNI, DateTime fecIni, DateTime fecFin);

      
       


    }
    //INGRESO
    [DataContract]
    [Serializable]
    public class IngresoBE
    {
        private String _nomPreso;
        private String _apePreso;
        private String _disPreso;
        private String _dniPreso;

        private System.DateTime _fecIngreso;
        private System.DateTime _fecSalida;
        private Single _codCelda;
        private String _estado;

        private List<InscripcionBE> _inscripciones;

       

        private List<DelitoBE> _delitos;


        
        [DataMember]
        public List<DelitoBE> delitos
        {
            get { return this._delitos; }
            set { this._delitos = value; }
        }

     

        [DataMember]
        public List<InscripcionBE> inscripciones
        {
            get { return this._inscripciones; }
            set { this._inscripciones = value; }
        }


        [DataMember]
        public String dniPreso
        {
            get { return this._dniPreso; }
            set { this._dniPreso = value; }
        }

        [DataMember]
        public String nomPreso
        {
            get { return this._nomPreso; }
            set { this._nomPreso = value; }
        }
        [DataMember]
        public String apePreso
        {
            get { return this._apePreso; }
            set { this._apePreso = value; }
        }

        [DataMember]
        public String disPreso
        {
            get { return this._disPreso; }
            set { this._disPreso = value; }
        }


        [DataMember]
        public Single codCelda
        {
            get { return this._codCelda; }
            set { this._codCelda = value; }
        }

        [DataMember]
        public System.DateTime fecIngreso
        {
            get { return this._fecIngreso; }
            set { this._fecIngreso = value; }
        }

        [DataMember]
        public System.DateTime fecSalida
        {
            get { return this._fecSalida; }
            set { this._fecSalida = value; }
        }
        [DataMember]
        public String estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }
    }

    

   

  
}
