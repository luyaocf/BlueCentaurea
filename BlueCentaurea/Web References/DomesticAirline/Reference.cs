﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace BlueCentaurea.DomesticAirline {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DomesticAirlineSoap", Namespace="http://WebXml.com.cn/")]
    public partial class DomesticAirline : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getDomesticCityOperationCompleted;
        
        private System.Threading.SendOrPostCallback getDomesticAirlinesTimeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DomesticAirline() {
            this.Url = global::BlueCentaurea.Properties.Settings.Default.BlueCentaurea_DomesticAirline_DomesticAirline;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getDomesticCityCompletedEventHandler getDomesticCityCompleted;
        
        /// <remarks/>
        public event getDomesticAirlinesTimeCompletedEventHandler getDomesticAirlinesTimeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://WebXml.com.cn/getDomesticCity", RequestNamespace="http://WebXml.com.cn/", ResponseNamespace="http://WebXml.com.cn/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getDomesticCity() {
            object[] results = this.Invoke("getDomesticCity", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getDomesticCityAsync() {
            this.getDomesticCityAsync(null);
        }
        
        /// <remarks/>
        public void getDomesticCityAsync(object userState) {
            if ((this.getDomesticCityOperationCompleted == null)) {
                this.getDomesticCityOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDomesticCityOperationCompleted);
            }
            this.InvokeAsync("getDomesticCity", new object[0], this.getDomesticCityOperationCompleted, userState);
        }
        
        private void OngetDomesticCityOperationCompleted(object arg) {
            if ((this.getDomesticCityCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getDomesticCityCompleted(this, new getDomesticCityCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://WebXml.com.cn/getDomesticAirlinesTime", RequestNamespace="http://WebXml.com.cn/", ResponseNamespace="http://WebXml.com.cn/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getDomesticAirlinesTime(string startCity, string lastCity, string theDate, string userID) {
            object[] results = this.Invoke("getDomesticAirlinesTime", new object[] {
                        startCity,
                        lastCity,
                        theDate,
                        userID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getDomesticAirlinesTimeAsync(string startCity, string lastCity, string theDate, string userID) {
            this.getDomesticAirlinesTimeAsync(startCity, lastCity, theDate, userID, null);
        }
        
        /// <remarks/>
        public void getDomesticAirlinesTimeAsync(string startCity, string lastCity, string theDate, string userID, object userState) {
            if ((this.getDomesticAirlinesTimeOperationCompleted == null)) {
                this.getDomesticAirlinesTimeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDomesticAirlinesTimeOperationCompleted);
            }
            this.InvokeAsync("getDomesticAirlinesTime", new object[] {
                        startCity,
                        lastCity,
                        theDate,
                        userID}, this.getDomesticAirlinesTimeOperationCompleted, userState);
        }
        
        private void OngetDomesticAirlinesTimeOperationCompleted(object arg) {
            if ((this.getDomesticAirlinesTimeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getDomesticAirlinesTimeCompleted(this, new getDomesticAirlinesTimeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void getDomesticCityCompletedEventHandler(object sender, getDomesticCityCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getDomesticCityCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getDomesticCityCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void getDomesticAirlinesTimeCompletedEventHandler(object sender, getDomesticAirlinesTimeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getDomesticAirlinesTimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getDomesticAirlinesTimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591