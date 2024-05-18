using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Implementacion_DSI_Grupo10 ;
using System.Data.SqlClient;

namespace Implementacion_DSI_Grupo10
{
    class Exposicion
    {
        BaseDatos baseDatos = new BaseDatos();
        DataTable tabla = new DataTable();
        public DataTable ConocerExpo()
        {
            string sql = "SELECT * FROM Exposicion";
            DataTable tabla = new DataTable();
            tabla = baseDatos.ejecutar_consulta(sql);
            return tabla;
        }
    }
}
