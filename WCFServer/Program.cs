using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;//Liberia per fornire un Host di Servizi

namespace WCFServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost svcHost = new ServiceHost(typeof(ServerServices));      //Inizializzo un Server Host per i servizi implementati in "ServerServices"
                svcHost.Open();     //Apre Il Server

                Console.WriteLine("Server Attivo !!!");
                Console.ReadLine();
                svcHost.Close();
                Console.WriteLine("Servizio Interrotto");

            }
            catch (Exception ex)
            {
                Console.WriteLine("UNTO: " + ex.ToString());
            }
        }
    }
}
