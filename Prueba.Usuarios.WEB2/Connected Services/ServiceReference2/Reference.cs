﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba.Usuarios.WEB2.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuarios", Namespace="http://schemas.datacontract.org/2004/07/Prueba.Usuarios.Dominio")]
    [System.SerializableAttribute()]
    public partial class Usuarios : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
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
        public System.DateTime FechaNacimiento {
            get {
                return this.FechaNacimientoField;
            }
            set {
                if ((this.FechaNacimientoField.Equals(value) != true)) {
                    this.FechaNacimientoField = value;
                    this.RaisePropertyChanged("FechaNacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdUsuario {
            get {
                return this.IdUsuarioField;
            }
            set {
                if ((this.IdUsuarioField.Equals(value) != true)) {
                    this.IdUsuarioField = value;
                    this.RaisePropertyChanged("IdUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Error", Namespace="http://schemas.datacontract.org/2004/07/Prueba.Usuarios.Dominio")]
    [System.SerializableAttribute()]
    public partial class Error : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codigoErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mensajeErrorField;
        
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
        public string codigoError {
            get {
                return this.codigoErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.codigoErrorField, value) != true)) {
                    this.codigoErrorField = value;
                    this.RaisePropertyChanged("codigoError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descripcionError {
            get {
                return this.descripcionErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionErrorField, value) != true)) {
                    this.descripcionErrorField = value;
                    this.RaisePropertyChanged("descripcionError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mensajeError {
            get {
                return this.mensajeErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.mensajeErrorField, value) != true)) {
                    this.mensajeErrorField = value;
                    this.RaisePropertyChanged("mensajeError");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IUsuarioService")]
    public interface IUsuarioService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ObtenerUsuario", ReplyAction="http://tempuri.org/IUsuarioService/ObtenerUsuarioResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Prueba.Usuarios.WEB2.ServiceReference2.Error), Action="http://tempuri.org/IUsuarioService/ObtenerUsuarioErrorFault", Name="Error", Namespace="http://schemas.datacontract.org/2004/07/Prueba.Usuarios.Dominio")]
        Prueba.Usuarios.WEB2.ServiceReference2.Usuarios ObtenerUsuario(int IdUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ObtenerUsuario", ReplyAction="http://tempuri.org/IUsuarioService/ObtenerUsuarioResponse")]
        System.Threading.Tasks.Task<Prueba.Usuarios.WEB2.ServiceReference2.Usuarios> ObtenerUsuarioAsync(int IdUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ListarUsuarios", ReplyAction="http://tempuri.org/IUsuarioService/ListarUsuariosResponse")]
        Prueba.Usuarios.WEB2.ServiceReference2.Usuarios[] ListarUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ListarUsuarios", ReplyAction="http://tempuri.org/IUsuarioService/ListarUsuariosResponse")]
        System.Threading.Tasks.Task<Prueba.Usuarios.WEB2.ServiceReference2.Usuarios[]> ListarUsuariosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioServiceChannel : Prueba.Usuarios.WEB2.ServiceReference2.IUsuarioService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioServiceClient : System.ServiceModel.ClientBase<Prueba.Usuarios.WEB2.ServiceReference2.IUsuarioService>, Prueba.Usuarios.WEB2.ServiceReference2.IUsuarioService {
        
        public UsuarioServiceClient() {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Prueba.Usuarios.WEB2.ServiceReference2.Usuarios ObtenerUsuario(int IdUsuario) {
            return base.Channel.ObtenerUsuario(IdUsuario);
        }
        
        public System.Threading.Tasks.Task<Prueba.Usuarios.WEB2.ServiceReference2.Usuarios> ObtenerUsuarioAsync(int IdUsuario) {
            return base.Channel.ObtenerUsuarioAsync(IdUsuario);
        }
        
        public Prueba.Usuarios.WEB2.ServiceReference2.Usuarios[] ListarUsuarios() {
            return base.Channel.ListarUsuarios();
        }
        
        public System.Threading.Tasks.Task<Prueba.Usuarios.WEB2.ServiceReference2.Usuarios[]> ListarUsuariosAsync() {
            return base.Channel.ListarUsuariosAsync();
        }
    }
}