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
        string titolo { get; set; }
        [DataMember]
        string descrizione { get; set; }
        [DataMember]
        bool disponibile { get; set; }
        [DataMember]
        string url_image { get; set; }

        public Film(string myTitolo, string myDescrizione, bool myDisp, string myUrl)
        {
            titolo = myTitolo;
            descrizione = myDescrizione;
            disponibile = myDisp;
            url_image = myUrl;
        }

        /*
        public string GetTitolo()
        {
            return titolo;
        }

        public string GetDesc()
        {
            return descrizione;
        }

        public bool GetDisp()
        {
            return disponibile;
        }

        public string GetUrl()
        {
            return url_image;
        }
        */

    }
}
