using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    [DataContract]
    public class Film
    {
        [DataMember]
        int id { get; set; }
        [DataMember]
        string titolo { get; set; }
        [DataMember]
        string descrizione { get; set; }
        [DataMember]
        bool disponibile { get; set; }
        [DataMember]
        string url_image { get; set; }

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
