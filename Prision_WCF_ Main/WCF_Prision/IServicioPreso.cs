using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Prision
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioPreso" in both code and config file together.
    [ServiceContract]
    public interface IServicioPreso
    {
        [OperationContract]
        void DoWork();

        

    }

    [DataContract]
    [Serializable]
    public class PresoBE
    {   //declarar coomo privado las propiedades 

        private String _nomPreso;
        private String _apePreso;
        private String _dniPreso;
        private System.DateTime _fecNacPreso;
        private String _disPreso;
        private String _dirPreso;

        //cada propiedad  data member

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
        [DataMember]
        public System.DateTime fecNacPreso
        {
            get { return this._fecNacPreso; }
            set { this._fecNacPreso = value; }
        }
        [DataMember]
        public String disPreso
        {
            get { return this._disPreso; }
            set { this._disPreso = value; }
        }
        [DataMember]
        public String dirPreso
        {
            get { return this._dirPreso; }
            set { this._dirPreso = value; }
        }

    }
}
