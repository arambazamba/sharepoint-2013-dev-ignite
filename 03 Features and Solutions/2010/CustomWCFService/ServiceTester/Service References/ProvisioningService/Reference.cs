﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceTester.ProvisioningService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProvisioningService.ISiteProvisioningService")]
    public interface ISiteProvisioningService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteProvisioningService/CreatSite", ReplyAction="http://tempuri.org/ISiteProvisioningService/CreatSiteResponse")]
        string CreatSite(string Param);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISiteProvisioningServiceChannel : ServiceTester.ProvisioningService.ISiteProvisioningService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SiteProvisioningServiceClient : System.ServiceModel.ClientBase<ServiceTester.ProvisioningService.ISiteProvisioningService>, ServiceTester.ProvisioningService.ISiteProvisioningService {
        
        public SiteProvisioningServiceClient() {
        }
        
        public SiteProvisioningServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SiteProvisioningServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SiteProvisioningServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SiteProvisioningServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CreatSite(string Param) {
            return base.Channel.CreatSite(Param);
        }
    }
}
