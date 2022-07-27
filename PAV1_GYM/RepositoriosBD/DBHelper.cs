using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PAV1_GYM.Entidades;

namespace PAV1_GYM.RepositoriosBD
{
    public class DBHelper
    {
        private static DBHelper instance = new DBHelper();

        //declaro variable que almacerá un objeto <cmd> del tipo <SqlConnection>
        private SqlConnection _conexion = new SqlConnection();

        //declaro variable que almacerá un objeto <cmd> del tipo <SqlCommand>
        private SqlCommand _cmd = new SqlCommand();

        private string string_conexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K7G08_2022;User ID=BD3K7G08_2022;Password=PSW08_68041";


        public static DBHelper GetDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        public DataTable ConsultaSQL(string strSql)
        {
            Conectar();
            _cmd.CommandText = strSql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(_cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                // mensaje de error que se emite cuando se produjo un error en el
                // comando ejecutado anteriormente por cmd.ExecuteReader
                MessageBox.Show("Hubo un error en la Base de Datos\n"
                                + "Con el comando: \n"
                                + strSql + "\n"
                                + "El error en la base de datos:\n"
                                + ex.Message);
                CloseConnection();
                return tabla;
            }
            CloseConnection();
            return tabla;
        }

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        public int EjecutarSQL(string strSql)
        {
            int afectadas = 0;
            Conectar();
            _cmd.CommandText = strSql;
            try
            {
                afectadas = _cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // mensaje de error que se emite cuando se produjo un error en el
                // comando ejecutado anteriormente por cmd.ExecuteReader
                MessageBox.Show("Hubo un error en la Base de Datos\n"
                                + "Con el comando: \n"
                                + strSql + "\n"
                                + "El error en la base de datos:\n"
                                + ex.Message);
                CloseConnection();
                return afectadas;
            }
            CloseConnection();
            return afectadas;
        }

        public int EjecutarAddSQL(string strSql, List<Parametro> Parametros)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = string_conexion;
            cnn.Open();
            SqlCommand cmd = new SqlCommand(strSql, cnn);
            foreach (Parametro param in Parametros)
            {
                cmd.Parameters.AddWithValue(param.NombreColumna, param.Valor);
            }
            afectadas = cmd.ExecuteNonQuery();
            this.CloseConnection(cnn);
            return afectadas;
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        public void CloseConnection()
        {
            if (_conexion.State == ConnectionState.Open)
            {
                //cierra la conexión con la base de datos
                _conexion.Close();
            }
        }

        public void Conectar()
        {
            // valida en estado de la conexion, inicia una conexión solo en el caso de
            // que la conexión este cerrada
            if (_conexion.State == ConnectionState.Closed)
            {
                //_conexion = new SqlConnection();
                //_cmd = new SqlCommand();
                //asigan al objeto <conexion> la cadena de conexion
                _conexion.ConnectionString = string_conexion;
                try
                {
                    //agrega la conexion (se crea el pipe entre la aplicación y la base de datos)
                    _conexion.Open();
                }
                catch (Exception ex)
                {
                    // mensaje de error que se emite cuando se produjo un error en el
                    // comando de apertura de la conexión
                    MessageBox.Show("Hubo un error en la Base de Datos\n"
                    + "Con el comando: \n"
                    + "conexion.Open()" + "\n"
                    + "El error en la base de datos:\n"
                    + ex.Message);
                    // cambio de estado del control de transacción
                    return;
                }
                //se comunica al objeto <cmd> sobre que conexion debe trabajar
                _cmd.Connection = _conexion;
                //se establece el tipo de comando que va ha ejecutar
                _cmd.CommandType = CommandType.Text;
            }
        }

        public SqlTransaction IniciarTransaccion()
        {
            Conectar();
            var transaccion = _conexion.BeginTransaction();
            _cmd.Transaction = transaccion;
            return transaccion;
        }

        public int EjecutarTransaccionSQL(string strSql)
        {
            //var id = 0;
            _cmd.CommandText = strSql;

            //if (_cmd.ExecuteNonQuery() > 0)
            //{
            //    string consultaGetId = "Select @@Identity";
            //    _cmd.CommandText = consultaGetId;
            //    id = int.Parse(_cmd.ExecuteScalar()?.ToString());
            //}
            //return id;
            return _cmd.ExecuteNonQuery();
        }

        public int EjecutarTransaccionAddSQL(string strSql, List<Parametro> Parametros)
        {
            _cmd.Parameters.Clear();
            foreach (Parametro param in Parametros)
            {
                _cmd.Parameters.AddWithValue(param.NombreColumna, param.Valor);
            }
            _cmd.CommandText = strSql;
            return _cmd.ExecuteNonQuery();
        }

        public void EjecutarUpdateTransaccionAddSQL(string strSql, List<Parametro> Parametros)
        {
            _cmd.Parameters.Clear();
            foreach (Parametro param in Parametros)
            {
                _cmd.Parameters.AddWithValue(param.NombreColumna, param.Valor);
            }
            _cmd.CommandText = strSql;
            _cmd.ExecuteNonQuery();
        }

        public void EjecutarUpdateTransaccionSQL(string strSql)
        {
            _cmd.CommandText = strSql;
            _cmd.ExecuteNonQuery();
        }

        public DataTable ConsultaDuranteTransaccion(string strSql)
        {

            _cmd.CommandText = strSql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(_cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la Base de Datos\n"
                + "Con el comando: \n"
                + strSql + "\n"
                + "El error en la base de datos:\n"
                + ex.Message);
            }
            return tabla;
        }
    }
}