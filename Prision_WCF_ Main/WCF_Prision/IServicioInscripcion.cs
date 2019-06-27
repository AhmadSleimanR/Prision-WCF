using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Prision
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioInscripcion" in both code and config file together.
    [ServiceContract]
    public interface IServicioInscripcion
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<InscripcionBE> GetAllInscripcion(); //listar

        [OperationContract]
        List<InscripcionBE> GetAllInscripcionFechas(DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<InscripcionBE> GetAllInscripcionPreso(String strDNI);
    }


    [DataContract]
    [Serializable]
    public class InscripcionBE
    {   //declarar coomo privado las propiedades 

        private String _nomPreso;
        private String _apePreso;
        private String _nomPrograma;
        private String _desPrograma;
        private System.DateTime _fechaIni;
        private System.DateTime _fechaFin;

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
        public String nomPrograma
        {
            get { return this._nomPrograma; }
            set { this._nomPrograma = value; }
        }

        [DataMember]
        public String desPrograma
        {
            get { return this._desPrograma; }
            set { this._desPrograma = value; }
        }

        [DataMember]
        public DateTime fecIni
        {
            get { return this._fechaIni; }
            set { this._fechaIni = value; }
        }

        [DataMember]
        public DateTime fecFin
        {
            get { return this._fechaFin; }
            set { this._fechaFin = value; }
        }




    }

}
