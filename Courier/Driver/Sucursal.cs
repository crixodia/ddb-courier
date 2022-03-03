using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Driver
{
    public class Sucursal
    {
        public int Codigo { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }

        /// <summary>
        /// Crea una Sucursal.
        /// </summary>
        /// <param name="provincia">Provincia de la sucursal</param>
        /// <param name="ciudad">Ciudad de la sucursal</param>
        /// <param name="direccion">Dirección de la sucursal</param>
        public Sucursal(string provincia, string ciudad, string direccion, int codigo = -1)
        {
            Provincia = provincia ?? throw new ArgumentNullException(nameof(provincia));
            Ciudad = ciudad ?? throw new ArgumentNullException(nameof(ciudad));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Codigo = codigo;
        }

        /// <summary>
        /// Inserta una sucursal con los datos del objeto.
        /// </summary>
        /// <returns>Número de filas insertadas</returns>
        public int Insert()
        {
            int result = Connection.CrudNonReader(
                String.Format(
                    "INSERT INTO SUCURSALV VALUES('{0}','{1}','{2}')",
                    Provincia,
                    Ciudad,
                    Direccion
                )
            );
            Connection.Close();
            return result;
        }

        /// <summary>
        /// Actualiza una sucursal en base a su codigo
        /// </summary>
        /// <returns>Número de filas actualizadas</returns>
        public int Update()
        {
            int result = Connection.CrudNonReader(
                String.Format(
                    "UPDATE SUCURSALV " +
                    "SET PROVINCIA_SUCURSAL='{0}', CIUDAD_SUCURSAL='{1}', DIRECCION_SUCURSAL='{2}' " +
                    "WHERE CODIGO_SUCURSAL='{3}'",
                    Provincia,
                    Ciudad,
                    Direccion,
                    Codigo
                )
            );
            Connection.Close();
            return result;
        }

        /// <summary>
        /// Obtiene todas las sucursales en la tabla SUCURSAL.
        /// </summary>
        /// <returns>
        /// DataTable con el contenido de SUCURSAL listo para
        /// ser insertado en un DataGridView.
        /// </returns>
        public static DataTable GetAll()
        {
            DataTable dt = Connection.Query("SELECT * FROM SUCURSALV");
            Connection.Close();
            return dt;
        }

        /// <summary>
        /// Elimina una sucursal en base a su codigo
        /// </summary>
        /// <param name="codigo">Código de la sucursal a eliminar</param>
        /// <returns>Número de filas eliminadas</returns>
        public static int DeleteByCodigo(int codigo)
        {
            int result = Connection.CrudNonReader(
                String.Format(
                    "DELETE FROM SUCURSALV WHERE CODIGO_SUCURSAL={0}",
                    codigo
                )
            );
            Connection.Close();
            return result;
        }
    }
}
