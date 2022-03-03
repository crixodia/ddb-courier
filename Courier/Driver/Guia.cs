using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Driver
{
    public class Guia
    {
        public string Codigo { get; set; }
        public int Sucursal { get; set; }
        public string Empleado { get; set; }
        public string Cliente { get; set; }
        public string FechaRecepcion { get; set; }
        public string Descripcion { get; set; }
        public string ProvinciaDestino { get; set; }
        public string CiudadDestino { get; set; }
        public string DireccionDestino { get; set; }

        public Guia(int sucursal, string empleado, string cliente, string fechaRecepcion, string descripcion, string provincia, string ciudad, string direccion, string codigo)
        {
            Sucursal = sucursal;
            Empleado = empleado;
            Cliente = cliente;
            FechaRecepcion = fechaRecepcion;
            Descripcion = descripcion;
            ProvinciaDestino = provincia;
            CiudadDestino = ciudad;
            DireccionDestino = direccion;
            Codigo = codigo;
        }

        private int InsertEstado()
        {
            int result = Connection.CrudNonReader(
                string.Format(
                "insert into [CKPDESKTOP].[tramaco].[dbo].[ESTADO_PAQUETE] values('{0}', '{1}', null, 'B')",
                Codigo,
                Sucursal
                )
            );
            Connection.Close();
            return result;
        }

        private int UpdateEstado(string newCodigo)
        {
            int result = Connection.CrudNonReader(
                string.Format(
                "update [CKPDESKTOP].[tramaco].[dbo].[ESTADO_PAQUETE] set CODIGO_PAQUETE = '{0}', SUC_CODIGO_SUCURSAL='{1}' where CODIGO_PAQUETE = '{2}'",
                newCodigo,
                Sucursal,
                Codigo
                )
            );
            Connection.Close();
            return result;
        }

        public int Insert()
        {
            int result = Connection.CrudNonReader(
                string.Format(
                    "set xact_abort on;insert into GUIAV values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');",
                    Codigo,
                    Sucursal,
                    Empleado,
                    Cliente,
                    FechaRecepcion,
                    Descripcion,
                    ProvinciaDestino,
                    CiudadDestino,
                    DireccionDestino
                )
            );
            Connection.Close();
            return InsertEstado() + result;
        }

        public int Update(string newCodigo)
        {
            Console.WriteLine(newCodigo);
            int result = Connection.CrudNonReader(
                string.Format(
                    "set xact_abort on;update GUIAV set " +
                    "CODIGO_PAQUETE = '{0}'," +
                    "SUC_CODIGO_SUCURSAL = '{1}'," +
                    "EMP_CODIGO_EMPLEADO = '{2}'," +
                    "CLI_CODIGO_CLIENTE = '{3}'," +
                    "FECHA_RECEPCION = '{4}'," +
                    "DESCRIPCION = '{5}'," +
                    "DIRECCION_DESTINO = '{6}'," +
                    "CIUDAD_DESTINO = '{7}'," +
                    "PROVINCIA_DESTINO = '{8}' " +
                    "where CODIGO_PAQUETE = '{9}';",
                    newCodigo,
                    Sucursal,
                    Empleado,
                    Cliente,
                    FechaRecepcion,
                    Descripcion,
                    DireccionDestino,
                    CiudadDestino,
                    ProvinciaDestino,
                    Codigo
                )
            );
            Connection.Close();
            return UpdateEstado(newCodigo) + result;
        }


        public static DataTable GetAll()
        {
            DataTable dt = Connection.Query("SELECT * FROM GUIAV");
            Connection.Close();
            return dt;
        }


        public static int DeleteByCodigo(string codigoPaquete)
        {
            int result = Connection.CrudNonReader(
                String.Format(
                    "set xact_abort on;DELETE FROM GUIAV WHERE CODIGO_PAQUETE={0};", codigoPaquete
                )
            );
            Connection.Close();
            return result;
        }

        public static DataTable GetByCodigoCliente(string codigoCliente)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM GUIAV WHERE CLI_CODIGO_CLIENTE='{0}'",
                    codigoCliente
                )
            );
            Connection.Close();
            return dt;
        }

        public static DataTable GetByFecha(string fechaInit, string fechaEnd)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM GUIAV WHERE FECHA_RECEPCION BETWEEN '{0}' AND '{1}'",
                    fechaInit,
                    fechaEnd
                )
            );
            Connection.Close();
            return dt;
        }


        public static DataTable GetByProvincia(string provincia)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM GUIAV WHERE convert(varchar, PROVINCIA_DESTINO)='{0}'",
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
                    "SELECT * FROM GUIAV WHERE convert(varchar, CIUDAD_DESTINO)='{0}'",
                    ciudad
                )
            );
            Connection.Close();
            return dt;
        }
    }
}
