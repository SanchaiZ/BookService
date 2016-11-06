﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStore.BookCRUD {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://follow-me.com/", ConfigurationName="BookCRUD.BookCRUDSoap")]
    public interface BookCRUDSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Load", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object Load(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Load", ReplyAction="*")]
        System.Threading.Tasks.Task<object> LoadAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object Read();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Read", ReplyAction="*")]
        System.Threading.Tasks.Task<object> ReadAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/ReadByID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object ReadByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/ReadByID", ReplyAction="*")]
        System.Threading.Tasks.Task<object> ReadByIDAsync(int ID);
        
        // CODEGEN: Generating message contract since the wrapper name (ABC) of message ABC does not match the default value (Insert)
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/ABC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        BookStore.BookCRUD.ABC1 Insert(BookStore.BookCRUD.ABC request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/ABC", ReplyAction="*")]
        System.Threading.Tasks.Task<BookStore.BookCRUD.ABC1> InsertAsync(BookStore.BookCRUD.ABC request);
        
        // CODEGEN: Generating message contract since the wrapper name (Hi) of message Hi does not match the default value (InsertAll)
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Hi", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        BookStore.BookCRUD.Hi1 InsertAll(BookStore.BookCRUD.Hi request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Hi", ReplyAction="*")]
        System.Threading.Tasks.Task<BookStore.BookCRUD.Hi1> InsertAllAsync(BookStore.BookCRUD.Hi request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Update_Element", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object Update_Element(int ID, string ElementName, string ElementValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Update_Element", ReplyAction="*")]
        System.Threading.Tasks.Task<object> Update_ElementAsync(int ID, string ElementName, string ElementValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object Update(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<object> UpdateAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<object> DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Length", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Length();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Length", ReplyAction="*")]
        System.Threading.Tasks.Task<int> LengthAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Save", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object Save();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Save", ReplyAction="*")]
        System.Threading.Tasks.Task<object> SaveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Search_price", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        object Search_price(string low, string high);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://follow-me.com/Search_price", ReplyAction="*")]
        System.Threading.Tasks.Task<object> Search_priceAsync(string low, string high);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ABC", WrapperNamespace="http://follow-me.com/", IsWrapped=true)]
    public partial class ABC {
        
        public ABC() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ABCResponse", WrapperNamespace="http://follow-me.com/", IsWrapped=true)]
    public partial class ABC1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://follow-me.com/", Order=0)]
        public object ABCResult;
        
        public ABC1() {
        }
        
        public ABC1(object ABCResult) {
            this.ABCResult = ABCResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Hi", WrapperNamespace="http://follow-me.com/", IsWrapped=true)]
    public partial class Hi {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://follow-me.com/", Order=0)]
        public string title;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://follow-me.com/", Order=1)]
        public string price;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://follow-me.com/", Order=2)]
        public string author;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://follow-me.com/", Order=3)]
        public string year;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://follow-me.com/", Order=4)]
        public string category;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://follow-me.com/", Order=5)]
        public string ISBN_10;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://follow-me.com/", Order=6)]
        public string ISBN_13;
        
        public Hi() {
        }
        
        public Hi(string title, string price, string author, string year, string category, string ISBN_10, string ISBN_13) {
            this.title = title;
            this.price = price;
            this.author = author;
            this.year = year;
            this.category = category;
            this.ISBN_10 = ISBN_10;
            this.ISBN_13 = ISBN_13;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HiResponse", WrapperNamespace="http://follow-me.com/", IsWrapped=true)]
    public partial class Hi1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://follow-me.com/", Order=0)]
        public object HiResult;
        
        public Hi1() {
        }
        
        public Hi1(object HiResult) {
            this.HiResult = HiResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BookCRUDSoapChannel : BookStore.BookCRUD.BookCRUDSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookCRUDSoapClient : System.ServiceModel.ClientBase<BookStore.BookCRUD.BookCRUDSoap>, BookStore.BookCRUD.BookCRUDSoap {
        
        public BookCRUDSoapClient() {
        }
        
        public BookCRUDSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookCRUDSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookCRUDSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookCRUDSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public object Load(string path) {
            return base.Channel.Load(path);
        }
        
        public System.Threading.Tasks.Task<object> LoadAsync(string path) {
            return base.Channel.LoadAsync(path);
        }
        
        public object Read() {
            return base.Channel.Read();
        }
        
        public System.Threading.Tasks.Task<object> ReadAsync() {
            return base.Channel.ReadAsync();
        }
        
        public object ReadByID(int ID) {
            return base.Channel.ReadByID(ID);
        }
        
        public System.Threading.Tasks.Task<object> ReadByIDAsync(int ID) {
            return base.Channel.ReadByIDAsync(ID);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BookStore.BookCRUD.ABC1 BookStore.BookCRUD.BookCRUDSoap.Insert(BookStore.BookCRUD.ABC request) {
            return base.Channel.Insert(request);
        }
        
        public object Insert() {
            BookStore.BookCRUD.ABC inValue = new BookStore.BookCRUD.ABC();
            BookStore.BookCRUD.ABC1 retVal = ((BookStore.BookCRUD.BookCRUDSoap)(this)).Insert(inValue);
            return retVal.ABCResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BookStore.BookCRUD.ABC1> BookStore.BookCRUD.BookCRUDSoap.InsertAsync(BookStore.BookCRUD.ABC request) {
            return base.Channel.InsertAsync(request);
        }
        
        public System.Threading.Tasks.Task<BookStore.BookCRUD.ABC1> InsertAsync() {
            BookStore.BookCRUD.ABC inValue = new BookStore.BookCRUD.ABC();
            return ((BookStore.BookCRUD.BookCRUDSoap)(this)).InsertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BookStore.BookCRUD.Hi1 BookStore.BookCRUD.BookCRUDSoap.InsertAll(BookStore.BookCRUD.Hi request) {
            return base.Channel.InsertAll(request);
        }
        
        public object InsertAll(string title, string price, string author, string year, string category, string ISBN_10, string ISBN_13) {
            BookStore.BookCRUD.Hi inValue = new BookStore.BookCRUD.Hi();
            inValue.title = title;
            inValue.price = price;
            inValue.author = author;
            inValue.year = year;
            inValue.category = category;
            inValue.ISBN_10 = ISBN_10;
            inValue.ISBN_13 = ISBN_13;
            BookStore.BookCRUD.Hi1 retVal = ((BookStore.BookCRUD.BookCRUDSoap)(this)).InsertAll(inValue);
            return retVal.HiResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BookStore.BookCRUD.Hi1> BookStore.BookCRUD.BookCRUDSoap.InsertAllAsync(BookStore.BookCRUD.Hi request) {
            return base.Channel.InsertAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<BookStore.BookCRUD.Hi1> InsertAllAsync(string title, string price, string author, string year, string category, string ISBN_10, string ISBN_13) {
            BookStore.BookCRUD.Hi inValue = new BookStore.BookCRUD.Hi();
            inValue.title = title;
            inValue.price = price;
            inValue.author = author;
            inValue.year = year;
            inValue.category = category;
            inValue.ISBN_10 = ISBN_10;
            inValue.ISBN_13 = ISBN_13;
            return ((BookStore.BookCRUD.BookCRUDSoap)(this)).InsertAllAsync(inValue);
        }
        
        public object Update_Element(int ID, string ElementName, string ElementValue) {
            return base.Channel.Update_Element(ID, ElementName, ElementValue);
        }
        
        public System.Threading.Tasks.Task<object> Update_ElementAsync(int ID, string ElementName, string ElementValue) {
            return base.Channel.Update_ElementAsync(ID, ElementName, ElementValue);
        }
        
        public object Update(int ID) {
            return base.Channel.Update(ID);
        }
        
        public System.Threading.Tasks.Task<object> UpdateAsync(int ID) {
            return base.Channel.UpdateAsync(ID);
        }
        
        public object Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<object> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public int Length() {
            return base.Channel.Length();
        }
        
        public System.Threading.Tasks.Task<int> LengthAsync() {
            return base.Channel.LengthAsync();
        }
        
        public object Save() {
            return base.Channel.Save();
        }
        
        public System.Threading.Tasks.Task<object> SaveAsync() {
            return base.Channel.SaveAsync();
        }
        
        public object Search_price(string low, string high) {
            return base.Channel.Search_price(low, high);
        }
        
        public System.Threading.Tasks.Task<object> Search_priceAsync(string low, string high) {
            return base.Channel.Search_priceAsync(low, high);
        }
    }
}