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
    public class EmpleadosRepositorio
    {
        public Empleado LoginBD(Empleado usuarioIngresado)
        {
            //SQL no detecta entre mayuscula y minusculas
            Empleado usuarioResultado = null;
            var sentenciaSql = $"SELECT * FROM Empleados e JOIN Perfiles p ON e.Id_Perfil = p.Id_Perfil WHERE e.LegajoEmpleado = {usuarioIngresado.LegajoEmpleado} AND e.Password = '{usuarioIngresado.Password}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count == 1)
            {
                var row = tablaResultado.Rows[0];
                usuarioResultado = new Empleado();
                usuarioResultado.LegajoEmpleado = Convert.ToInt32(row["LegajoEmpleado"]);
                var perfil = new Perfil();
                perfil.Id_Perfil = Convert.ToInt32(row["Id_Perfil"]);
                perfil.Nombre = row["Nombre"].ToString();
                usuarioResultado.Perfil = perfil;
                usuarioResultado.Nombre = row["Nombre"].ToString();
                usuarioResultado.Password = row["Password"].ToString();
                usuarioResultado.Email = row["Email"].ToString();
                usuarioResultado.Estado = row["Estado"].ToString() == "S";
            }
            return usuarioResultado;
        }

        private bool ValidarExistenciaEmpleado(string nroDoc, int tipoDoc)
        {
            var sentenciaSql = $"SELECT nroDoc FROM Empleados WHERE nroDoc = '{nroDoc}' AND id_tipoDoc = {tipoDoc}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaDuranteTransaccion(sentenciaSql);
            if (tablaResultado.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        public Empleado ObtenerDatosEmpleado(string instruccion)
        {
            var sentenciaSql = "SELECT e.*, pe.Nombre as NombrePerfil, td.Nombre as NombreDoc, se.Nombre as NombreSexo, c.nombre as NombreCiudad, p.id_provincia as Id_Provincia, " +
                "p.Nombre as NombreProvincia, ate.id_actividad as Id_Actividad, a.nombre as NombreActividad,a.descripcion as Descripcion, a.precio as Precio, a.estado as EstadoActividad, " +
                "ate.id_turno as Id_Turno, t.nombre as NombreTurno, t.hora_Inicio as Hora_Inicio, t.hora_Fin as Hora_Fin, t.dia as Dia, t.estado as EstadoTurno " +
                "FROM Empleados e JOIN Tipos_Documentos td ON e.id_tipoDoc = td.id_tipoDoc LEFT JOIN Sexos se ON e.id_sexo = se.id_sexo " +
                "LEFT JOIN Ciudades c ON e.id_ciudad = c.id_ciudad LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia JOIN Perfiles pe ON e.id_perfil = pe.id_perfil LEFT JOIN Actividades_Y_Turnos_X_Empleados ate ON " +
                "e.legajoEmpleado = ate.legajoEmpleado LEFT JOIN Actividades a ON ate.id_actividad = a.id_actividad LEFT JOIN Turnos t ON ate.id_turno = t.id_turno " +
                "WHERE ";
            sentenciaSql += instruccion;
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count >= 1)
            {
                var empleado = Mapear(tablaResultado.Rows[0]);
                int count = 0;
                foreach (DataRow fila in tablaResultado.Rows)
                {
                    if (count != 0)
                    {
                        var actXtur = MapearActXTur(fila);
                        empleado.ActividadesXTurnos.Add(actXtur);
                    }
                    else
                        count += 1;
                }
                return empleado;
            }
            else
                throw new ApplicationException("El empleado no existe, verifique el tipo de documento");
        }

        public Empleado ObtenerEmpleado(string nroDoc, int tipoDoc)
        {
            var instruccion = $"e.nroDoc = '{nroDoc}' AND e.id_TipoDoc = {tipoDoc}";
            var empleado = ObtenerDatosEmpleado(instruccion);
            return empleado;
        }

        public Empleado ObtenerEmpleadoLeg(int legajo)
        {
            var instruccion = $"e.LegajoEmpleado = {legajo}";
            var empleado = ObtenerDatosEmpleado(instruccion);
            return empleado;
        }

        private ActividadXTurno MapearActXTur(DataRow row)
        {
            var actXtur = new ActividadXTurno();
            var actividad = new Actividad
            {
                Id_Actividad = int.Parse(row["Id_Actividad"].ToString()),
                Nombre = row["NombreActividad"].ToString()
            };
            var turno = new Turno
            {
                Id_Turno = int.Parse(row["Id_Turno"].ToString()),
                Nombre = row["NombreTurno"].ToString()
            };
            actXtur.Actividad = actividad;
            actXtur.Turno = turno;
            return actXtur;
        }
 
        public List<Empleado> Obtener(Empleado e)
        {
            List<Empleado> empleados = new List<Empleado>();
            var sentenciaSql = "SELECT e.*, pe.Nombre as NombrePerfil, td.Nombre as NombreDoc, se.Nombre as NombreSexo, c.nombre as NombreCiudad, p.id_provincia as Id_Provincia, " +
                "p.Nombre as NombreProvincia, ate.id_actividad as Id_Actividad, a.nombre as NombreActividad,a.descripcion as Descripcion, a.precio as Precio, a.estado as EstadoActividad, " +
                "ate.id_turno as Id_Turno, t.nombre as NombreTurno, t.hora_Inicio as Hora_Inicio, t.hora_Fin as Hora_Fin, t.dia as Dia, t.estado as EstadoTurno " +
                "FROM Empleados e JOIN Tipos_Documentos td ON e.id_tipoDoc = td.id_tipoDoc LEFT JOIN Sexos se ON e.id_sexo = se.id_sexo " +
                "LEFT JOIN Ciudades c ON e.id_ciudad = c.id_ciudad LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia JOIN Perfiles pe ON e.id_perfil = pe.id_perfil LEFT JOIN Actividades_Y_Turnos_X_Empleados ate ON " +
                "e.legajoEmpleado = ate.legajoEmpleado LEFT JOIN Actividades a ON ate.id_actividad = a.id_actividad LEFT JOIN Turnos t ON ate.id_turno = t.id_turno " +
                "WHERE p.nombre LIKE '%%'";
            var estado = e.Estado ? "S" : "N";
            if (e.NroDocumento != "")
                sentenciaSql += $" AND e.nroDoc LIKE '%{e.NroDocumento}%'";
            if (e.TipoDocumento.Id_TipoDoc != 0)
                sentenciaSql += $" AND e.id_tipoDoc = {e.TipoDocumento.Id_TipoDoc}";
            sentenciaSql += $" AND e.estado = '{estado}'";
            sentenciaSql += " ORDER BY e.LegajoEmpleado";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            int legajo = 0;
            foreach (DataRow fila in tabla.Rows)
            {
                var empleado = Mapear(fila);
                if (empleado.LegajoEmpleado != legajo)
                {
                    empleados.Add(empleado);
                }
                else
                {
                    foreach (Empleado emp in empleados)
                    {
                        if (emp.LegajoEmpleado == legajo)
                        {
                            var actXtur = MapearActXTur(fila);
                            emp.ActividadesXTurnos.Add(actXtur);
                        }
                    }
                }
                legajo = empleado.LegajoEmpleado;
            }
            return empleados;
        }

        private Empleado Mapear(DataRow row)
        {
            int nroCalle;
            int.TryParse(row["NroCalle"].ToString(), out nroCalle);
            DateTime fechaIngreso;
            DateTime.TryParse(row["FechaIngreso"].ToString(), out fechaIngreso);
            DateTime fechaNacimiento;
            DateTime.TryParse(row["FechaNacimiento"].ToString(), out fechaNacimiento);
            float precio;
            float.TryParse(row["Precio"].ToString(), out precio);
            var empleado = new Empleado();
            empleado.LegajoEmpleado = Convert.ToInt32(row["LegajoEmpleado"]);
            empleado.NroDocumento = row["NroDoc"].ToString();
            empleado.Nombre = row["Nombre"].ToString();
            empleado.Apellido = row["Apellido"].ToString();
            empleado.Calle = row["Calle"].ToString();
            empleado.NroCalle = nroCalle;
            empleado.CodigoPostal = row["CodigoPostal"].ToString();
            empleado.Telefono = row["Telefono"].ToString();
            empleado.Email = row["Email"].ToString();
            empleado.FechaIngreso = fechaIngreso;
            empleado.FechaNacimiento = fechaNacimiento;
            DateTime? FechaBaja = row["FechaBaja"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FechaBaja"]);
            empleado.FechaBaja = FechaBaja;
            empleado.Estado = row["Estado"].ToString() == "S";
            if (!row.IsNull("id_TipoDoc"))
                empleado.TipoDocumento = new TipoDocumento
                {
                    Id_TipoDoc = int.Parse(row["id_tipoDoc"].ToString()),
                    Nombre = row["NombreDoc"].ToString()
                };
            if (!row.IsNull("Id_Sexo"))
                empleado.Sexo = new Sexo
                {
                    Id_Sexo = int.Parse(row["Id_Sexo"].ToString()),
                    Nombre = row["NombreSexo"].ToString()
                };
            if (!row.IsNull("Id_Ciudad"))
            {
                empleado.Ciudad = new Ciudad
                {
                    Id_Ciudad = int.Parse(row["Id_Ciudad"].ToString()),
                    Nombre = row["NombreCiudad"].ToString()
                };
                empleado.Ciudad.Provincia = new Provincia
                {
                    Id_Provincia = int.Parse(row["Id_Provincia"].ToString()),
                    Nombre = row["NombreProvincia"].ToString()
                };
            }
            if (row.Table.Columns.Contains("Id_Perfil"))
                empleado.Perfil = new Perfil
                {
                    Id_Perfil = int.Parse(row["Id_Perfil"].ToString()),
                    Nombre = row["NombrePerfil"].ToString()
                };
            if (!row.IsNull("Id_Actividad"))
            {
                var actividadXTurno = new ActividadXTurno();
                var actividad = new Actividad();
                var turno = new Turno();
                actividad.Id_Actividad = int.Parse(row["Id_Actividad"].ToString());
                actividad.Nombre = row["NombreActividad"].ToString();
                actividad.Descripcion = row["Descripcion"].ToString();
                actividad.Precio = precio;
                actividad.Estado = row["EstadoActividad"].ToString() == "S";
                turno.Id_Turno = int.Parse(row["Id_Turno"].ToString());
                turno.Nombre = row["NombreTurno"].ToString();
                turno.Hora_Inicio = DateTime.Parse(row["Hora_Inicio"].ToString());
                turno.Hora_Fin = DateTime.Parse(row["Hora_Fin"].ToString());
                turno.Dia = row["Dia"].ToString();
                turno.Estado = row["EstadoTurno"].ToString() == "S";
                actividadXTurno.Actividad = actividad;
                actividadXTurno.Turno = turno;
                empleado.ActividadesXTurnos.Add(actividadXTurno);
            }
            return empleado;
        }

        public bool RegistrarEmpleado(Empleado e)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    if (!ValidarExistenciaEmpleado(e.NroDocumento, e.TipoDocumento.Id_TipoDoc))
                    {
                        var sentenciaSql = $"INSERT INTO Empleados (id_perfil, nroDoc, id_tipoDoc, nombre, apellido, fechaNacimiento, id_sexo, calle, nroCalle, id_ciudad, codigoPostal," +
                        $" telefono, email, fechaIngreso, estado) VALUES(@id_perfil, @nroDoc, @id_tipoDoc, @nombre, @apellido, @fechaNacimiento, @id_sexo, @calle, @nroCalle, @id_ciudad," +
                        $" @codigoPostal, @telefono, @email, @fechaAlta, @estado)";
                        var lista = new List<Parametro>();
                        lista.Add(new Parametro { NombreColumna = "@id_perfil", Valor = e.Perfil.Id_Perfil });
                        lista.Add(new Parametro { NombreColumna = "@nroDoc", Valor = e.NroDocumento });
                        lista.Add(new Parametro { NombreColumna = "@id_tipoDoc", Valor = e.TipoDocumento.Id_TipoDoc });
                        lista.Add(new Parametro { NombreColumna = "@nombre", Valor = e.Nombre });
                        lista.Add(new Parametro { NombreColumna = "@apellido", Valor = e.Apellido });
                        lista.Add(new Parametro { NombreColumna = "@fechaNacimiento", Valor = e.FechaNacimiento });
                        lista.Add(new Parametro { NombreColumna = "@id_sexo", Valor = e.Sexo.Id_Sexo });
                        lista.Add(new Parametro { NombreColumna = "@calle", Valor = e.Calle });
                        lista.Add(new Parametro { NombreColumna = "@nroCalle", Valor = e.NroCalle });
                        lista.Add(new Parametro { NombreColumna = "@id_ciudad", Valor = e.Ciudad.Id_Ciudad });
                        lista.Add(new Parametro { NombreColumna = "@codigoPostal", Valor = e.CodigoPostal });
                        lista.Add(new Parametro { NombreColumna = "@telefono", Valor = e.Telefono });
                        lista.Add(new Parametro { NombreColumna = "@email", Valor = e.Email });
                        lista.Add(new Parametro { NombreColumna = "@fechaAlta", Valor = DateTime.Today });
                        lista.Add(new Parametro { NombreColumna = "@estado", Valor = 'S' });
                        if (e.Perfil.Id_Perfil != 4 && e.Perfil.Id_Perfil != 5)
                        {
                            sentenciaSql += " DECLARE @legajoEmpleado int " +
                                $"SET @legajoEmpleado = (SELECT SCOPE_IDENTITY()) " +
                                $"UPDATE Empleados SET password = @legajoEmpleado WHERE legajoEmpleado = @legajoEmpleado ";
                        }
                        if (e.Perfil.Id_Perfil == 4)
                        {
                            sentenciaSql += " DECLARE @legajoEmpleado int " +
                                $"SET @legajoEmpleado = (SELECT SCOPE_IDENTITY()) ";
                            foreach (ActividadXTurno at in e.ActividadesXTurnos)
                            {
                                sentenciaSql += $" INSERT INTO Actividades_Y_Turnos_X_Empleados (id_actividad, id_turno, legajoEmpleado) VALUES ({at.Actividad.Id_Actividad}, {at.Turno.Id_Turno}, @legajoEmpleado) ";
                            }
                        }
                        var filasAfectadas = DBHelper.GetDBHelper().EjecutarTransaccionAddSQL(sentenciaSql, lista);
                        tx.Commit();
                        return true;
                    }
                    else
                        throw new ApplicationException("El empleado ya existe");
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

        public bool EliminarEmpleado(int legajoEmpleado)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = $"DELETE FROM Empleados WHERE legajoEmpleado = {legajoEmpleado}";
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

        public bool ModificarEstadoEmpleado(Empleado e)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var estado = e.Estado ? "S" : "N";
                    var sentenciaSql = $"UPDATE Empleados SET estado = '{estado}', fechaBaja={System.Data.SqlTypes.SqlDateTime.Null}, fechaIngreso='{DateTime.Today}' WHERE nroDoc = '{e.NroDocumento}' AND id_tipoDoc = {e.TipoDocumento.Id_TipoDoc}";
                    if (!e.Estado)
                        sentenciaSql = $"UPDATE Empleados SET estado = '{estado}', fechaBaja='{DateTime.Today}' WHERE nroDoc = '{e.NroDocumento}' AND id_tipoDoc = {e.TipoDocumento.Id_TipoDoc}";
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

        public bool CambiarContraseña(string password, int legajoEmpleado)
        {
            var sentenciaSql = $"UPDATE Empleados SET password = '{password}' WHERE legajoEmpleado = {legajoEmpleado}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public bool ModificarEmpleado(Empleado e, int Legajo)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = "UPDATE Empleados SET id_perfil = @id_perfil, nroDoc = @nroDoc, id_tipoDoc = @id_tipoDoc, nombre = @nombre, apellido = @apellido, " +
                    "fechaNacimiento = @fechaNacimiento, id_sexo = @id_sexo, calle = @calle, nroCalle = @nroCalle, id_ciudad = @id_ciudad, codigoPostal = @codigoPostal, " +
                    "telefono = @telefono, email = @email, fechaBaja = @fechaBaja, estado = @estado WHERE legajoEmpleado = @legajoEmpleado";
                    var lista = new List<Parametro>();
                    lista.Add(new Parametro { NombreColumna = "@legajoEmpleado", Valor = Legajo });
                    lista.Add(new Parametro { NombreColumna = "@id_perfil", Valor = e.Perfil.Id_Perfil });
                    lista.Add(new Parametro { NombreColumna = "@nroDoc", Valor = e.NroDocumento });
                    lista.Add(new Parametro { NombreColumna = "@id_tipoDoc", Valor = e.TipoDocumento.Id_TipoDoc });
                    lista.Add(new Parametro { NombreColumna = "@nombre", Valor = e.Nombre });
                    lista.Add(new Parametro { NombreColumna = "@apellido", Valor = e.Apellido });
                    lista.Add(new Parametro { NombreColumna = "@fechaNacimiento", Valor = e.FechaNacimiento });
                    lista.Add(new Parametro { NombreColumna = "@id_sexo", Valor = e.Sexo.Id_Sexo });
                    lista.Add(new Parametro { NombreColumna = "@calle", Valor = e.Calle });
                    lista.Add(new Parametro { NombreColumna = "@nroCalle", Valor = e.NroCalle });
                    lista.Add(new Parametro { NombreColumna = "@id_ciudad", Valor = e.Ciudad.Id_Ciudad });
                    lista.Add(new Parametro { NombreColumna = "@codigoPostal", Valor = e.CodigoPostal });
                    lista.Add(new Parametro { NombreColumna = "@telefono", Valor = e.Telefono });
                    lista.Add(new Parametro { NombreColumna = "@email", Valor = e.Email });
                    lista.Add(new Parametro { NombreColumna = "@fechaBaja", Valor = System.Data.SqlTypes.SqlDateTime.Null });
                    lista.Add(new Parametro { NombreColumna = "@estado", Valor = 'S' });
                    sentenciaSql += $" DELETE FROM Actividades_Y_Turnos_X_Empleados WHERE legajoEmpleado = {Legajo}";
                    foreach (ActividadXTurno at in e.ActividadesXTurnos)
                    {
                        sentenciaSql += $" INSERT INTO Actividades_Y_Turnos_X_Empleados (id_actividad, id_turno, legajoEmpleado) VALUES ({at.Actividad.Id_Actividad}, {at.Turno.Id_Turno}, {Legajo})";
                    }
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