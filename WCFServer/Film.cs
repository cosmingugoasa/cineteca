using System.Runtime.Serialization;

namespace WCFServer
{
    [DataContract]
    public class Film
    {
        [DataMember]
        int id { get; }
        [DataMember]
        string titolo { get; }
        [DataMember]
        string descrizione { get; }
        [DataMember]
        bool disponibile { get; }
        [DataMember]
        string url_image { get; }

        public Film(int myId, string myTitolo, string myDescrizione, bool myDisp, string myUrl)
        {
            id = myId;
            titolo = myTitolo;
            descrizione = myDescrizione;
            disponibile = myDisp;
            url_image = myUrl;
        }
    }
}
