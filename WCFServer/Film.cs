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
        string titolo;
        string descrizione;
        bool disponibile;
        string url_image;

        public Film(string myTitolo, string myDescrizione, bool myDisp, string myUrl)
        {
            titolo = myTitolo;
            descrizione = myDescrizione;
            disponibile = myDisp;
            url_image = myUrl;
        }


    }
}
