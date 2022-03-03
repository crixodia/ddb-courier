using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Driver
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Empleado { get; set; }
        public int Sucursal { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public int Capacidad { get; set; }
        public string Tipo { get; set; }


        /// <summary>
        /// Crea un vehículo.
        /// </summary>
        /// <param name="empleado">Cédula del empleado responsable</param>
        /// <param name="sucursal">Código de sucursal del vehículo</param>
        /// <param name="placa">Placa del vehículo</param>
        /// <param name="modelo">Modelo del vehículo</param>
        /// <param name="anio">Año del vehículo</param>
        /// <param name="capacidad">Capacidad del vehículo en KG</param>
        /// <param name="tipo">
        /// Tipo de vehículo
        ///     ML: Motocicleta o liviano 
        ///     CL: Carga liviana
        ///     CP: Caraga pesada
        ///     CA: Camión
        /// </param>
        /// <param name="id">Id del vehículo</param>
        public Vehiculo(
            string empleado, int sucursal, string placa, string modelo,
            string anio, int capacidad, string tipo, int id = -1)
        {
            Empleado = empleado;
            Sucursal = sucursal;
            Placa = placa;
            Modelo = modelo;
            Anio = anio;
            Capacidad = capacidad;
            Tipo = tipo;
            Id = id;
        }

        /// <summary>
        /// Inserta un vehículo con los datos del objeto.
        /// </summary>
        /// <returns>Número de filas insertadas</returns>
        public int Insert()
        {
            int result = Connection.CrudNonReader(
                string.Format(
                    "INSERT INTO VEHICULO VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    Id,
                    Empleado,
                    Sucursal,
                    Placa,
                    Modelo,
                    Anio,
                    Capacidad,
                    Tipo
                )
            );
            Connection.Close();
            return result;
        }

        /// <summary>
        /// Actualiza un vehículo en base a su Id
        /// </summary>
        /// <returns>Número de filas actualizadas</returns>
        public int Update(int newId)
        {
            int result = Connection.CrudNonReader(
                string.Format(
                    "UPDATE VEHICULO " +
                    "SET ID_VEHICULO={0}," +
                    "EMP_CODIGO_EMPLEADO='{1}', " +
                    "SUC_CODIGO_SUCURSAL='{2}', " +
                    "PLACA='{3}', " +
                    "MODELO='{4}', " +
                    "ANIO='{5}', " +
                    "CAPACIDAD='{6}', " +
                    "TIPO='{7}' " +
                    "WHERE ID_VEHICULO='{8}'",
                    newId,
                    Empleado,
                    Sucursal,
                    Placa,
                    Modelo,
                    Anio,
                    Capacidad,
                    Tipo,
                    Id
                )
            );
            Connection.Close();
            return result;
        }

        /// <summary>
        /// Obtiene todos los vehículos en la tabla VEHICULO.
        /// </summary>
        /// <returns>
        /// DataTable con el contenido de VEHICULO listo para
        /// ser insertado en un DataGridView.
        /// </returns>
        public static DataTable GetAll()
        {
            DataTable dt = Connection.Query("SELECT * FROM VEHICULO");
            Connection.Close();
            return dt;
        }

        /// <summary>
        /// Elimina un vehículo en base a su id
        /// </summary>
        /// <param name="id">Id del vehículo a eliminar</param>
        /// <returns>Número de filas eliminadas</returns>
        public static int DeleteById(int id)
        {
            int result = Connection.CrudNonReader(
                String.Format(
                    "DELETE FROM VEHICULO WHERE ID_VEHICULO={0}", id
                )
            );
            Connection.Close();
            return result;
        }

        public static DataTable GetByCodigoEmpleado(string codigoEmpleado)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM VEHICULO WHERE EMP_CODIGO_EMPLEADO='{0}'",
                    codigoEmpleado
                )
            );
            Connection.Close();
            return dt;
        }


        public static DataTable GetByPlaca(string placa)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM VEHICULO WHERE PLACA='{0}'",
                    placa
                )
            );
            Connection.Close();
            return dt;
        }

        public static DataTable GetByTipo(string tipo)
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM VEHICULO WHERE TIPO='{0}'",
                    tipo
                )
            );
            Connection.Close();
            return dt;
        }

        public static DataTable GetByCapacidad(int capacidad, string symbol = "=")
        {
            DataTable dt = Connection.Query(
                string.Format(
                    "SELECT * FROM VEHICULO WHERE CAPACIDAD{0}'{1}'",
                    symbol,
                    capacidad
                )
            );
            Connection.Close();
            return dt;
        }
    }
}
