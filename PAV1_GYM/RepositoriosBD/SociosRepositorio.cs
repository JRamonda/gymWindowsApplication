using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PAV1_GYM.RepositoriosBD
{
    public class SociosRepositorio
    {
        public static bool ValidarExistenciaSocio(string nroDoc, int tipoDoc)
        {
            var sentenciaSql = $"SELECT nroDoc FROM Socios WHERE nroDoc = '{nroDoc}' AND id_tipoDoc = {tipoDoc}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaDuranteTransaccion(sentenciaSql);
            if (tablaResultado.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        private Socio Mapear(DataRow row)
        {
            var socio = new Socio();
            socio.NroSocio = Convert.ToInt32(row["NroSocio"]);
            socio.NroDocumento = row["NroDoc"].ToString();
            socio.Nombre = row["Nombre"].ToString();
            socio.Apellido = row["Apellido"].ToString();
            if (row.Table.Columns.Contains("FechaNacimiento"))
            {
                socio.FechaNacimiento = DateTime.Parse(row["FechaNacimiento"].ToString());
                socio.Altura = int.Parse(row["Altura"].ToString());
                socio.Peso = float.Parse(row["Peso"].ToString());
                socio.Calle = row["Calle"].ToString();
                socio.NroCalle = int.Parse(row["NroCalle"].ToString());
                socio.CodigoPostal = row["CodigoPostal"].ToString();
                socio.Telefono = row["Telefono"].ToString();
                socio.Email = row["Email"].ToString();
                socio.AntecedenteMedico = row["AntecedenteMedico"].ToString();
                socio.Estado = row["Estado"].ToString() == "S";
                DateTime? FechaBaja = row["FechaBaja"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FechaBaja"]);
                socio.FechaBaja = FechaBaja;
                socio.Ciudad = new Ciudad
                {
                    Id_Ciudad = int.Parse(row["Id_Ciudad"].ToString()),
                    Nombre = row["NombreCiudad"].ToString()
                };
                socio.Ciudad.Provincia = new Provincia
                {
                    Id_Provincia = int.Parse(row["Id_Provincia"].ToString()),
                    Nombre = row["NombreProvincia"].ToString()
                };
                socio.Empleado = new Empleado
                {
                    LegajoEmpleado = int.Parse(row["LegajoEmpleado"].ToString()),
                    Nombre = row["NombreEmpleado"].ToString(),
                    Apellido = row["ApellidoEmpleado"].ToString()
                };
            }
            if (row.Table.Columns.Contains("FechaAlta"))
                socio.FechaAlta = Convert.ToDateTime(row["FechaAlta"].ToString());
            socio.TipoDocumento = new TipoDocumento
            {
                Id_TipoDoc = int.Parse(row["Id_TipoDoc"].ToString()),
                Nombre = row["NombreDoc"].ToString()
            };
            socio.Sexo = new Sexo
            {
                Id_Sexo = int.Parse(row["Id_Sexo"].ToString()),
                Nombre = row["NombreSexo"].ToString()
            };
            var objetivo = MapearObjetivos(row);
            if (objetivo != null)
                socio.Objetivos.Add(objetivo);
            var actividad = MapearActividades(row);
            if (actividad != null)
                socio.Actividades.Add(actividad);
            var plan = MapearPlanes(row);
            if (plan != null)
                socio.Planes.Add(plan);
            return socio;
        }

        private Objetivo MapearObjetivos(DataRow row)
        {
            if (!row.IsNull("Id_Objetivo"))
            {
                var objetivo = new Objetivo
                {
                    Id_Objetivo = int.Parse(row["Id_Objetivo"].ToString()),
                    Nombre = row["NombreObjetivo"].ToString(),
                    Descripcion = row["DescripcionObjetivo"].ToString()
                };
                return objetivo;
            }
            return null;
        }

        private Actividad MapearActividades(DataRow row)
        {
            if (!row.IsNull("Id_Actividad"))
            {
                var actividad = new Actividad
                {
                    Id_Actividad = Convert.ToInt32(row["Id_Actividad"]),
                    Nombre = row["NombreActividad"].ToString()
                };
                return actividad;
            }
            return null;
        }

        private Plan MapearPlanes(DataRow row)
        {
            if (!row.IsNull("Id_Plan"))
            {
                var plan = new Plan
                {
                    Id_Plan = Convert.ToInt32(row["Id_Plan"]),
                    Nombre = row["NombrePlan"].ToString()
                };
                return plan;
            }
            return null;
        }

        public Socio ObtenerDatosSocio(string instruccion)
        {
            var sentenciaSql = "SELECT s.*, td.Nombre as NombreDoc, se.Nombre as NombreSexo, c.nombre as NombreCiudad, e.Nombre as NombreEmpleado, e.Apellido as ApellidoEmpleado, o.Id_Objetivo, o.Nombre as NombreObjetivo, o.Descripcion as DescripcionObjetivo, " +
                "p.id_provincia as Id_Provincia, p.Nombre as NombreProvincia, a.Id_Actividad, a.Nombre as NombreActividad, pl.Id_Plan, pl.Nombre as NombrePlan " +
                "FROM Socios s JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc JOIN Sexos se ON s.id_sexo = se.id_sexo JOIN Ciudades c ON s.id_ciudad = c.id_ciudad LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia " +
                "JOIN Empleados e ON s.legajoEmpleado = e.legajoEmpleado LEFT JOIN Objetivos_X_Socios os ON s.nroSocio = os.nroSocio LEFT JOIN Objetivos o ON os.id_objetivo = o.id_objetivo " +
                "LEFT JOIN Actividades_Y_Planes_X_Socios aps ON aps.nroSocio = s.nroSocio LEFT JOIN Actividades a ON aps.id_actividad = a.id_actividad LEFT JOIN Planes pl ON aps.id_plan = pl.id_plan WHERE ";
            sentenciaSql += instruccion;
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count >= 1)
            {
                var socio = Mapear(tablaResultado.Rows[0]);
                int count = 0;
                foreach (DataRow row in tablaResultado.Rows)
                {
                    if (count != 0)
                    {
                        var objetivo = MapearObjetivos(row);
                        if (objetivo != null)
                        {
                            bool band = false;
                            foreach (var ob in socio.Objetivos)
                            {
                                if (ob.Id_Objetivo == objetivo.Id_Objetivo)
                                    band = true;
                            }
                            if (!band)
                                socio.Objetivos.Add(objetivo);
                        }
                        var actividad = MapearActividades(row);
                        if (actividad != null)
                        {
                            bool band = false;
                            foreach (var ac in socio.Actividades)
                            {
                                if (ac.Id_Actividad == actividad.Id_Actividad)
                                    band = true;
                            }
                            if (!band)
                                socio.Actividades.Add(actividad);
                        }
                        var plan = MapearPlanes(row);
                        if (plan != null)
                        {
                            bool band = false;
                            foreach (var pl in socio.Planes)
                            {
                                if (pl.Id_Plan == plan.Id_Plan)
                                    band = true;
                            }
                            if (!band)
                                socio.Planes.Add(plan);
                        }
                    }
                    else
                        count += 1;
                }
                return socio;
            }
            else
                throw new ApplicationException("El socio no existe, verifique el tipo de documento");
        }

        public Socio ObtenerSocio(string nroDoc, int tipoDoc)
        {
            var instruccion = $"s.nroDoc = '{nroDoc}' AND s.id_TipoDoc = {tipoDoc}";
            var socio = ObtenerDatosSocio(instruccion);
            return socio;
        }

        public Socio ObtenerSocioNro(int nroSocio)
        {
            var instruccion = $"s.nroSocio = {nroSocio}";
            var socio = ObtenerDatosSocio(instruccion);
            return socio;
        }

        public List<Socio> Obtener(Socio s)
        {
            List<Socio> socios = new List<Socio>();
            var sentenciaSql = "SELECT s.*, td.Nombre as NombreDoc, se.Nombre as NombreSexo, c.nombre as NombreCiudad, e.Nombre as NombreEmpleado, e.Apellido as ApellidoEmpleado, o.Id_Objetivo, o.Nombre as NombreObjetivo, o.Descripcion as DescripcionObjetivo, " +
                "p.id_provincia as Id_Provincia, p.Nombre as NombreProvincia, a.Id_Actividad, a.Nombre as NombreActividad, pl.Id_Plan, pl.Nombre as NombrePlan " +
                "FROM Socios s JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc JOIN Sexos se ON s.id_sexo = se.id_sexo JOIN Ciudades c ON s.id_ciudad = c.id_ciudad LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia " +
                "JOIN Empleados e ON s.legajoEmpleado = e.legajoEmpleado LEFT JOIN Objetivos_X_Socios os ON s.nroSocio = os.nroSocio LEFT JOIN Objetivos o ON os.id_objetivo = o.id_objetivo " +
                "LEFT JOIN Actividades_Y_Planes_X_Socios aps ON aps.nroSocio = s.nroSocio LEFT JOIN Actividades a ON aps.id_actividad = a.id_actividad LEFT JOIN Planes pl ON aps.id_plan = pl.id_plan WHERE s.nombre LIKE '%%'";
            //hacer 2 consulta sql una con actividades planes y otra con objetivos
            if (!String.IsNullOrEmpty(s.NroDocumento))
                sentenciaSql += $" AND s.nroDoc LIKE '%{s.NroDocumento}%'";
            if (s.TipoDocumento != null && s.TipoDocumento.Id_TipoDoc != 0)
                sentenciaSql += $" AND s.id_tipoDoc = {s.TipoDocumento.Id_TipoDoc}";
            if (s.Nombre != "")
                sentenciaSql += $" AND s.Nombre LIKE '%{s.Nombre}%'";
            if (s.Apellido != "")
                sentenciaSql += $" AND s.Apellido LIKE '%{s.Apellido}%'";
            if (s.NroSocio != 0)
                sentenciaSql += $" AND s.NroSocio = {s.NroSocio}";
            var estado = s.Estado ? "S" : "N";
            sentenciaSql += $" AND s.estado = '{estado}'";
            sentenciaSql += " ORDER BY s.nroSocio";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count > 0)
            {
                int nroSocio = 0;
                var socio2 = new Socio();
                foreach (DataRow row in tabla.Rows)
                {
                    var socio = Mapear(row);
                    if (socio.NroSocio != nroSocio)
                    {
                        socio2 = socio;
                        socios.Add(socio2);
                        nroSocio = socio.NroSocio;
                    }
                    else
                    {
                        var objetivo = MapearObjetivos(row);
                        if (objetivo != null)
                        {
                            bool band = false;
                            foreach (var ob in socio2.Objetivos)
                            {
                                if (ob.Id_Objetivo == objetivo.Id_Objetivo)
                                    band = true;
                            }
                            if (!band)
                                socio2.Objetivos.Add(objetivo);
                        }
                        var actividad = MapearActividades(row);
                        if (actividad != null)
                        {
                            bool band = false;
                            foreach (var ac in socio2.Actividades)
                            {
                                if (ac.Id_Actividad == actividad.Id_Actividad)
                                    band = true;
                            }
                            if (!band)
                                socio2.Actividades.Add(actividad);
                        }                        
                        var plan = MapearPlanes(row);
                        if (plan != null)
                        {
                            bool band = false;
                            foreach (var pl in socio2.Planes)
                            {
                                if (pl.Id_Plan == plan.Id_Plan)
                                    band = true;
                            }
                            if (!band)
                                socio2.Planes.Add(plan);
                        }  
                    }
                }
            }
            return socios;
        }

        public List<Socio> ObtenerSociosConActividad(Socio s)
        {
            List<Socio> socios = new List<Socio>();
            var sentenciaSql = "SELECT s.*, td.Nombre as NombreDoc, se.Nombre as NombreSexo, c.nombre as NombreCiudad, e.Nombre as NombreEmpleado, e.Apellido as ApellidoEmpleado, o.Id_Objetivo, o.Nombre as NombreObjetivo, o.Descripcion as DescripcionObjetivo, " +
                "p.id_provincia as Id_Provincia, p.Nombre as NombreProvincia, a.Id_Actividad, a.Nombre as NombreActividad, pl.Id_Plan, pl.Nombre as NombrePlan " +
                "FROM Socios s JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc JOIN Sexos se ON s.id_sexo = se.id_sexo JOIN Ciudades c ON s.id_ciudad = c.id_ciudad LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia " +
                "JOIN Empleados e ON s.legajoEmpleado = e.legajoEmpleado LEFT JOIN Objetivos_X_Socios os ON s.nroSocio = os.nroSocio LEFT JOIN Objetivos o ON os.id_objetivo = o.id_objetivo " +
                "LEFT JOIN Actividades_Y_Planes_X_Socios aps ON aps.nroSocio = s.nroSocio LEFT JOIN Actividades a ON aps.id_actividad = a.id_actividad LEFT JOIN Planes pl ON aps.id_plan = pl.id_plan WHERE s.nombre LIKE '%%'";
            if (!String.IsNullOrEmpty(s.NroDocumento))
                sentenciaSql += $" AND s.nroDoc LIKE '%{s.NroDocumento}%'";
            if (s.TipoDocumento != null && s.TipoDocumento.Id_TipoDoc != 0)
                sentenciaSql += $" AND s.id_tipoDoc = {s.TipoDocumento.Id_TipoDoc}";
            if (s.Nombre != "")
                sentenciaSql += $" AND s.Nombre LIKE '%{s.Nombre}%'";
            if (s.Apellido != "")
                sentenciaSql += $" AND s.Apellido LIKE '%{s.Apellido}%'";
            if (s.NroSocio != 0)
                sentenciaSql += $" AND s.NroSocio = {s.NroSocio}";
            var estado = s.Estado ? "S" : "N";
            sentenciaSql += $" AND s.estado = '{estado}'";
            sentenciaSql += " ORDER BY s.nroSocio";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count > 0)
            {
                int nroSocio = 0;
                var socio2 = new Socio();
                foreach (DataRow row in tabla.Rows)
                {
                    var socio = Mapear(row);
                    if (socio.NroSocio != nroSocio)
                    {
                        socio2 = socio;
                        socios.Add(socio2);
                        nroSocio = socio.NroSocio;
                    }
                    else
                    {
                        var objetivo = MapearObjetivos(row);
                        if (objetivo != null)
                        {
                            bool band = false;
                            foreach (var ob in socio2.Objetivos)
                            {
                                if (ob.Id_Objetivo == objetivo.Id_Objetivo)
                                    band = true;
                            }
                            if (!band)
                                socio2.Objetivos.Add(objetivo);
                        }
                        var actividad = MapearActividades(row);
                        if (actividad != null)
                        {
                            bool band = false;
                            foreach (var ac in socio2.Actividades)
                            {
                                if (ac.Id_Actividad == actividad.Id_Actividad)
                                    band = true;
                            }
                            if (!band)
                                socio2.Actividades.Add(actividad);
                        }
                        var plan = MapearPlanes(row);
                        if (plan != null)
                        {
                            bool band = false;
                            foreach (var pl in socio2.Planes)
                            {
                                if (pl.Id_Plan == plan.Id_Plan)
                                    band = true;
                            }
                            if (!band)
                                socio2.Planes.Add(plan);
                        }
                    }
                }
            }
            return socios;
        }

        public bool RegistrarSocio(Socio s, int cantObj)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    if (!ValidarExistenciaSocio(s.NroDocumento, s.TipoDocumento.Id_TipoDoc))
                    {
                        var peso = s.Peso.ToString().Replace(',', '.');
                        var sentenciaSql = $"INSERT INTO Socios (nroDoc, id_tipoDoc, nombre, apellido, fechaNacimiento, id_sexo, altura, peso, calle, nroCalle, id_ciudad, codigoPostal, " +
                            $"telefono, email, fechaAlta, antecedenteMedico, legajoEmpleado, estado) VALUES (@nroDoc, @id_tipoDoc, @nombre, " +
                            $"@apellido, @fechaNacimiento, @id_sexo, @altura, @peso, @calle, @nroCalle, @id_ciudad, @codigoPostal, " +
                            $"@telefono, @email, @fechaAlta, @antecedenteMedico, @legajoEmpleado, @estado)";
                        var lista = new List<Parametro>();
                        lista.Add(new Parametro { NombreColumna = "@nroDoc", Valor = s.NroDocumento });
                        lista.Add(new Parametro { NombreColumna = "@id_tipoDoc", Valor = s.TipoDocumento.Id_TipoDoc });
                        lista.Add(new Parametro { NombreColumna = "@nombre", Valor = s.Nombre });
                        lista.Add(new Parametro { NombreColumna = "@apellido", Valor = s.Apellido });
                        lista.Add(new Parametro { NombreColumna = "@fechaNacimiento", Valor = s.FechaNacimiento });
                        lista.Add(new Parametro { NombreColumna = "@id_sexo", Valor = s.Sexo.Id_Sexo });
                        lista.Add(new Parametro { NombreColumna = "@altura", Valor = s.Altura });
                        lista.Add(new Parametro { NombreColumna = "@peso", Valor = peso });
                        lista.Add(new Parametro { NombreColumna = "@calle", Valor = s.Calle });
                        lista.Add(new Parametro { NombreColumna = "@nroCalle", Valor = s.NroCalle });
                        lista.Add(new Parametro { NombreColumna = "@id_ciudad", Valor = s.Ciudad.Id_Ciudad });
                        lista.Add(new Parametro { NombreColumna = "@codigoPostal", Valor = s.CodigoPostal });
                        lista.Add(new Parametro { NombreColumna = "@telefono", Valor = s.Telefono });
                        lista.Add(new Parametro { NombreColumna = "@email", Valor = s.Email });
                        lista.Add(new Parametro { NombreColumna = "@fechaAlta", Valor = s.FechaAlta });
                        lista.Add(new Parametro { NombreColumna = "@antecedenteMedico", Valor = s.AntecedenteMedico });
                        lista.Add(new Parametro { NombreColumna = "@legajoEmpleado", Valor = s.Empleado.LegajoEmpleado });
                        lista.Add(new Parametro { NombreColumna = "@estado", Valor = 'S' });
                        if (cantObj > 0)
                        {
                            sentenciaSql += $" DECLARE @nroSocio int " +
                                $"SET @nroSocio = (SELECT MAX(nroSocio) FROM Socios) ";
                            foreach (Objetivo objetivo in s.Objetivos)
                            {
                                sentenciaSql += $" INSERT INTO Objetivos_X_Socios (id_objetivo, nroSocio) VALUES ({objetivo.Id_Objetivo}, @nroSocio) ";
                            }
                        }
                        var filasAfectadas = DBHelper.GetDBHelper().EjecutarTransaccionAddSQL(sentenciaSql, lista);
                        tx.Commit();
                        return true;
                    }
                    else
                        throw new ApplicationException("El socio ya existe");
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

        public bool EliminarSocio(int nroSocio)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = $"DELETE FROM Socios WHERE nroSocio = {nroSocio} " +
                    $"DELETE FROM Objetivos_X_Socios WHERE nroSocio = {nroSocio} " +
                    $"DELETE FROM Actividades_Y_Planes_X_Socios WHERE nroSocio = {nroSocio}";
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

        public bool ModificarEstadoSocio(Socio s)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var estado = s.Estado ? "S" : "N";
                    var sentenciaSql = $"UPDATE Socios SET estado='{estado}', fechaBaja={System.Data.SqlTypes.SqlDateTime.Null}, fechaAlta='{DateTime.Today}' WHERE nroDoc = '{s.NroDocumento}' AND id_tipoDoc = {s.TipoDocumento.Id_TipoDoc}";
                    if (!s.Estado)
                        sentenciaSql = $"UPDATE Socios SET estado='{estado}', fechaBaja='{DateTime.Today}' WHERE nroDoc = '{s.NroDocumento}' AND id_tipoDoc = {s.TipoDocumento.Id_TipoDoc}";
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

        public string ModificarObjetivosSocio(Socio s, int NroSocio, string sentenciaSql)
        {
            sentenciaSql += $" DELETE FROM Objetivos_X_Socios WHERE nroSocio = {NroSocio}";
            foreach (Objetivo objetivo in s.Objetivos)
            {
                sentenciaSql += $" INSERT INTO Objetivos_X_Socios (id_objetivo, nroSocio) VALUES ({objetivo.Id_Objetivo}, {NroSocio})";
            }
            return sentenciaSql;
        }

        public bool ModificarSocio(Socio s, int NroSocio)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var peso = s.Peso.ToString().Replace(',', '.');
                    var sentenciaSql = " UPDATE Socios SET nroDoc = @nroDoc, id_tipoDoc = @id_tipoDoc, nombre = @nombre, apellido = @apellido, " +
                        "fechaNacimiento = @fechaNacimiento, id_sexo = @id_sexo, altura = @altura, peso = @peso, calle = @calle, nroCalle = @nroCalle, id_ciudad = @id_ciudad, codigoPostal = @codigoPostal," +
                        "telefono = @telefono, email = @email, antecedenteMedico = @antecedenteMedico, fechaBaja = @fechaBaja, fechaAlta = @fechaAlta, estado = @estado " +
                        "WHERE nroSocio = @nroSocio ";
                    var lista = new List<Parametro>();
                    lista.Add(new Parametro { NombreColumna = "@nroSocio", Valor = NroSocio });
                    lista.Add(new Parametro { NombreColumna = "@nroDoc", Valor = s.NroDocumento });
                    lista.Add(new Parametro { NombreColumna = "@id_tipoDoc", Valor = s.TipoDocumento.Id_TipoDoc });
                    lista.Add(new Parametro { NombreColumna = "@nombre", Valor = s.Nombre });
                    lista.Add(new Parametro { NombreColumna = "@apellido", Valor = s.Apellido });
                    lista.Add(new Parametro { NombreColumna = "@fechaNacimiento", Valor = s.FechaNacimiento });
                    lista.Add(new Parametro { NombreColumna = "@id_sexo", Valor = s.Sexo.Id_Sexo });
                    lista.Add(new Parametro { NombreColumna = "@altura", Valor = s.Altura });
                    lista.Add(new Parametro { NombreColumna = "@peso", Valor = peso });
                    lista.Add(new Parametro { NombreColumna = "@calle", Valor = s.Calle });
                    lista.Add(new Parametro { NombreColumna = "@nroCalle", Valor = s.NroCalle });
                    lista.Add(new Parametro { NombreColumna = "@id_ciudad", Valor = s.Ciudad.Id_Ciudad });
                    lista.Add(new Parametro { NombreColumna = "@codigoPostal", Valor = s.CodigoPostal });
                    lista.Add(new Parametro { NombreColumna = "@telefono", Valor = s.Telefono });
                    lista.Add(new Parametro { NombreColumna = "@email", Valor = s.Email });
                    lista.Add(new Parametro { NombreColumna = "@antecedenteMedico", Valor = s.AntecedenteMedico });
                    lista.Add(new Parametro { NombreColumna = "@fechaBaja", Valor = System.Data.SqlTypes.SqlDateTime.Null });
                    lista.Add(new Parametro { NombreColumna = "@fechaAlta", Valor = DateTime.Today });
                    lista.Add(new Parametro { NombreColumna = "@estado", Valor = 'S' });
                    sentenciaSql += ModificarObjetivosSocio(s, NroSocio, sentenciaSql);
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
    }
}