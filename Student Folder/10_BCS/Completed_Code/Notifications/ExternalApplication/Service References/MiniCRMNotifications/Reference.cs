﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExternalApplication.MiniCRMNotifications {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MiniCRMNotifications.INotificationEndpoint")]
    public interface INotificationEndpoint {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotificationEndpoint/Notify", ReplyAction="http://tempuri.org/INotificationEndpoint/NotifyResponse")]
        void Notify(string EventType, string Details);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotificationEndpoint/Notify", ReplyAction="http://tempuri.org/INotificationEndpoint/NotifyResponse")]
        System.Threading.Tasks.Task NotifyAsync(string EventType, string Details);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INotificationEndpointChannel : ExternalApplication.MiniCRMNotifications.INotificationEndpoint, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NotificationEndpointClient : System.ServiceModel.ClientBase<ExternalApplication.MiniCRMNotifications.INotificationEndpoint>, ExternalApplication.MiniCRMNotifications.INotificationEndpoint {
        
        public NotificationEndpointClient() {
        }
        
        public NotificationEndpointClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NotificationEndpointClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotificationEndpointClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotificationEndpointClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Notify(string EventType, string Details) {
            base.Channel.Notify(EventType, Details);
        }
        
        public System.Threading.Tasks.Task NotifyAsync(string EventType, string Details) {
            return base.Channel.NotifyAsync(EventType, Details);
        }
    }
}
