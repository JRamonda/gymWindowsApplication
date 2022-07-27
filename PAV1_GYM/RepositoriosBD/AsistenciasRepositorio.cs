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
    public class AsistenciasRepositorio
    {
        public List<Asistencia> ObtenerAsistencias(Asistencia a)
        {
            List<Asistencia> asistencias = new List<Asistencia>();
            var sentenciaSql = "SELECT asi.*, ac.nombre as NombreActividad, t.nombre as NombreTurno, s.nroDoc as NroDoc, s.id_tipoDoc as Id_TipoDoc, s.nombre as NombreSocio, " +
                "s.apellido, td.nombre as NombreDoc FROM Asistencias asi LEFT JOIN Actividades ac ON asi.id_actividad = ac.id_actividad LEFT JOIN Turnos t ON asi.id_turno = t.id_turno " +
                "LEFT JOIN Socios s ON asi.nroSocio = s.nroSocio LEFT JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc WHERE asi.nroSocio LIKE '%%'";
            if (a.Socio.Nombre != "")
                sentenciaSql += $" AND s.Nombre LIKE '%{a.Socio.Nombre}%'";
            if (a.Socio.Apellido != "")
                sentenciaSql += $" AND s.Apellido LIKE '%{a.Socio.Apellido}%'";
            if (a.Turno.Nombre != "Seleccionar")
                sentenciaSql += $" AND asi.id_turno = {a.Turno.Id_Turno}";
            if (a.Actividad.Nombre != "Seleccionar")
                sentenciaSql += $" AND asi.id_actividad = {a.Actividad.Id_Actividad}";
            if (a.Fecha == DateTime.Today)
                sentenciaSql += $" AND CONVERT(VARCHAR(10), asi.fecha, 103) = CONVERT(VARCHAR(10), GETDATE(), 103)";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var asistencia = Mapear(fila);
                asistencias.Add(asistencia);
            }
            return asistencias;
        }

        private Asistencia Mapear(DataRow row)
        {
            var asistencia = new Asistencia();
            asistencia.Actividad = new Actividad
            {
                Id_Actividad = Convert.ToInt32(row["Id_Actividad"]),
                Nombre = row["NombreActividad"].ToString()
            };
            asistencia.Turno = new Turno
            {
                Id_Turno = Convert.ToInt32(row["Id_Turno"]),
                Nombre = row["NombreTurno"].ToString()
            };
            asistencia.Socio = new Socio
            {
                NroSocio = Convert.ToInt32(row["NroSocio"]),
                NroDocumento = row["NroDoc"].ToString(),
                Nombre = row["NombreSocio"].ToString(),
                Apellido = row["Apellido"].ToString(),
                TipoDocumento = new TipoDocumento
                {
                    Id_TipoDoc = int.Parse(row["Id_TipoDoc"].ToString()),
                    Nombre = row["NombreDoc"].ToString()
                }
            };
            asistencia.Fecha = Convert.ToDateTime(row["Fecha"]);
            if (!row.IsNull("Hora_Ingreso"))
                asistencia.Hora_Ingreso = DateTime.Parse(row["Hora_Ingreso"].ToString());
            if (!row.IsNull("Hora_Egreso"))
                asistencia.Hora_Egreso = DateTime.Parse(row["Hora_Egreso"].ToString());
            return asistencia;
        }

        public bool ConfirmarAsistencia(int nroSocio, int id_turno)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    if (ExisteTurno(nroSocio, id_turno, " AND hora_ingreso IS NULL"))
                    {
                        var sentenciaSql = "UPDATE Asistencias SET hora_ingreso = @hora_ingreso WHERE nroSocio = @nroSocio AND id_turno = @id_turno " +
                            "AND CONVERT(VARCHAR(10), fecha, 103) = CONVERT(VARCHAR(10), GETDATE(), 103)";
                        var lista = new List<Parametro>();
                        lista.Add(new Parametro { NombreColumna = "@nroSocio", Valor = nroSocio });
                        lista.Add(new Parametro { NombreColumna = "@id_turno", Valor = id_turno });
                        lista.Add(new Parametro { NombreColumna = "@hora_ingreso", Valor = DateTime.Now.ToString("HH:mm") });
                        DBHelper.GetDBHelper().EjecutarUpdateTransaccionAddSQL(sentenciaSql, lista);
                        tx.Commit();
                        return true;
                    }
                    else
                        throw new ApplicationException("Ya se ha confirmado la asistencia");
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

        private bool ExisteTurno(int nroSocio, int id_turno, string restriccion)
        {
            var sentenciaSql = $"SELECT nroSocio FROM Asistencias WHERE nroSocio = {nroSocio} AND id_turno = {id_turno} AND CONVERT(VARCHAR(10), fecha, 103) = CONVERT(VARCHAR(10), GETDATE(), 103) ";
            sentenciaSql += restriccion;
            var tablaResultado = DBHelper.GetDBHelper().ConsultaDuranteTransaccion(sentenciaSql);
            if (tablaResultado.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        public bool MarcarEgreso(int nroSocio, int id_turno)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    if (ExisteTurno(nroSocio, id_turno, " AND hora_egreso IS NULL AND hora_ingreso IS NOT NULL"))
                    {
                        var sentenciaSql = "UPDATE Asistencias SET hora_egreso = @hora_egreso " +
                        "WHERE nroSocio = @nroSocio AND id_turno = @id_turno AND CONVERT(VARCHAR(10), fecha, 103) = CONVERT(VARCHAR(10), GETDATE(), 103)";
                        var lista = new List<Parametro>();
                        lista.Add(new Parametro { NombreColumna = "@nroSocio", Valor = nroSocio });
                        lista.Add(new Parametro { NombreColumna = "@id_turno", Valor = id_turno });
                        lista.Add(new Parametro { NombreColumna = "@hora_egreso", Valor = DateTime.Now.ToString("HH:mm") });
                        DBHelper.GetDBHelper().EjecutarUpdateTransaccionAddSQL(sentenciaSql, lista);
                        tx.Commit();
                        return true;
                    }
                    else
                        throw new ApplicationException("Ya se ha marcado el egreso");
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

        public bool EliminarAsistencia(int nroSocio, int id_turno)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = "DELETE FROM Asistencias WHERE nroSocio = @nroSocio AND id_turno = @id_turno " +
                        "AND CONVERT(VARCHAR(10), fecha, 103) = CONVERT(VARCHAR(10), GETDATE(), 103)";
                    var lista = new List<Parametro>();
                    lista.Add(new Parametro { NombreColumna = "@nroSocio", Valor = nroSocio });
                    lista.Add(new Parametro { NombreColumna = "@id_turno", Valor = id_turno });
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionAddSQL(sentenciaSql, lista);
                    tx.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    tx.Rollback();
                    return false;
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }

        public bool ValidarExistenciaAsistencia(int nroSocio, int id_turno, DateTime fecha)
        {
            var sentenciaSql = $"SELECT nroSocio FROM Asistencias WHERE nroSocio = {nroSocio} AND id_turno = {id_turno} AND CONVERT(VARCHAR(10), fecha, 103) = CONVERT(VARCHAR(10), '{fecha}', 103)";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaDuranteTransaccion(sentenciaSql);
            if (tablaResultado.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        public bool RegistrarAsistencia(Asistencia a)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    if (!ValidarExistenciaAsistencia(a.Socio.NroSocio, a.Turno.Id_Turno, a.Fecha))
                    {
                        var sentenciaSql = "INSERT INTO Asistencias (id_actividad, nroSocio, id_turno, fecha) " +
                            "VALUES (@id_actividad, @nroSocio, @id_turno, @fecha)";
                        var lista = new List<Parametro>();
                        lista.Add(new Parametro { NombreColumna = "@id_actividad", Valor = a.Actividad.Id_Actividad });
                        lista.Add(new Parametro { NombreColumna = "@nroSocio", Valor = a.Socio.NroSocio });
                        lista.Add(new Parametro { NombreColumna = "@id_turno", Valor = a.Turno.Id_Turno });
                        lista.Add(new Parametro { NombreColumna = "@fecha", Valor = a.Fecha.ToString("yyyy/dd/MM") });
                        DBHelper.GetDBHelper().EjecutarTransaccionAddSQL(sentenciaSql, lista);
                        tx.Commit();
                        return true;
                    }
                    else
                        throw new ApplicationException("Ya se ha cargado la asistencia");
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