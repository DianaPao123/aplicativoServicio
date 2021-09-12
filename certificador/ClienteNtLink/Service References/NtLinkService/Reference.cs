﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteNtLink.NtLinkService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://ntlink.com.mx/ICertificador", ConfigurationName="NtLinkService.ICertificador")]
    internal interface ICertificador {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ntlink.com.mx/ICertificador/ICertificador/TimbraCfdi", ReplyAction="https://ntlink.com.mx/ICertificador/ICertificador/TimbraCfdiResponse")]
        string TimbraCfdi(string comprobante);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ntlink.com.mx/ICertificador/ICertificador/CancelaCfdi", ReplyAction="https://ntlink.com.mx/ICertificador/ICertificador/CancelaCfdiResponse")]
        string CancelaCfdi(string uuid, string rfc);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface ICertificadorChannel : ClienteNtLink.NtLinkService.ICertificador, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class CertificadorClient : System.ServiceModel.ClientBase<ClienteNtLink.NtLinkService.ICertificador>, ClienteNtLink.NtLinkService.ICertificador {
        
        public CertificadorClient() {
        }
        
        public CertificadorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CertificadorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CertificadorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CertificadorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string TimbraCfdi(string comprobante) {
            return base.Channel.TimbraCfdi(comprobante);
        }
        
        public string CancelaCfdi(string uuid, string rfc) {
            return base.Channel.CancelaCfdi(uuid, rfc);
        }
    }
}
