﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18449
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JAJ.WinForm.FileTransferSvc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FileTransferSvc.IFileService")]
    public interface IFileService {
        
        // CODEGEN: 消息 TransferFileData 的包装名称(TransferFileData)以后生成的消息协定与默认值(UploadFile)不匹配
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IFileService/UploadFile")]
        void UploadFile(JAJ.WinForm.FileTransferSvc.TransferFileData request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/IFileService/UploadFile")]
        System.IAsyncResult BeginUploadFile(JAJ.WinForm.FileTransferSvc.TransferFileData request, System.AsyncCallback callback, object asyncState);
        
        void EndUploadFile(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetUploadFileInfo", ReplyAction="http://tempuri.org/IFileService/GetUploadFileInfoResponse")]
        long GetUploadFileInfo(string id);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IFileService/GetUploadFileInfo", ReplyAction="http://tempuri.org/IFileService/GetUploadFileInfoResponse")]
        System.IAsyncResult BeginGetUploadFileInfo(string id, System.AsyncCallback callback, object asyncState);
        
        long EndGetUploadFileInfo(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/DowndloadFile", ReplyAction="http://tempuri.org/IFileService/DowndloadFileResponse")]
        System.IO.Stream DowndloadFile(string filePath);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IFileService/DowndloadFile", ReplyAction="http://tempuri.org/IFileService/DowndloadFileResponse")]
        System.IAsyncResult BeginDowndloadFile(string filePath, System.AsyncCallback callback, object asyncState);
        
        System.IO.Stream EndDowndloadFile(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TransferFileData", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class TransferFileData {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long FileSize;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileType;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileUniqueID;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string oldFileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream FileData;
        
        public TransferFileData() {
        }
        
        public TransferFileData(string FileName, long FileSize, string FileType, string FileUniqueID, string oldFileName, System.IO.Stream FileData) {
            this.FileName = FileName;
            this.FileSize = FileSize;
            this.FileType = FileType;
            this.FileUniqueID = FileUniqueID;
            this.oldFileName = oldFileName;
            this.FileData = FileData;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileServiceChannel : JAJ.WinForm.FileTransferSvc.IFileService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetUploadFileInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetUploadFileInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public long Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DowndloadFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DowndloadFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.IO.Stream Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.IO.Stream)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileServiceClient : System.ServiceModel.ClientBase<JAJ.WinForm.FileTransferSvc.IFileService>, JAJ.WinForm.FileTransferSvc.IFileService {
        
        private BeginOperationDelegate onBeginUploadFileDelegate;
        
        private EndOperationDelegate onEndUploadFileDelegate;
        
        private System.Threading.SendOrPostCallback onUploadFileCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetUploadFileInfoDelegate;
        
        private EndOperationDelegate onEndGetUploadFileInfoDelegate;
        
        private System.Threading.SendOrPostCallback onGetUploadFileInfoCompletedDelegate;
        
        private BeginOperationDelegate onBeginDowndloadFileDelegate;
        
        private EndOperationDelegate onEndDowndloadFileDelegate;
        
        private System.Threading.SendOrPostCallback onDowndloadFileCompletedDelegate;
        
        public FileServiceClient() {
        }
        
        public FileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> UploadFileCompleted;
        
        public event System.EventHandler<GetUploadFileInfoCompletedEventArgs> GetUploadFileInfoCompleted;
        
        public event System.EventHandler<DowndloadFileCompletedEventArgs> DowndloadFileCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void JAJ.WinForm.FileTransferSvc.IFileService.UploadFile(JAJ.WinForm.FileTransferSvc.TransferFileData request) {
            base.Channel.UploadFile(request);
        }
        
        public void UploadFile(string FileName, long FileSize, string FileType, string FileUniqueID, string oldFileName, System.IO.Stream FileData) {
            JAJ.WinForm.FileTransferSvc.TransferFileData inValue = new JAJ.WinForm.FileTransferSvc.TransferFileData();
            inValue.FileName = FileName;
            inValue.FileSize = FileSize;
            inValue.FileType = FileType;
            inValue.FileUniqueID = FileUniqueID;
            inValue.oldFileName = oldFileName;
            inValue.FileData = FileData;
            ((JAJ.WinForm.FileTransferSvc.IFileService)(this)).UploadFile(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult JAJ.WinForm.FileTransferSvc.IFileService.BeginUploadFile(JAJ.WinForm.FileTransferSvc.TransferFileData request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUploadFile(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginUploadFile(string FileName, long FileSize, string FileType, string FileUniqueID, string oldFileName, System.IO.Stream FileData, System.AsyncCallback callback, object asyncState) {
            JAJ.WinForm.FileTransferSvc.TransferFileData inValue = new JAJ.WinForm.FileTransferSvc.TransferFileData();
            inValue.FileName = FileName;
            inValue.FileSize = FileSize;
            inValue.FileType = FileType;
            inValue.FileUniqueID = FileUniqueID;
            inValue.oldFileName = oldFileName;
            inValue.FileData = FileData;
            return ((JAJ.WinForm.FileTransferSvc.IFileService)(this)).BeginUploadFile(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndUploadFile(System.IAsyncResult result) {
            base.Channel.EndUploadFile(result);
        }
        
        private System.IAsyncResult OnBeginUploadFile(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string FileName = ((string)(inValues[0]));
            long FileSize = ((long)(inValues[1]));
            string FileType = ((string)(inValues[2]));
            string FileUniqueID = ((string)(inValues[3]));
            string oldFileName = ((string)(inValues[4]));
            System.IO.Stream FileData = ((System.IO.Stream)(inValues[5]));
            return this.BeginUploadFile(FileName, FileSize, FileType, FileUniqueID, oldFileName, FileData, callback, asyncState);
        }
        
        private object[] OnEndUploadFile(System.IAsyncResult result) {
            this.EndUploadFile(result);
            return null;
        }
        
        private void OnUploadFileCompleted(object state) {
            if ((this.UploadFileCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UploadFileCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UploadFileAsync(string FileName, long FileSize, string FileType, string FileUniqueID, string oldFileName, System.IO.Stream FileData) {
            this.UploadFileAsync(FileName, FileSize, FileType, FileUniqueID, oldFileName, FileData, null);
        }
        
        public void UploadFileAsync(string FileName, long FileSize, string FileType, string FileUniqueID, string oldFileName, System.IO.Stream FileData, object userState) {
            if ((this.onBeginUploadFileDelegate == null)) {
                this.onBeginUploadFileDelegate = new BeginOperationDelegate(this.OnBeginUploadFile);
            }
            if ((this.onEndUploadFileDelegate == null)) {
                this.onEndUploadFileDelegate = new EndOperationDelegate(this.OnEndUploadFile);
            }
            if ((this.onUploadFileCompletedDelegate == null)) {
                this.onUploadFileCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUploadFileCompleted);
            }
            base.InvokeAsync(this.onBeginUploadFileDelegate, new object[] {
                        FileName,
                        FileSize,
                        FileType,
                        FileUniqueID,
                        oldFileName,
                        FileData}, this.onEndUploadFileDelegate, this.onUploadFileCompletedDelegate, userState);
        }
        
        public long GetUploadFileInfo(string id) {
            return base.Channel.GetUploadFileInfo(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetUploadFileInfo(string id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetUploadFileInfo(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public long EndGetUploadFileInfo(System.IAsyncResult result) {
            return base.Channel.EndGetUploadFileInfo(result);
        }
        
        private System.IAsyncResult OnBeginGetUploadFileInfo(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string id = ((string)(inValues[0]));
            return this.BeginGetUploadFileInfo(id, callback, asyncState);
        }
        
        private object[] OnEndGetUploadFileInfo(System.IAsyncResult result) {
            long retVal = this.EndGetUploadFileInfo(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetUploadFileInfoCompleted(object state) {
            if ((this.GetUploadFileInfoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetUploadFileInfoCompleted(this, new GetUploadFileInfoCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetUploadFileInfoAsync(string id) {
            this.GetUploadFileInfoAsync(id, null);
        }
        
        public void GetUploadFileInfoAsync(string id, object userState) {
            if ((this.onBeginGetUploadFileInfoDelegate == null)) {
                this.onBeginGetUploadFileInfoDelegate = new BeginOperationDelegate(this.OnBeginGetUploadFileInfo);
            }
            if ((this.onEndGetUploadFileInfoDelegate == null)) {
                this.onEndGetUploadFileInfoDelegate = new EndOperationDelegate(this.OnEndGetUploadFileInfo);
            }
            if ((this.onGetUploadFileInfoCompletedDelegate == null)) {
                this.onGetUploadFileInfoCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetUploadFileInfoCompleted);
            }
            base.InvokeAsync(this.onBeginGetUploadFileInfoDelegate, new object[] {
                        id}, this.onEndGetUploadFileInfoDelegate, this.onGetUploadFileInfoCompletedDelegate, userState);
        }
        
        public System.IO.Stream DowndloadFile(string filePath) {
            return base.Channel.DowndloadFile(filePath);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDowndloadFile(string filePath, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDowndloadFile(filePath, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IO.Stream EndDowndloadFile(System.IAsyncResult result) {
            return base.Channel.EndDowndloadFile(result);
        }
        
        private System.IAsyncResult OnBeginDowndloadFile(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string filePath = ((string)(inValues[0]));
            return this.BeginDowndloadFile(filePath, callback, asyncState);
        }
        
        private object[] OnEndDowndloadFile(System.IAsyncResult result) {
            System.IO.Stream retVal = this.EndDowndloadFile(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDowndloadFileCompleted(object state) {
            if ((this.DowndloadFileCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DowndloadFileCompleted(this, new DowndloadFileCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DowndloadFileAsync(string filePath) {
            this.DowndloadFileAsync(filePath, null);
        }
        
        public void DowndloadFileAsync(string filePath, object userState) {
            if ((this.onBeginDowndloadFileDelegate == null)) {
                this.onBeginDowndloadFileDelegate = new BeginOperationDelegate(this.OnBeginDowndloadFile);
            }
            if ((this.onEndDowndloadFileDelegate == null)) {
                this.onEndDowndloadFileDelegate = new EndOperationDelegate(this.OnEndDowndloadFile);
            }
            if ((this.onDowndloadFileCompletedDelegate == null)) {
                this.onDowndloadFileCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDowndloadFileCompleted);
            }
            base.InvokeAsync(this.onBeginDowndloadFileDelegate, new object[] {
                        filePath}, this.onEndDowndloadFileDelegate, this.onDowndloadFileCompletedDelegate, userState);
        }
    }
}
