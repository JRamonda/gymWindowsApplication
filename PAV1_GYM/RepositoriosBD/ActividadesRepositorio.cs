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
    public class ActividadesRepositorio
    {
        public static bool ValidarExistenciaActividad(string nombre)
        {
            var sentenciaSql = $"SELECT nombre FROM Actividades WHERE nombre = '{nombre}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaDuranteTransaccion(sentenciaSql);
            if (tablaResultado.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        private Actividad Mapear(DataRow row)
        {
            var actividad = new Actividad();
            actividad.Id_Actividad = Convert.ToInt32(row["Id_Actividad"]);
            actividad.Nombre = row["Nombre"].ToString();
            actividad.Descripcion = row["Descripcion"].ToString();
            actividad.Precio = float.Parse(row["Precio"].ToString());
            actividad.Estado = row["Estado"].ToString() == "S";
            var turno = MapearTurno(row);
            if (turno != null)
                actividad.Turnos.Add(turno);
            return actividad;
        }

        private Turno MapearTurno(DataRow row)
        {
            if (!row.IsNull("Id_Turno"))
            {
                var turno = new Turno
                {
                    Id_Turno = Convert.ToInt32(row["Id_Turno"]),
                    Nombre = row["NombreTurno"].ToString(),
                    Dia = row["Dia"].ToString()
                };
                return turno;
            }
            return null;
        }

        public List<Actividad> GetActividades()
        {
            var actividades = new List<Actividad>();
            var sentenciaSql = $"SELECT * FROM Actividades";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var actividad = new Actividad();
                actividad.Id_Actividad = Convert.ToInt32(fila["id_actividad"]);
                actividad.Nombre = fila["nombre"].ToString();
                actividad.Descripcion = fila["descripcion"].ToString();
                actividad.Precio = float.Parse(fila["precio"].ToString());
                actividad.Estado = fila["estado"].ToString() == "S";
                actividades.Add(actividad);
            }
            return actividades;
        }

        public Actividad ObtenerActividad(int id_actividad)
        {
            var sentenciaSql = "SELECT a.*, t.id_turno, t.Nombre as NombreTurno, t.dia FROM Actividades a LEFT JOIN Actividades_X_Turnos at ON a.id_actividad = at.id_actividad " +
                $"LEFT JOIN Turnos t ON at.id_turno = t.id_turno WHERE a.id_actividad = {id_actividad}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count >= 1)
            {
                var actividad = Mapear(tablaResultado.Rows[0]);
                int count = 0;
                foreach (DataRow row in tablaResultado.Rows)
                {
                    if (count != 0)
                    {
                        var turno = MapearTurno(row);
                        if (turno != null)
                        {
                            bool band = false;
                            foreach (var t in actividad.Turnos)
                            {
                                if (t.Id_Turno == turno.Id_Turno)
                                    band = true;
                            }
                            if (!band)
                                actividad.Turnos.Add(turno);
                        }
                    }
                    else
                        count += 1;
                }
                return actividad;
            }
            else
                throw new ApplicationException("La actividad no existe, verifique el nombre");
        }


        public List<Actividad> ObtenerActividades(Actividad a)
        {
            List<Actividad> actividades = new List<Actividad>();
            var sentenciaSql = "SELECT a.*, t.id_turno, t.Nombre as NombreTurno, t.dia FROM Actividades a LEFT JOIN Actividades_X_Turnos at ON a.id_actividad = at.id_actividad " +
                "LEFT JOIN Turnos t ON at.id_turno = t.id_turno WHERE a.nombre LIKE '%%'";
            var estado = a.Estado ? "S" : "N";
            if (a.Id_Actividad != 0)
                sentenciaSql += $" AND a.id_actividad = {a.Id_Actividad}";
            if (a.Nombre != "")
                sentenciaSql += $" AND a.nombre LIKE '%{a.Nombre}%'";
            sentenciaSql += $" AND a.estado = '{estado}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count > 0)
            {
                int id_actividad = 0;
                var actividad2 = new Actividad();
                foreach (DataRow row in tabla.Rows)
                {
                    var actividad = Mapear(row);
                    if (actividad.Id_Actividad != id_actividad)
                    {
                        actividad2 = actividad;
                        actividades.Add(actividad2);
                        id_actividad = actividad.Id_Actividad;
                    }
                    else
                    {
                        var turno = MapearTurno(row);
                        if (turno != null)
                        {
                            bool band = false;
                            foreach (var t in actividad2.Turnos)
                            {
                                if (t.Id_Turno == turno.Id_Turno)
                                    band = true;
                            }
                            if (!band)
                            {
                                actividad2.Turnos.Add(turno);
                            }
                                
                        }
                    }
                }
            }
            return actividades;
        }

        public List<Actividad> ObtenerActividadesSocio(int nroSocio)
        {
            List<Actividad> actividades = new List<Actividad>();
            var sentenciaSql = "SELECT a.*, t.id_turno, t.Nombre as NombreTurno, t.dia FROM Actividades a LEFT JOIN Actividades_X_Turnos at ON a.id_actividad = at.id_actividad " +
                "LEFT JOIN Turnos t ON at.id_turno = t.id_turno LEFT JOIN Actividades_Y_Planes_X_Socios aps ON a.id_actividad = aps.id_actividad " +
                $"LEFT JOIN Socios s ON aps.nroSocio = s.nroSocio WHERE s.nroSocio = {nroSocio}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count > 0)
            {
                int id_actividad = 0;
                var actividad2 = new Actividad();
                foreach (DataRow row in tabla.Rows)
                {
                    var actividad = Mapear(row);
                    if (actividad.Id_Actividad != id_actividad)
                    {
                        actividad2 = actividad;
                        actividades.Add(actividad2);
                        id_actividad = actividad.Id_Actividad;
                    }
                    else
                    {
                        var turno = MapearTurno(row);
                        if (turno != null)
                        {
                            bool band = false;
                            foreach (var t in actividad2.Turnos)
                            {
                                if (t.Id_Turno == turno.Id_Turno)
                                    band = true;
                            }
                            if (!band)
                            {
                                actividad2.Turnos.Add(turno);
                            }

                        }
                    }
                }
            }
            return actividades;
        }

        public bool RegistrarActividad(Actividad a, List<int> idTurnos)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    if (!ValidarExistenciaActividad(a.Nombre))
                    {
                        var precio = a.Precio.ToString().Replace(',', '.');
                        var sentenciaSQL = $" INSERT INTO Actividades (nombre, descripcion, precio, estado) VALUES ('{a.Nombre}', '{a.Descripcion}', {precio}, 'S') ";
                        sentenciaSQL += " DECLARE @id_actividad int " +
                                $"SET @id_actividad = (SELECT SCOPE_IDENTITY()) ";
                        foreach (var id in idTurnos)
                        {
                            sentenciaSQL += $" INSERT INTO Actividades_X_Turnos (id_actividad, id_turno) VALUES (@id_actividad, {id}) ";
                        }
                        var filasAfectadas = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sentenciaSQL);
                        tx.Commit();
                        return true;
                    }
                    else
                        throw new ApplicationException("La actividad ya existe");
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

        public bool EliminarActividad(int id_actividad)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = $"DELETE FROM Actividades WHERE id_actividad = {id_actividad}" +
                        $" DELETE FROM Actividades_X_Turnos WHERE id_actividad = {id_actividad}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sentenciaSql);
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

        public bool ModificarEstadoActividad(Actividad a)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var estado = a.Estado ? "S" : "N";
                    var sentenciaSql = $"UPDATE Actividades SET estado='{estado}' WHERE nombre= '{a.Nombre}'";
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

        public bool ModificarActividad(Actividad a, List<int> idTurnos)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var precio = a.Precio.ToString().Replace(',', '.');
                    var sentenciaSql = "UPDATE Actividades SET nombre = @nombre, descripcion = @descripcion, precio = @precio, @estado = @estado WHERE id_actividad = @id_actividad";
                    sentenciaSql += " DELETE FROM Actividades_X_Turnos WHERE id_actividad = @id_actividad";
                    foreach (var id in idTurnos)
                    {
                        sentenciaSql += $" INSERT INTO Actividades_X_Turnos (id_actividad, id_turno) VALUES (@id_actividad, {id}) ";
                    }
                    var lista = new List<Parametro>();
                    lista.Add(new Parametro { NombreColumna = "@id_actividad", Valor = a.Id_Actividad });
                    lista.Add(new Parametro { NombreColumna = "@nombre", Valor = a.Nombre });
                    lista.Add(new Parametro { NombreColumna = "@descripcion", Valor = a.Descripcion });
                    lista.Add(new Parametro { NombreColumna = "@precio", Valor = precio });
                    lista.Add(new Parametro { NombreColumna = "@estado", Valor = 'S' });
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
