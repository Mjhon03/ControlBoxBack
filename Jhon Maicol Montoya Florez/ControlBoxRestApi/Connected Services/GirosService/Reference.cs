﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GirosService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="giro", Namespace="http://schemas.datacontract.org/2004/07/ControlBoxWCF.Models.Entities")]
    public partial class giro : object
    {
        
        private int _gir_giro_idField;
        
        private int _gir_oficina_idField;
        
        private int _gir_reciboField;
        
        private string _oficinasField;
        
        private int _suma_giro_idField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _gir_giro_id
        {
            get
            {
                return this._gir_giro_idField;
            }
            set
            {
                this._gir_giro_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _gir_oficina_id
        {
            get
            {
                return this._gir_oficina_idField;
            }
            set
            {
                this._gir_oficina_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _gir_recibo
        {
            get
            {
                return this._gir_reciboField;
            }
            set
            {
                this._gir_reciboField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _oficinas
        {
            get
            {
                return this._oficinasField;
            }
            set
            {
                this._oficinasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _suma_giro_id
        {
            get
            {
                return this._suma_giro_idField;
            }
            set
            {
                this._suma_giro_idField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GirosService.IGiros")]
    public interface IGiros
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiros/GetDataGiros", ReplyAction="http://tempuri.org/IGiros/GetDataGirosResponse")]
        GirosService.giro[] GetDataGiros(GirosService.giro gir);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiros/GetDataGiros", ReplyAction="http://tempuri.org/IGiros/GetDataGirosResponse")]
        System.Threading.Tasks.Task<GirosService.giro[]> GetDataGirosAsync(GirosService.giro gir);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiros/AddDataGiros", ReplyAction="http://tempuri.org/IGiros/AddDataGirosResponse")]
        string AddDataGiros(GirosService.giro gir);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiros/AddDataGiros", ReplyAction="http://tempuri.org/IGiros/AddDataGirosResponse")]
        System.Threading.Tasks.Task<string> AddDataGirosAsync(GirosService.giro gir);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiros/UpdateDataGiros", ReplyAction="http://tempuri.org/IGiros/UpdateDataGirosResponse")]
        string UpdateDataGiros(GirosService.giro gir);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiros/UpdateDataGiros", ReplyAction="http://tempuri.org/IGiros/UpdateDataGirosResponse")]
        System.Threading.Tasks.Task<string> UpdateDataGirosAsync(GirosService.giro gir);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiros/DeleteGiros", ReplyAction="http://tempuri.org/IGiros/DeleteGirosResponse")]
        string DeleteGiros(GirosService.giro gir);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiros/DeleteGiros", ReplyAction="http://tempuri.org/IGiros/DeleteGirosResponse")]
        System.Threading.Tasks.Task<string> DeleteGirosAsync(GirosService.giro gir);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IGirosChannel : GirosService.IGiros, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class GirosClient : System.ServiceModel.ClientBase<GirosService.IGiros>, GirosService.IGiros
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public GirosClient() : 
                base(GirosClient.GetDefaultBinding(), GirosClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IGiros.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GirosClient(EndpointConfiguration endpointConfiguration) : 
                base(GirosClient.GetBindingForEndpoint(endpointConfiguration), GirosClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GirosClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(GirosClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GirosClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(GirosClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public GirosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public GirosService.giro[] GetDataGiros(GirosService.giro gir)
        {
            return base.Channel.GetDataGiros(gir);
        }
        
        public System.Threading.Tasks.Task<GirosService.giro[]> GetDataGirosAsync(GirosService.giro gir)
        {
            return base.Channel.GetDataGirosAsync(gir);
        }
        
        public string AddDataGiros(GirosService.giro gir)
        {
            return base.Channel.AddDataGiros(gir);
        }
        
        public System.Threading.Tasks.Task<string> AddDataGirosAsync(GirosService.giro gir)
        {
            return base.Channel.AddDataGirosAsync(gir);
        }
        
        public string UpdateDataGiros(GirosService.giro gir)
        {
            return base.Channel.UpdateDataGiros(gir);
        }
        
        public System.Threading.Tasks.Task<string> UpdateDataGirosAsync(GirosService.giro gir)
        {
            return base.Channel.UpdateDataGirosAsync(gir);
        }
        
        public string DeleteGiros(GirosService.giro gir)
        {
            return base.Channel.DeleteGiros(gir);
        }
        
        public System.Threading.Tasks.Task<string> DeleteGirosAsync(GirosService.giro gir)
        {
            return base.Channel.DeleteGirosAsync(gir);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGiros))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IGiros))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:58418/Giros.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return GirosClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IGiros);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return GirosClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IGiros);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IGiros,
        }
    }
}