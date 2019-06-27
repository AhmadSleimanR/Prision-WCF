using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Prision
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioVisita" in both code and config file together.
    [ServiceContract]
    public interface IServicioVisita
    {
        [OperationContract]
        void DoWork();

        //va
        [OperationContract]
        List<VisitaBE> GetAllVisita(); //listar

        //va
        [OperationContract]
        List<VisitaBE> GetAllVisitaFechas(DateTime fecini, DateTime fecfin);

        //va
        [OperationContract]
        List<VisitaBE> GetAllVisitaPreso(String strDNI);


    }

    //clase visitaBE
    [DataContract]
    [Serializable]
    public class VisitaBE
    {
        private String _motVisita;
        private System.DateTime _fecVisita;

        private String _nomVisitante;
        private String _apeVisitante;
        private String _dniVisitante;

        private String _disVisitante;
        private String _dirVisitante;


        private String _nomPreso;
        private String _apePreso;
        private String _dniPreso;


        [DataMember]
        public System.DateTime fecVisita
        {
            get { return this._fecVisita; }
            set { this._fecVisita = value; }
        }


        [DataMember]
        public String motVisita
        {
            get { return this._motVisita; }
            set { this._motVisita = value; }
        }



        [DataMember]
        public String nomVisitante
        {
            get { return this._nomVisitante; }
            set { this._nomVisitante = value; }
        }
        [DataMember]
        public String apeVisitante
        {
            get { return this._apeVisitante; }
            set { this._apeVisitante = value; }
        }
        [DataMember]
        public String dniVisitante
        {
            get { return this._dniVisitante; }
            set { this._dniVisitante = value; }
        }

        [DataMember]
        public String disVisitante
        {
            get { return this._disVisitante; }
            set { this._disVisitante = value; }
        }
        [DataMember]
        public String dirVisitante
        {
            get { return this._dirVisitante; }
            set { this._dirVisitante = value; }
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
        public String dniPreso
        {
            get { return this._dniPreso; }
            set { this._dniPreso = value; }
        }


    }


}
