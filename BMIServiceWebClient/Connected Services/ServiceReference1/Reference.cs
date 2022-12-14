//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMIServiceWebClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BMI", Namespace="http://schemas.datacontract.org/2004/07/BMIServiceSOAP")]
    [System.SerializableAttribute()]
    public partial class BMI : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double bmiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] moreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string riskField;
        
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
        public double bmi {
            get {
                return this.bmiField;
            }
            set {
                if ((this.bmiField.Equals(value) != true)) {
                    this.bmiField = value;
                    this.RaisePropertyChanged("bmi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] more {
            get {
                return this.moreField;
            }
            set {
                if ((object.ReferenceEquals(this.moreField, value) != true)) {
                    this.moreField = value;
                    this.RaisePropertyChanged("more");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string risk {
            get {
                return this.riskField;
            }
            set {
                if ((object.ReferenceEquals(this.riskField, value) != true)) {
                    this.riskField = value;
                    this.RaisePropertyChanged("risk");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBMIService")]
    public interface IBMIService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBMIService/myBMI", ReplyAction="http://tempuri.org/IBMIService/myBMIResponse")]
        double myBMI(int height, int weight);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBMIService/myBMI", ReplyAction="http://tempuri.org/IBMIService/myBMIResponse")]
        System.Threading.Tasks.Task<double> myBMIAsync(int height, int weight);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBMIService/myHealth", ReplyAction="http://tempuri.org/IBMIService/myHealthResponse")]
        BMIServiceWebClient.ServiceReference1.BMI myHealth(int height, int weight);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBMIService/myHealth", ReplyAction="http://tempuri.org/IBMIService/myHealthResponse")]
        System.Threading.Tasks.Task<BMIServiceWebClient.ServiceReference1.BMI> myHealthAsync(int height, int weight);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBMIServiceChannel : BMIServiceWebClient.ServiceReference1.IBMIService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BMIServiceClient : System.ServiceModel.ClientBase<BMIServiceWebClient.ServiceReference1.IBMIService>, BMIServiceWebClient.ServiceReference1.IBMIService {
        
        public BMIServiceClient() {
        }
        
        public BMIServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BMIServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BMIServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BMIServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double myBMI(int height, int weight) {
            return base.Channel.myBMI(height, weight);
        }
        
        public System.Threading.Tasks.Task<double> myBMIAsync(int height, int weight) {
            return base.Channel.myBMIAsync(height, weight);
        }
        
        public BMIServiceWebClient.ServiceReference1.BMI myHealth(int height, int weight) {
            return base.Channel.myHealth(height, weight);
        }
        
        public System.Threading.Tasks.Task<BMIServiceWebClient.ServiceReference1.BMI> myHealthAsync(int height, int weight) {
            return base.Channel.myHealthAsync(height, weight);
        }
    }
}
