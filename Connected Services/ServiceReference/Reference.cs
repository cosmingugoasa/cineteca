﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cineteca.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Film", Namespace="http://schemas.datacontract.org/2004/07/WCFServer")]
    [System.SerializableAttribute()]
    public partial class Film : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descrizioneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool disponibileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titoloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string url_imageField;
        
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
        public string descrizione {
            get {
                return this.descrizioneField;
            }
            set {
                if ((object.ReferenceEquals(this.descrizioneField, value) != true)) {
                    this.descrizioneField = value;
                    this.RaisePropertyChanged("descrizione");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool disponibile {
            get {
                return this.disponibileField;
            }
            set {
                if ((this.disponibileField.Equals(value) != true)) {
                    this.disponibileField = value;
                    this.RaisePropertyChanged("disponibile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string titolo {
            get {
                return this.titoloField;
            }
            set {
                if ((object.ReferenceEquals(this.titoloField, value) != true)) {
                    this.titoloField = value;
                    this.RaisePropertyChanged("titolo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string url_image {
            get {
                return this.url_imageField;
            }
            set {
                if ((object.ReferenceEquals(this.url_imageField, value) != true)) {
                    this.url_imageField = value;
                    this.RaisePropertyChanged("url_image");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Utente", Namespace="http://schemas.datacontract.org/2004/07/WCFServer")]
    [System.SerializableAttribute()]
    public partial class Utente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cognomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
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
        public string cognome {
            get {
                return this.cognomeField;
            }
            set {
                if ((object.ReferenceEquals(this.cognomeField, value) != true)) {
                    this.cognomeField = value;
                    this.RaisePropertyChanged("cognome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isAdmin {
            get {
                return this.isAdminField;
            }
            set {
                if ((this.isAdminField.Equals(value) != true)) {
                    this.isAdminField = value;
                    this.RaisePropertyChanged("isAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeField, value) != true)) {
                    this.nomeField = value;
                    this.RaisePropertyChanged("nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IServerServices")]
    public interface IServerServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/DoWork", ReplyAction="http://tempuri.org/IServerServices/DoWorkResponse")]
        bool DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/DoWork", ReplyAction="http://tempuri.org/IServerServices/DoWorkResponse")]
        System.Threading.Tasks.Task<bool> DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/RegisterUser", ReplyAction="http://tempuri.org/IServerServices/RegisterUserResponse")]
        bool RegisterUser(string email, string passw, string nome, string cognome, int isAdmin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/RegisterUser", ReplyAction="http://tempuri.org/IServerServices/RegisterUserResponse")]
        System.Threading.Tasks.Task<bool> RegisterUserAsync(string email, string passw, string nome, string cognome, int isAdmin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/LoginUser", ReplyAction="http://tempuri.org/IServerServices/LoginUserResponse")]
        bool LoginUser(string email, string passw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/LoginUser", ReplyAction="http://tempuri.org/IServerServices/LoginUserResponse")]
        System.Threading.Tasks.Task<bool> LoginUserAsync(string email, string passw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/StoreFilmsList", ReplyAction="http://tempuri.org/IServerServices/StoreFilmsListResponse")]
        cineteca.ServiceReference.Film[] StoreFilmsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/StoreFilmsList", ReplyAction="http://tempuri.org/IServerServices/StoreFilmsListResponse")]
        System.Threading.Tasks.Task<cineteca.ServiceReference.Film[]> StoreFilmsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/GetUser", ReplyAction="http://tempuri.org/IServerServices/GetUserResponse")]
        cineteca.ServiceReference.Utente GetUser(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/GetUser", ReplyAction="http://tempuri.org/IServerServices/GetUserResponse")]
        System.Threading.Tasks.Task<cineteca.ServiceReference.Utente> GetUserAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/RentFilm", ReplyAction="http://tempuri.org/IServerServices/RentFilmResponse")]
        bool RentFilm(int user_id, int film_id, string start_nol, string stop_nol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/RentFilm", ReplyAction="http://tempuri.org/IServerServices/RentFilmResponse")]
        System.Threading.Tasks.Task<bool> RentFilmAsync(int user_id, int film_id, string start_nol, string stop_nol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/SetFilmStatus", ReplyAction="http://tempuri.org/IServerServices/SetFilmStatusResponse")]
        bool SetFilmStatus(int film_id, bool disp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/SetFilmStatus", ReplyAction="http://tempuri.org/IServerServices/SetFilmStatusResponse")]
        System.Threading.Tasks.Task<bool> SetFilmStatusAsync(int film_id, bool disp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/LibraryFilmsList", ReplyAction="http://tempuri.org/IServerServices/LibraryFilmsListResponse")]
        cineteca.ServiceReference.Film[] LibraryFilmsList(int user_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/LibraryFilmsList", ReplyAction="http://tempuri.org/IServerServices/LibraryFilmsListResponse")]
        System.Threading.Tasks.Task<cineteca.ServiceReference.Film[]> LibraryFilmsListAsync(int user_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/ReturnFilm", ReplyAction="http://tempuri.org/IServerServices/ReturnFilmResponse")]
        bool ReturnFilm(int user_id, int film_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/ReturnFilm", ReplyAction="http://tempuri.org/IServerServices/ReturnFilmResponse")]
        System.Threading.Tasks.Task<bool> ReturnFilmAsync(int user_id, int film_id);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/SetDispZero", ReplyAction="http://tempuri.org/IServerServices/SetDispZeroResponse")]
        System.Threading.Tasks.Task<bool> SetDispZeroAsync(int film_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/InsertFilm", ReplyAction="http://tempuri.org/IServerServices/InsertFilmResponse")]
        bool InsertFilm(string titolo, string descrizione, bool disponibile, string url_image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerServices/InsertFilm", ReplyAction="http://tempuri.org/IServerServices/InsertFilmResponse")]
        System.Threading.Tasks.Task<bool> InsertFilmAsync(string titolo, string descrizione, bool disponibile, string url_image);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServerServicesChannel : cineteca.ServiceReference.IServerServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServerServicesClient : System.ServiceModel.ClientBase<cineteca.ServiceReference.IServerServices>, cineteca.ServiceReference.IServerServices {
        
        public ServerServicesClient() {
        }
        
        public ServerServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServerServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool DoWork() {
            return base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task<bool> DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public bool RegisterUser(string email, string passw, string nome, string cognome, int isAdmin) {
            return base.Channel.RegisterUser(email, passw, nome, cognome, isAdmin);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterUserAsync(string email, string passw, string nome, string cognome, int isAdmin) {
            return base.Channel.RegisterUserAsync(email, passw, nome, cognome, isAdmin);
        }
        
        public bool LoginUser(string email, string passw) {
            return base.Channel.LoginUser(email, passw);
        }
        
        public System.Threading.Tasks.Task<bool> LoginUserAsync(string email, string passw) {
            return base.Channel.LoginUserAsync(email, passw);
        }
        
        public cineteca.ServiceReference.Film[] StoreFilmsList() {
            return base.Channel.StoreFilmsList();
        }
        
        public System.Threading.Tasks.Task<cineteca.ServiceReference.Film[]> StoreFilmsListAsync() {
            return base.Channel.StoreFilmsListAsync();
        }
        
        public cineteca.ServiceReference.Utente GetUser(string email) {
            return base.Channel.GetUser(email);
        }
        
        public System.Threading.Tasks.Task<cineteca.ServiceReference.Utente> GetUserAsync(string email) {
            return base.Channel.GetUserAsync(email);
        }
        
        public bool RentFilm(int user_id, int film_id, string start_nol, string stop_nol) {
            return base.Channel.RentFilm(user_id, film_id, start_nol, stop_nol);
        }
        
        public System.Threading.Tasks.Task<bool> RentFilmAsync(int user_id, int film_id, string start_nol, string stop_nol) {
            return base.Channel.RentFilmAsync(user_id, film_id, start_nol, stop_nol);
        }
        
        public bool SetFilmStatus(int film_id, bool disp) {
            return base.Channel.SetFilmStatus(film_id, disp);
        }
        
        public System.Threading.Tasks.Task<bool> SetFilmStatusAsync(int film_id, bool disp) {
            return base.Channel.SetFilmStatusAsync(film_id, disp);
        }
        
        public cineteca.ServiceReference.Film[] LibraryFilmsList(int user_id) {
            return base.Channel.LibraryFilmsList(user_id);
        }
        
        public System.Threading.Tasks.Task<cineteca.ServiceReference.Film[]> LibraryFilmsListAsync(int user_id) {
            return base.Channel.LibraryFilmsListAsync(user_id);
        }
        
        public bool ReturnFilm(int user_id, int film_id) {
            return base.Channel.ReturnFilm(user_id, film_id);
        }
        
        public System.Threading.Tasks.Task<bool> ReturnFilmAsync(int user_id, int film_id) {
            return base.Channel.ReturnFilmAsync(user_id, film_id);
        }
        
        public bool InsertFilm(string titolo, string descrizione, bool disponibile, string url_image) {
            return base.Channel.InsertFilm(titolo, descrizione, disponibile, url_image);
        }
        
        public System.Threading.Tasks.Task<bool> InsertFilmAsync(string titolo, string descrizione, bool disponibile, string url_image) {
            return base.Channel.InsertFilmAsync(titolo, descrizione, disponibile, url_image);
        }
    }
}
