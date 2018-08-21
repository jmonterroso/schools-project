using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.Threading;


namespace ProyectoAnaMarinOrientacion
{
    static class Program
    {


       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmPrincipal());
            Application.Run(new FrmLogin());

            log4net.Config.XmlConfigurator.Configure();
        }
            

    }
    }

