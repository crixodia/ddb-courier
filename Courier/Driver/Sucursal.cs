using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Driver
{
    class Sucursal
    {
        private int Codigo { get; set; }
        private string Provincia { get; set; }
        private string Ciudad { get; set; }
        private string Direccion { get; set; }

        public Sucursal(string provincia, string ciudad, string direccion)
        {
            Provincia = provincia ?? throw new ArgumentNullException(nameof(provincia));
            Ciudad = ciudad ?? throw new ArgumentNullException(nameof(ciudad));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
        }

        public int Insert()
        {
            return Connection.CrudNonReader("SELECT * FROM x");
        }

        public static DataTable GetAll()
        {
            return Connection.Query("SELECT * FROM SUCURSAL");
        }
    }
}
