﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumirServiciosProyecto_WS.ProxyIngreso {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IngresoBE", Namespace="http://schemas.datacontract.org/2004/07/WCF_Prision")]
    [System.SerializableAttribute()]
    public partial class IngresoBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apePresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float codCeldaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.DelitoBE> delitosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string disPresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dniPresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string estadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fecIngresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fecSalidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.InscripcionBE> inscripcionesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomPresoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string apePreso {
            get {
                return this.apePresoField;
            }
            set {
                if ((object.ReferenceEquals(this.apePresoField, value) != true)) {
                    this.apePresoField = value;
                    this.RaisePropertyChanged("apePreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float codCelda {
            get {
                return this.codCeldaField;
            }
            set {
                if ((this.codCeldaField.Equals(value) != true)) {
                    this.codCeldaField = value;
                    this.RaisePropertyChanged("codCelda");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.DelitoBE> delitos {
            get {
                return this.delitosField;
            }
            set {
                if ((object.ReferenceEquals(this.delitosField, value) != true)) {
                    this.delitosField = value;
                    this.RaisePropertyChanged("delitos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string disPreso {
            get {
                return this.disPresoField;
            }
            set {
                if ((object.ReferenceEquals(this.disPresoField, value) != true)) {
                    this.disPresoField = value;
                    this.RaisePropertyChanged("disPreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dniPreso {
            get {
                return this.dniPresoField;
            }
            set {
                if ((object.ReferenceEquals(this.dniPresoField, value) != true)) {
                    this.dniPresoField = value;
                    this.RaisePropertyChanged("dniPreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                if ((object.ReferenceEquals(this.estadoField, value) != true)) {
                    this.estadoField = value;
                    this.RaisePropertyChanged("estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecIngreso {
            get {
                return this.fecIngresoField;
            }
            set {
                if ((this.fecIngresoField.Equals(value) != true)) {
                    this.fecIngresoField = value;
                    this.RaisePropertyChanged("fecIngreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecSalida {
            get {
                return this.fecSalidaField;
            }
            set {
                if ((this.fecSalidaField.Equals(value) != true)) {
                    this.fecSalidaField = value;
                    this.RaisePropertyChanged("fecSalida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.InscripcionBE> inscripciones {
            get {
                return this.inscripcionesField;
            }
            set {
                if ((object.ReferenceEquals(this.inscripcionesField, value) != true)) {
                    this.inscripcionesField = value;
                    this.RaisePropertyChanged("inscripciones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nomPreso {
            get {
                return this.nomPresoField;
            }
            set {
                if ((object.ReferenceEquals(this.nomPresoField, value) != true)) {
                    this.nomPresoField = value;
                    this.RaisePropertyChanged("nomPreso");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DelitoBE", Namespace="http://schemas.datacontract.org/2004/07/WCF_Prision")]
    [System.SerializableAttribute()]
    public partial class DelitoBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomDelitoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string participacionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nomDelito {
            get {
                return this.nomDelitoField;
            }
            set {
                if ((object.ReferenceEquals(this.nomDelitoField, value) != true)) {
                    this.nomDelitoField = value;
                    this.RaisePropertyChanged("nomDelito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string participacion {
            get {
                return this.participacionField;
            }
            set {
                if ((object.ReferenceEquals(this.participacionField, value) != true)) {
                    this.participacionField = value;
                    this.RaisePropertyChanged("participacion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InscripcionBE", Namespace="http://schemas.datacontract.org/2004/07/WCF_Prision")]
    [System.SerializableAttribute()]
    public partial class InscripcionBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apePresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string desProgramaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fecFinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fecIniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomPresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomProgramaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string apePreso {
            get {
                return this.apePresoField;
            }
            set {
                if ((object.ReferenceEquals(this.apePresoField, value) != true)) {
                    this.apePresoField = value;
                    this.RaisePropertyChanged("apePreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string desPrograma {
            get {
                return this.desProgramaField;
            }
            set {
                if ((object.ReferenceEquals(this.desProgramaField, value) != true)) {
                    this.desProgramaField = value;
                    this.RaisePropertyChanged("desPrograma");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecFin {
            get {
                return this.fecFinField;
            }
            set {
                if ((this.fecFinField.Equals(value) != true)) {
                    this.fecFinField = value;
                    this.RaisePropertyChanged("fecFin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecIni {
            get {
                return this.fecIniField;
            }
            set {
                if ((this.fecIniField.Equals(value) != true)) {
                    this.fecIniField = value;
                    this.RaisePropertyChanged("fecIni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nomPreso {
            get {
                return this.nomPresoField;
            }
            set {
                if ((object.ReferenceEquals(this.nomPresoField, value) != true)) {
                    this.nomPresoField = value;
                    this.RaisePropertyChanged("nomPreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nomPrograma {
            get {
                return this.nomProgramaField;
            }
            set {
                if ((object.ReferenceEquals(this.nomProgramaField, value) != true)) {
                    this.nomProgramaField = value;
                    this.RaisePropertyChanged("nomPrograma");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyIngreso.IServicioIngreso")]
    public interface IServicioIngreso {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/DoWork", ReplyAction="http://tempuri.org/IServicioIngreso/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/DoWork", ReplyAction="http://tempuri.org/IServicioIngreso/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetAllIngreso", ReplyAction="http://tempuri.org/IServicioIngreso/GetAllIngresoResponse")]
        System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE> GetAllIngreso();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetAllIngreso", ReplyAction="http://tempuri.org/IServicioIngreso/GetAllIngresoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE>> GetAllIngresoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetIngresosPreso", ReplyAction="http://tempuri.org/IServicioIngreso/GetIngresosPresoResponse")]
        System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE> GetIngresosPreso(string strDNI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetIngresosPreso", ReplyAction="http://tempuri.org/IServicioIngreso/GetIngresosPresoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE>> GetIngresosPresoAsync(string strDNI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetIngresoFechas", ReplyAction="http://tempuri.org/IServicioIngreso/GetIngresoFechasResponse")]
        System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE> GetIngresoFechas(System.DateTime fecIni, System.DateTime fecFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetIngresoFechas", ReplyAction="http://tempuri.org/IServicioIngreso/GetIngresoFechasResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE>> GetIngresoFechasAsync(System.DateTime fecIni, System.DateTime fecFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetAllPresoPorSalirFechas", ReplyAction="http://tempuri.org/IServicioIngreso/GetAllPresoPorSalirFechasResponse")]
        System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE> GetAllPresoPorSalirFechas(System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetAllPresoPorSalirFechas", ReplyAction="http://tempuri.org/IServicioIngreso/GetAllPresoPorSalirFechasResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE>> GetAllPresoPorSalirFechasAsync(System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetAllDelitosDNI", ReplyAction="http://tempuri.org/IServicioIngreso/GetAllDelitosDNIResponse")]
        System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.DelitoBE> GetAllDelitosDNI(string strDNI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetAllDelitosDNI", ReplyAction="http://tempuri.org/IServicioIngreso/GetAllDelitosDNIResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.DelitoBE>> GetAllDelitosDNIAsync(string strDNI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetAllDelitosDNIFechas", ReplyAction="http://tempuri.org/IServicioIngreso/GetAllDelitosDNIFechasResponse")]
        System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.DelitoBE> GetAllDelitosDNIFechas(string strDNI, System.DateTime fecIni, System.DateTime fecFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioIngreso/GetAllDelitosDNIFechas", ReplyAction="http://tempuri.org/IServicioIngreso/GetAllDelitosDNIFechasResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.DelitoBE>> GetAllDelitosDNIFechasAsync(string strDNI, System.DateTime fecIni, System.DateTime fecFin);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioIngresoChannel : ConsumirServiciosProyecto_WS.ProxyIngreso.IServicioIngreso, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioIngresoClient : System.ServiceModel.ClientBase<ConsumirServiciosProyecto_WS.ProxyIngreso.IServicioIngreso>, ConsumirServiciosProyecto_WS.ProxyIngreso.IServicioIngreso {
        
        public ServicioIngresoClient() {
        }
        
        public ServicioIngresoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioIngresoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioIngresoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioIngresoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE> GetAllIngreso() {
            return base.Channel.GetAllIngreso();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE>> GetAllIngresoAsync() {
            return base.Channel.GetAllIngresoAsync();
        }
        
        public System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE> GetIngresosPreso(string strDNI) {
            return base.Channel.GetIngresosPreso(strDNI);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE>> GetIngresosPresoAsync(string strDNI) {
            return base.Channel.GetIngresosPresoAsync(strDNI);
        }
        
        public System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE> GetIngresoFechas(System.DateTime fecIni, System.DateTime fecFin) {
            return base.Channel.GetIngresoFechas(fecIni, fecFin);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE>> GetIngresoFechasAsync(System.DateTime fecIni, System.DateTime fecFin) {
            return base.Channel.GetIngresoFechasAsync(fecIni, fecFin);
        }
        
        public System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE> GetAllPresoPorSalirFechas(System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.GetAllPresoPorSalirFechas(fecini, fecfin);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.IngresoBE>> GetAllPresoPorSalirFechasAsync(System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.GetAllPresoPorSalirFechasAsync(fecini, fecfin);
        }
        
        public System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.DelitoBE> GetAllDelitosDNI(string strDNI) {
            return base.Channel.GetAllDelitosDNI(strDNI);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.DelitoBE>> GetAllDelitosDNIAsync(string strDNI) {
            return base.Channel.GetAllDelitosDNIAsync(strDNI);
        }
        
        public System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.DelitoBE> GetAllDelitosDNIFechas(string strDNI, System.DateTime fecIni, System.DateTime fecFin) {
            return base.Channel.GetAllDelitosDNIFechas(strDNI, fecIni, fecFin);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ConsumirServiciosProyecto_WS.ProxyIngreso.DelitoBE>> GetAllDelitosDNIFechasAsync(string strDNI, System.DateTime fecIni, System.DateTime fecFin) {
            return base.Channel.GetAllDelitosDNIFechasAsync(strDNI, fecIni, fecFin);
        }
    }
}
