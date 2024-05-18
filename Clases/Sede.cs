using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Implementacion_DSI_Grupo10
{
    class Sede
    {
        BaseDatos baseDatos = new BaseDatos();
        System.Data.DataTable tabla = new DataTable();
        
        public DataTable esVigente()
        {
             string sql = "SELECT * FROM Sede WHERE Id_tarifa = 1 or Id_tarifa = 2 or Id_tarifa = 11";
             DataTable tabla = new DataTable();
             tabla = baseDatos.ejecutar_consulta(sql);
             return tabla;
        }

    }   

}
