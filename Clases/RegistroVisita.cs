using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Implementacion_DSI_Grupo10
{
    class ReservaVisita
    {
        BaseDatos baseDatos = new BaseDatos();
        DataTable tabla = new DataTable();
        public DataTable ConocerRegistro()
        {
            string sql = "SELECT * FROM ReservaVisita";
            DataTable tabla = new DataTable();
            tabla = baseDatos.ejecutar_consulta(sql);
            return tabla;
        }
    }
}
