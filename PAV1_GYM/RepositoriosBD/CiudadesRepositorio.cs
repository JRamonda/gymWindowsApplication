using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using System.Data;

namespace PAV1_GYM.RepositoriosBD
{
    public class CiudadesRepositorio
    {
        public static bool ValidarExistenciaCiudad(string nombre)
        {
            var sentenciaSql = $"SELECT nombre FROM Ciudades WHERE nombre = '{nombre}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaDuranteTransaccion(sentenciaSql);
            if (tablaResultado.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        public List<Ciudad> GetCiudades()
        {
            var ciudades = new List<Ciudad>();
            var sentenciaSql = "SELECT c.Id_Ciudad, c.Nombre as NombreCiudad, p.Id_Provincia, p.Nombre as NombreProvincia FROM Ciudades c " +
                $"JOIN Provincias p ON c.id_provincia = p.id_provincia";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var ciudad = Mapear(fila);
                ciudades.Add(ciudad);
            }
            return ciudades;
        }

        private Ciudad Mapear(DataRow row)
        {
            var ciudad = new Ciudad();
            var provincia = new Provincia();
            ciudad.Id_Ciudad = Convert.ToInt32(row["Id_Ciudad"]);
            ciudad.Nombre = row["NombreCiudad"].ToString();
            provincia.Id_Provincia = Convert.ToInt32(row["Id_Provincia"]);
            provincia.Nombre = row["NombreProvincia"].ToString();
            ciudad.Provincia = provincia;
            return ciudad;
        }

        public Ciudad ObtenerCiudad(string nombre)
        {
            var sentenciaSql = "SELECT c.Id_Ciudad, c.Nombre as NombreCiudad, p.Id_Provincia, p.Nombre as NombreProvincia FROM Ciudades c " +
                $"JOIN Provincias p ON c.id_provincia = p.id_provincia WHERE c.nombre LIKE '%{nombre}%'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count >= 1)
            {
                var ciudad = Mapear(tablaResultado.Rows[0]);
                return ciudad;
            }
            else
                throw new ApplicationException("La ciudad no existe, verifique el nombre");
        }

        public List<Ciudad> ObtenerCiudades(Ciudad c)
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            var sentenciaSql = "SELECT c.Id_Ciudad, c.Nombre as NombreCiudad, p.Id_Provincia, p.Nombre as NombreProvincia FROM Ciudades c " +
                $"JOIN Provincias p ON c.id_provincia = p.id_provincia WHERE c.Nombre LIKE '%%'";
            if (c.Nombre != "")
                sentenciaSql += $" AND c.nombre LIKE '%{c.Nombre}%'";
            if (c.Provincia.Nombre != "Seleccionar")
                sentenciaSql += $" AND p.nombre = '{c.Provincia.Nombre}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var ciudad = Mapear(fila);
                ciudades.Add(ciudad);
            }
            return ciudades;
        }

        public bool RegistrarCiudad(Ciudad c)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    if (!ValidarExistenciaCiudad(c.Nombre))
                    {
                        var sentenciaSQL = $"INSERT INTO Ciudades (nombre, id_provincia) VALUES ('{c.Nombre}', {c.Provincia.Id_Provincia})";
                        var filasAfectadas = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sentenciaSQL);
                        tx.Commit();
                        return true;
                    }
                    else
                        throw new ApplicationException("La ciudad ya existe");
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

        public bool EliminarCiudad(int id_ciudad)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = $"DELETE FROM Ciudades WHERE id_ciudad = {id_ciudad}";
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

        public bool ModificarCiudad(Ciudad c, string nombreCiudadBuscada)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = "UPDATE Ciudades SET nombre = @nombre, id_provincia = @id_provincia WHERE nombre LIKE @nombreBuscado";
                    var lista = new List<Parametro>();
                    lista.Add(new Parametro { NombreColumna = "@nombreBuscado", Valor = nombreCiudadBuscada });
                    lista.Add(new Parametro { NombreColumna = "@nombre", Valor = c.Nombre });
                    lista.Add(new Parametro { NombreColumna = "@id_provincia", Valor = c.Provincia.Id_Provincia });
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
