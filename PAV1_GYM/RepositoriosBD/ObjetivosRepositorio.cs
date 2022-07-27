using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using System.Data;
using System.Windows.Forms;

namespace PAV1_GYM.RepositoriosBD
{
    public class ObjetivosRepositorio
    {
        public List<Objetivo> GetObjetivos()
        {
            var objetivos = new List<Objetivo>();
            var sentenciaSql = $"SELECT * FROM Objetivos";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var objetivo = Mapear(fila);
                objetivos.Add(objetivo);
            }
            return objetivos;
        }

        public static bool ValidarExistenciaObjetivo(string nombre)
        {
            var sentenciaSql = $"SELECT nombre FROM Objetivos WHERE nombre = '{nombre}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaDuranteTransaccion(sentenciaSql);
            if (tablaResultado.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        private Objetivo Mapear(DataRow row)
        {
            var objetivo = new Objetivo();
            objetivo.Id_Objetivo = Convert.ToInt32(row["Id_Objetivo"]);
            objetivo.Nombre = row["Nombre"].ToString();
            objetivo.Descripcion = row["Descripcion"].ToString();
            return objetivo;
        }

        public Objetivo ObtenerObjetivo(string nombre)
        {
            var sentenciaSql = $"SELECT * FROM Objetivos WHERE nombre LIKE '%{nombre}%'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count >= 1)
            {
                var objetivo = Mapear(tablaResultado.Rows[0]);
                return objetivo;
            }
            else
                throw new ApplicationException("El objetivo no existe, verifique el nombre");
        }


        public List<Objetivo> ObtenerObjetivo(Objetivo o)
        {
            List<Objetivo> objetivos = new List<Objetivo>();
            var sentenciaSql = "SELECT * FROM Objetivos WHERE nombre LIKE '%%'";
            if (o.Id_Objetivo != 0)
                sentenciaSql += $" AND id_objetivo = {o.Id_Objetivo}";
            if (o.Nombre != "")
                sentenciaSql += $" AND nombre LIKE '%{o.Nombre}%'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var objetivo = Mapear(fila);
                objetivos.Add(objetivo);
            }
            return objetivos;
        }

        public bool RegistrarObjetivo(Objetivo o)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    if (!ValidarExistenciaObjetivo(o.Nombre))
                    {
                        var sentenciaSQL = $"INSERT INTO Objetivos (nombre, descripcion) VALUES ('{o.Nombre}', '{o.Descripcion}') ";
                        var filasAfectadas = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sentenciaSQL);
                        tx.Commit();
                        return true;
                    }
                    else
                        throw new ApplicationException("El Objetivo ya existe");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return false;
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }           
        }

        public bool EliminarObjetivo(int id_objetivo)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = $"DELETE FROM Objetivos WHERE id_objetivo = {id_objetivo}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sentenciaSql);
                    tx.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return false;
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }    

        public bool ModificarObjetivo(Objetivo o, string nombreObjetivoBuscado)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = "UPDATE Objetivos SET nombre = @nombre, descripcion = @descripcion WHERE nombre LIKE @nombreBuscado";
                    var lista = new List<Parametro>();
                    lista.Add(new Parametro { NombreColumna = "@nombreBuscado", Valor = nombreObjetivoBuscado });
                    lista.Add(new Parametro { NombreColumna = "@nombre", Valor = o.Nombre });
                    lista.Add(new Parametro { NombreColumna = "@descripcion", Valor = o.Descripcion });
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionAddSQL(sentenciaSql, lista);
                    tx.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    tx.Rollback();
                    return false;
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }
    }
}
