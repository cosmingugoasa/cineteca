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
        bool disponibilita;
        string url_image;


        public Film(string myTitolo, string myDesc, bool myDisp, string myUrl) {
            titolo = myTitolo;
            descrizione = myDesc;
            disponibilita = myDisp;
            url_image = myUrl;
        }

    }
}
