using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using System.Data;

namespace PAV1_GYM.RepositoriosBD
{
    public class PlanesRepositorio
    {
        public List<Plan> GetPlanes()
        {
            var planes = new List<Plan>();
            var sentenciaSql = $"SELECT * FROM Planes";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var plan = new Plan();
                plan.Id_Plan = Convert.ToInt32(fila["id_plan"]);
                plan.Nombre = fila["nombre"].ToString();
                plan.Descripcion = fila["descripcion"].ToString();
                plan.PrecioEstandar = float.Parse(fila["precioEstandar"].ToString());
                plan.FechaInicioPlan = DateTime.Parse(fila["fechaInicioPlan"].ToString());
                plan.Estado = fila["estado"].ToString() == "S";
                planes.Add(plan);
            }
            return planes;
        }

        public static bool ValidarExistenciaPlan(string nombre)
        {
            var sentenciaSql = $"SELECT nombre FROM Planes WHERE nombre = '{nombre}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        private Plan Mapear(DataRow row)
        {
            var plan = new Plan();
            plan.Id_Plan = Convert.ToInt32(row["Id_plan"]);
            plan.Nombre = row["Nombre"].ToString();
            plan.Descripcion = row["Descripcion"].ToString();
            plan.PrecioEstandar = float.Parse(row["PrecioEstandar"].ToString());
            plan.FechaInicioPlan = DateTime.Parse(row["FechaInicioPlan"].ToString());
            plan.Estado = row["Estado"].ToString() == "S";
            return plan;
        }

        public Plan ObtenerPlan(string nombre)
        {
            var sentenciaSql = $"SELECT * FROM Planes WHERE nombre LIKE '%{nombre}%'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count >= 1)
            {
                var plan = Mapear(tablaResultado.Rows[0]);
                return plan;
            }
            else
                throw new ApplicationException("El plan no existe, verifique el nombre");
        }

        public List<Plan> ObtenerPlanes(Plan p)
        {
            List<Plan> planes = new List<Plan>();
            var sentenciaSql = "SELECT * FROM Planes WHERE nombre LIKE '%%'";
            var estado = p.Estado ? "S" : "N";
            if (p.Id_Plan != 0)
                sentenciaSql += $" AND id_plan = {p.Id_Plan}";
            if (p.Nombre != "")
                sentenciaSql += $" AND nombre LIKE '%{p.Nombre}%'";
            sentenciaSql += $" AND estado = '{estado}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var plan = Mapear(fila);
                planes.Add(plan);
            }
            return planes;
        }

        public bool RegistrarPlan(Plan p)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    if (!ValidarExistenciaPlan(p.Nombre))
                    {
                        var precio = p.PrecioEstandar.ToString().Replace(',', '.');
                        var sentenciaSQL = $"INSERT INTO Planes (nombre, descripcion, precioEstandar, fechaInicioPlan , estado) VALUES ('{p.Nombre}', '{p.Descripcion}', {p.PrecioEstandar}, '{p.FechaInicioPlan}', 'S')";
                        var filasAfectadas = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sentenciaSQL);
                        tx.Commit();
                        return true;
                    }
                    else
                        throw new ApplicationException("El plan ya existe");
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

        public bool EliminarPlan(int id_plan)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = $"DELETE FROM Planes WHERE id_plan = {id_plan}";
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

        public bool ModificarEstadoPlan(Plan p)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var estado = p.Estado ? "S" : "N";
                    var sentenciaSql = $"UPDATE Planes SET estado='{estado}', fechainicioplan='{DateTime.Today}'  WHERE nombre= '{p.Nombre}'";
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

        public bool ModificarPlan(Plan p, string nombrePlanBuscado)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var precio = p.PrecioEstandar.ToString().Replace(',', '.');
                    var sentenciaSql = "UPDATE Planes SET nombre = @nombre, descripcion = @descripcion, precioestandar = @precioestandar WHERE nombre LIKE @nombreBuscado";
                    var lista = new List<Parametro>();
                    lista.Add(new Parametro { NombreColumna = "@nombreBuscado", Valor = nombrePlanBuscado });
                    lista.Add(new Parametro { NombreColumna = "@nombre", Valor = p.Nombre });
                    lista.Add(new Parametro { NombreColumna = "@descripcion", Valor = p.Descripcion });
                    lista.Add(new Parametro { NombreColumna = "@precioestandar", Valor = p.PrecioEstandar });
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionAddSQL(sentenciaSql, lista);
                    p.Estado = true;
                    ModificarEstadoPlan(p);
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