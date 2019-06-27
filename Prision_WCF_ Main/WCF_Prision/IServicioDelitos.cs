using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Prision
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioDelitos" in both code and config file together.
    [ServiceContract]
    public interface IServicioDelitos
    {
        [OperationContract]
        void DoWork();
      


    }

    //DELITOS
    [DataContract]
    [Serializable]
    public class DelitoBE
    {
        private String _nomDelito;
        private String _participacion;


        [DataMember]
        public String nomDelito
        {
            get { return this._nomDelito; }
            set { this._nomDelito = value; }
        }
        [DataMember]
        public String participacion
        {
            get { return this._participacion; }
            set { this._participacion = value; }
        }
    }

}
