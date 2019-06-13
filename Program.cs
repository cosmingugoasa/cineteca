using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using cineteca.ServiceReference; // includo servizi di referenza

namespace cineteca
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //PROVO CLASSE APPENA CREATA
            var wcfclient = new ServiceReference.ServerServicesClient();  //Istanzio un client con le referenze ai servzi offerti dal server
            bool prova = wcfclient.NuovoUtente(5, "Prova", "Prova", "Prova", "Prova", "Prova");
            
            Console.WriteLine(prova);
            Console.ReadLine();
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());*/
        }
    }
}
