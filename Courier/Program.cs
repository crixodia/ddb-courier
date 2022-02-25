using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Courier.GUI.Vehiculo;
using Courier.GUI.Cliente;
using Courier.GUI.Empleado;
using Courier.GUI.Guia;
using Courier.GUI.Sucursal;
using Courier.Driver;

namespace Courier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Driver.Connection.ConnectionConfig(
                "localhost", 
                "sa", 
                "P@ssw0rd", 
                "tramaco_quito"
            );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main("tramaco_quito en " + "localhost"));
        }
    }
}
