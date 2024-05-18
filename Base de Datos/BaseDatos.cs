using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace Implementacion_DSI_Grupo10
{
    class BaseDatos

    {
        public enum estado_BE { correcto, error }
        public enum forma_conexion { simple, transaccion }
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        OleDbTransaction transaccion;
        forma_conexion tipo_conexion = forma_conexion.simple;
        estado_BE control_transaccion = estado_BE.correcto;

        // string cadena_conexion = System.Configuration.ConfigurationManager.ConnectionStrings["remoteDatabase"].ConnectionString;
        //string cadena_conexion = "Provider=SQLNCLI11;Data Source=35.202.232.111;Persist Security Info=True;User ID=sqlcantina; Password=sqlcantina1_";
        string cadena_conexion = "Data Source=DESKTOP-BR93MVJ\\SQLEXPRESS;Initial Catalog='dsi museo';Integrated Security=True";

        private void conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = cadena_conexion;
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                if (tipo_conexion == forma_conexion.transaccion)
                {
                    transaccion = conexion.BeginTransaction(IsolationLevel.ReadUncommitted);
                    cmd.Transaction = transaccion;
                }
            }
        }
        private void desconectar()
        {
            if (tipo_conexion == forma_conexion.simple)
            {
                conexion.Close();
            }
        }
        public DataTable ejecutar_consulta(string sql)
        {
            conectar();
            DataTable tabla = new DataTable();
            cmd.CommandText = sql;
            try
            {
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                control_transaccion = estado_BE.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                  + "En el comando:" + "\n"
                  + sql + "\n"
                  + "El mensaje es:" + "\n"
                  + e.Message);

            }
            desconectar();
            return tabla;
        }
        public estado_BE insertar(string sql)
        {
            this.conectar();
            this.cmd.CommandText = sql;
            try
            {
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                control_transaccion = estado_BE.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                  + "En el comando:" + "\n"
                  + sql + "\n"
                  + "El mensaje es:" + "\n"
                  + e.Message);
            }
            this.desconectar();
            return control_transaccion;
        }
        public estado_BE modificar(string sql)
        {
            this.conectar();
            this.cmd.CommandText = sql;

            try
            {
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                control_transaccion = estado_BE.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                  + "En el comando:" + "\n"
                  + sql + "\n"
                  + "El mensaje es:" + "\n"
                  + e.Message);
            }
            this.desconectar();
            return control_transaccion;
        }
        public estado_BE borrar(string sql)
        {
            this.conectar();
            this.cmd.CommandText = sql;

            try
            {
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                control_transaccion = estado_BE.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                  + "En el comando:" + "\n"
                  + sql + "\n"
                  + "El mensaje es:" + "\n"
                  + e.Message);
            }
            this.desconectar();
            return control_transaccion;
        }

        public void inicio_transaccion()
        {
            tipo_conexion = forma_conexion.transaccion;
            control_transaccion = estado_BE.correcto;
        }
        public estado_BE cerrar_transaccion()
        {
            if (control_transaccion == estado_BE.correcto)
            {
                //transaccion.Commit();
                tipo_conexion = forma_conexion.simple;
                desconectar();
                return estado_BE.correcto;
            }
            else
            {
                //transaccion.Rollback();
                tipo_conexion = forma_conexion.simple;
                desconectar();
                return estado_BE.error;
            }
        }
        public string formato_fecha(string fecha)
        {
            return fecha.Substring(6, 4)
                + "-" + fecha.Substring(3, 2)
                + "-" + fecha.Substring(0, 2);
        }

    }

}
