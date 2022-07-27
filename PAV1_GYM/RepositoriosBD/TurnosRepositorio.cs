using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PAV1_GYM.RepositoriosBD
{
    public class TurnosRepositorio
    {
        public List<Turno> GetTurnos()
        {
            var turnos = new List<Turno>();
            var sentenciaSql = "SELECT * FROM Turnos";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var turno = new Turno();
                turno.Id_Turno = Convert.ToInt32(fila["id_turno"]);
                turno.Nombre = fila["nombre"].ToString();
                turno.Hora_Inicio = DateTime.Parse(fila["hora_Inicio"].ToString());
                turno.Hora_Fin = DateTime.Parse(fila["hora_Fin"].ToString());
                turno.Dia = fila["dia"].ToString();
                turno.Estado = fila["estado"].ToString() == "S";
                turnos.Add(turno);
            }
            return turnos;
        }

        public static bool ValidarExistenciaTurno(string nombre, string dia)
        {
            var sentenciaSql = $"SELECT nombre FROM Turnos WHERE nombre = '{nombre}' AND dia = '{dia}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaDuranteTransaccion(sentenciaSql);
            if (tablaResultado.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        private Turno Mapear(DataRow row)
        {
            var turno = new Turno();
            turno.Id_Turno = Convert.ToInt32(row["Id_Turno"]);
            turno.Nombre = row["Nombre"].ToString();
            turno.Hora_Inicio = DateTime.Parse(row["Hora_Inicio"].ToString());
            turno.Hora_Fin = DateTime.Parse(row["Hora_Fin"].ToString());
            turno.Dia = row["Dia"].ToString();
            turno.Estado = row["Estado"].ToString() == "S";
            return turno;
        }

        public Turno ObtenerTurno(string nombre, string dia)
        {
            var sentenciaSql = $"SELECT * FROM Turnos WHERE nombre = '{nombre}' AND dia = '{dia}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count >= 1)
            {
                var turno = Mapear(tablaResultado.Rows[0]);
                return turno;
            }
            else
                throw new ApplicationException("El turno no existe, verifique el nombre");
        }

        public List<Turno> Obtener(Turno t)
        {
            List<Turno> turnos = new List<Turno>();
            var sentenciaSql = "SELECT * FROM Turnos WHERE nombre LIKE '%%'";
            var estado = t.Estado ? "S" : "N";
            if (t.Id_Turno != 0)
                sentenciaSql += $" AND id_turno = {t.Id_Turno}";
            if (t.Nombre != "")
                sentenciaSql += $" AND nombre LIKE '%{t.Nombre}%'";
            sentenciaSql += $" AND estado = '{estado}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var turno = Mapear(fila);
                turnos.Add(turno);
            }
            return turnos;
        }

        public List<Turno> ObtenerTurnosXActividad(int id_actividad, string dia)
        {
            string diaSinAcentos = Regex.Replace(dia, @"[^a-zA-z0-9 ]+", "");
            List<Turno> turnos = new List<Turno>();
            var sentenciaSql = $"SELECT t.* FROM Turnos t LEFT JOIN Actividades_X_Turnos at ON t.id_turno = at.id_turno WHERE at.id_actividad = {id_actividad} AND t.dia LIKE '%{diaSinAcentos}%'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var turno = Mapear(fila);
                turnos.Add(turno);
            }
            return turnos;
        }

        public List<Turno> GetTurnosXDia(string dia)
        {
            var turnos = new List<Turno>();
            var sentenciaSql = $"SELECT * FROM Turnos WHERE dia LIKE '%{dia}%'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var turno = Mapear(fila);
                turnos.Add(turno);
            }
            return turnos;
        }

        public DataTable GetTurnosUnicos()
        {
            var sentenciaSql = $"SELECT DISTINCT nombre FROM Turnos";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tablaResultado;
        }

        public bool RegistrarTurno(Turno t)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    if (!ValidarExistenciaTurno(t.Nombre, t.Dia))
                    {
                        var sentenciaSQL = $"INSERT INTO Turnos (nombre, hora_inicio, hora_fin, dia, estado) VALUES ('{t.Nombre}', '{t.Hora_Inicio.ToString("HH:mm")}', '{t.Hora_Fin.ToString("HH: mm")}', '{t.Dia}', 'S')";
                        var filasAfectadas = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sentenciaSQL);
                        tx.Commit();
                        return true;
                    }
                    else
                        throw new ApplicationException("El turno ya existe");   
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

        public bool EliminarTurno(int id_turno)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = $"DELETE FROM Turnos WHERE id_turno = {id_turno}";
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

        public bool ModificarEstadoTurno(Turno t)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var estado = t.Estado ? "S" : "N";
                    var sentenciaSql = $"UPDATE Turnos SET estado='{estado}' WHERE nombre = '{t.Nombre}' AND dia = '{t.Dia}'";
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

        public bool ModificarTurno(Turno t, string nombreBuscado, string diaBuscado)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = "UPDATE Turnos SET nombre = @nombre, hora_inicio = @hora_inicio, hora_fin = @hora_fin, dia = @dia, estado= @estado WHERE nombre = @nombreBuscado AND dia = @diaBuscado";
                    var lista = new List<Parametro>();
                    lista.Add(new Parametro { NombreColumna = "@nombreBuscado", Valor = nombreBuscado });
                    lista.Add(new Parametro { NombreColumna = "@diaBuscado", Valor = diaBuscado });
                    lista.Add(new Parametro { NombreColumna = "@nombre", Valor = t.Nombre });
                    lista.Add(new Parametro { NombreColumna = "@hora_inicio", Valor = t.Hora_Inicio.ToString("HH:mm") });
                    lista.Add(new Parametro { NombreColumna = "@hora_fin", Valor = t.Hora_Fin.ToString("HH:mm") });
                    lista.Add(new Parametro { NombreColumna = "@dia", Valor = t.Dia });
                    lista.Add(new Parametro { NombreColumna = "@estado", Valor = 'S' });
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionAddSQL(sentenciaSql, lista);
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
    }
}