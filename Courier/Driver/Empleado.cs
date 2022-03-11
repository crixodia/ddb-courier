using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Driver
{
    public class Empleado
    {
        public string Codigo { get; set; }
        public int Sucursal { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public char Rol { get; set; }

        public Empleado(int sucursal, string nombre, string cedula, string provincia, string ciudad, string direccion, string telefono, char rol, string codigo = "")
        {
            Sucursal = sucursal;
            Nombre = nombre;
            Cedula = cedula;
            Provincia = provincia;
            Ciudad = ciudad;
            Direccion = direccion;
            Telefono = telefono;
            Rol = rol;
            Codigo = codigo;
        }

        public int Insert()
        {
            int result = Connection.CrudNonReader(
                string.Format(
                    "set xact_abort on;insert into EMPLEADOV values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');",
                    Codigo,
                    Sucursal,
                    Nombre,
                    Cedula,
                    Provincia,
                    Ciudad,
                    Direccion,
                    Telefono,
                    Rol
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
                    "set xact_abort on;update EMPLEADOV set " +
                    "CODIGO_EMPLEADO = '{0}'," +
                    "SUC_CODIGO_SUCURSAL = '{1}'," +
                    "NOMBRE_EMPLEADO = '{2}'," +
                    "CEDULA_EMPLEADO = '{3}'," +
                    "PROVINCIA_EMPLEADO = '{4}'," +
                    "CIUDAD_EMPLEADO = '{5}'," +
                    "DIRECCION_EMPLEADO = '{6}'," +
                    "TELEFONO_EMPLEADO = '{7}'," +
                    "ROL = '{8}' " +
                    "where CODIGO_EMPLEADO = '{9}';",
                    newCodigo,
                    Sucursal,
                    Nombre,
                    Cedula,
                    Provincia,
                    Ciudad,
                    Direccion,
                    Telefono,
                    Rol,
                    Codigo
                )
            );
            Connection.Close();
            return result;
        }


        public static DataTable GetAll()
        {
            DataTable dt = Connection.Query("SELECT * FROM EMPLEADOV");
            Connection.Close();
            return dt;
        }


        public static int DeleteByCodigo(string codigoEmpleado)
        {
            int result = Connection.CrudNonReader(
                String.Format(
                    "set xact_abort on;DELETE FROM EMPLEADOV WHERE CODIGO_EMPLEADO='{0}';", codigoEmpleado
                )
            );
            Connection.Close();
            return result;
        }


        public static DataTable GetByCedula(string cedula)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM EMPLEADOV WHERE CEDULA_EMPLEADO='{0}'",
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
                    "SELECT * FROM EMPLEADOV WHERE convert(varchar, PROVINCIA_EMPLEADO)='{0}'",
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
                    "SELECT * FROM EMPLEADOV WHERE convert(varchar, CIUDAD_EMPLEADO)='{0}'",
                    ciudad
                )
            );
            Connection.Close();
            return dt;
        }

        public static DataTable GetByRol(string rol)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM EMPLEADOV WHERE ROL='{0}'",
                    rol
                )
            );
            Connection.Close();
            return dt;
        }

        public static bool ValidateByCodigo(string codigo)
        {
            DataTable dt = Connection.Query(string.Format("SELECT CODIGO_EMPLEADO FROM EMPLEADOV"));
            Connection.Close();
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == codigo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidateByCedula(string cedula)
        {
            DataTable dt = Connection.Query(string.Format("SELECT CEDULA_EMPLEADO FROM EMPLEADOV"));
            Connection.Close();
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == cedula)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
