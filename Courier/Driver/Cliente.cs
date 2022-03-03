using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Driver
{
    public class Cliente
    {
        public string Codigo { get; set; }
        public int Sucursal { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Zip { get; set; }

        public Cliente(int sucursal, string nombre, string cedula, string provincia, string ciudad, string direccion, string telefono, string zip, string codigo = "")
        {
            Sucursal = sucursal;
            Nombre = nombre;
            Cedula = cedula;
            Provincia = provincia;
            Ciudad = ciudad;
            Direccion = direccion;
            Telefono = telefono;
            Zip = zip;
            Codigo = codigo;
        }

        public int Insert()
        {
            int result = Connection.CrudNonReader(
                string.Format(
                    "set xact_abort on;insert into CLIENTEV values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');",
                    Codigo,
                    Sucursal,
                    Nombre,
                    Cedula,
                    Provincia,
                    Ciudad,
                    Direccion,
                    Telefono,
                    Zip
                )
            );
            Connection.Close();
            return result;
        }

        public int Update(string newCodigo)
        {
            Console.WriteLine(newCodigo);
            int result = Connection.CrudNonReader(
                string.Format(
                    "set xact_abort on;update CLIENTEV set " +
                    "CODIGO_CLIENTE = '{0}'," +
                    "SUC_CODIGO_SUCURSAL = '{1}'," +
                    "NOMBRE_CLIENTE = '{2}'," +
                    "CEDULA_CLIENTE = '{3}'," +
                    "PROVINCIA_CLIENTE = '{4}'," +
                    "CIUDAD_CLIENTE = '{5}'," +
                    "DIRECCION_CLIENTE = '{6}'," +
                    "TELEFONO_CLIENTE = '{7}'," +
                    "ZIP = '{8}' " +
                    "where CODIGO_CLIENTE = '{9}';",
                    newCodigo,
                    Sucursal,
                    Nombre,
                    Cedula,
                    Provincia,
                    Ciudad,
                    Direccion,
                    Telefono,
                    Zip,
                    Codigo
                )
            );
            Connection.Close();
            return result;
        }


        public static DataTable GetAll()
        {
            DataTable dt = Connection.Query("SELECT * FROM CLIENTEV");
            Connection.Close();
            return dt;
        }


        public static int DeleteByCodigo(string codigoCliente)
        {
            int result = Connection.CrudNonReader(
                String.Format(
                    "set xact_abort on;DELETE FROM CLIENTEV WHERE CODIGO_CLIENTE='{0}';", codigoCliente
                )
            );
            Connection.Close();
            return result;
        }


        public static DataTable GetByCedula(string cedula)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM CLIENTEV WHERE CEDULA_CLIENTE='{0}'",
                    cedula
                )
            );
            Connection.Close();
            return dt;
        }

        public static DataTable GetByProvincia(string provincia)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM CLIENTEV WHERE convert(varchar, PROVINCIA_CLIENTE)='{0}'",
                    provincia
                )
            );
            Connection.Close();
            return dt;
        }

        public static DataTable GetByCiudad(string ciudad)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM CLIENTEV WHERE convert(varchar, CIUDAD_CLIENTE)='{0}'",
                    ciudad
                )
            );
            Connection.Close();
            return dt;
        }

        public static DataTable GetByZip(string zip)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM CLIENTEV WHERE ZIP='{0}'",
                    zip
                )
            );
            Connection.Close();
            return dt;
        }

    }
}
