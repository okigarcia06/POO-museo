using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Implementacion_DSI_Grupo10
{
    class Empleado
    {
        BaseDatos baseDatos = new BaseDatos();
        System.Data.DataTable tabla = new DataTable();

        public DataTable ConocerEmpleado()
        {
            string sql = "SELECT * FROM Empleado";
            DataTable tabla = new DataTable();
            tabla = baseDatos.ejecutar_consulta(sql);
            return tabla;
        }




    }  

}
