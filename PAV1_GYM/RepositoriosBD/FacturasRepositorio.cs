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
    public class FacturasRepositorio
    {
        private Factura MapearFactura(DataRow row)
        {
            var socio = new Socio
            {
                NroSocio = Convert.ToInt32(row["NroSocio"]),
                NroDocumento = row["NroDoc"].ToString(),
                Nombre = row["NombreSocio"].ToString(),
                Apellido = row["ApellidoSocio"].ToString(),
                Calle = row["Calle"].ToString(),
                NroCalle = int.Parse(row["NroCalle"].ToString()),
                CodigoPostal = row["CodigoPostal"].ToString(),
                Telefono = row["Telefono"].ToString(),
                TipoDocumento = new TipoDocumento
                {
                    Id_TipoDoc = int.Parse(row["Id_TipoDoc"].ToString()),
                    Nombre = row["NombreDoc"].ToString()
                }
            };
            var empleado = new Empleado
            {
                LegajoEmpleado = Convert.ToInt32(row["LegajoEmpleado"]),
                Nombre = row["NombreEmpleado"].ToString(),
                Apellido = row["ApellidoEmpleado"].ToString(),
            };
            var metodoPago = new MetodoPago
            {
                Id_MetodoPago = Convert.ToInt32(row["Id_MetodoPago"]),
                Nombre = row["NombrePago"].ToString()
            };
            var factura = new Factura
            {
                NroFactura = Convert.ToInt32(row["NroFactura"]),
                Socio = socio,
                Empleado = empleado,
                MetodoPago = metodoPago,
                Fecha = Convert.ToDateTime(row["Fecha"]),
                MontoTotal = Convert.ToSingle(row["MontoTotal"]),
                CondicionCobro = row["CondicionCobro"].ToString() == "Cobrado"
            }; 
            return factura;
        }

        public List<int> GetNroFacturas()
        {
            var nroFacturas = new List<int>();
            var sentenciaSql = $"SELECT nroFactura FROM Facturas";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var nroFactura = Convert.ToInt32(fila["nroFactura"]);
                nroFacturas.Add(nroFactura);
            }
            return nroFacturas;
        }

        public Factura ObtenerFactura()
        {
            var sentenciaSql = $"SELECT f.*, s.nroDoc as NroDoc, s.id_tipoDoc as Id_TipoDoc, s.nombre as NombreSocio, s.apellido as ApellidoSocio, s.calle, s.nroCalle, " +
                "s.codigoPostal, s.telefono, td.nombre as NombreDoc, e.nombre as NombreEmpleado, e.apellido as ApellidoEmpleado, mp.nombre as NombrePago " +
                "FROM Facturas f LEFT JOIN Socios s ON f.nroSocio = s.nroSocio LEFT JOIN Empleados e ON f.legajoEmpleado = e.legajoEmpleado LEFT JOIN Metodos_Pagos mp " +
                "ON f.id_metodoPago = mp.id_metodoPago LEFT JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc WHERE nroFactura = (SELECT Max(nroFactura) FROM Facturas) ";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count >= 1)
            {
                var factura = MapearFactura(tablaResultado.Rows[0]);
                return factura;
            }
            else
                throw new ApplicationException("La factura no existe");
        }

        public Factura ObtenerFacturaBuscada(int nroFac)
        {
            var sentenciaSql = $"SELECT f.*, s.nroDoc as NroDoc, s.id_tipoDoc as Id_TipoDoc, s.nombre as NombreSocio, s.apellido as ApellidoSocio, s.calle, s.nroCalle, " +
                "s.codigoPostal, s.telefono, td.nombre as NombreDoc, e.nombre as NombreEmpleado, e.apellido as ApellidoEmpleado, mp.nombre as NombrePago " +
                "FROM Facturas f LEFT JOIN Socios s ON f.nroSocio = s.nroSocio LEFT JOIN Empleados e ON f.legajoEmpleado = e.legajoEmpleado LEFT JOIN Metodos_Pagos mp " +
                $"ON f.id_metodoPago = mp.id_metodoPago LEFT JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc WHERE nroFactura = {nroFac}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count >= 1)
            {
                var factura = MapearFactura(tablaResultado.Rows[0]);
                return factura;
            }
            else
                throw new ApplicationException("La factura no existe");
        }

        public List<Factura> ObtenerFacturas(Factura f)
        {
            var facturas = new List<Factura>();
            var sentenciaSql = $"SELECT f.*, s.nroDoc as NroDoc, s.id_tipoDoc as Id_TipoDoc, s.nombre as NombreSocio, s.apellido as ApellidoSocio, s.calle, s.nroCalle, " +
            "s.codigoPostal, s.telefono, td.nombre as NombreDoc, e.nombre as NombreEmpleado, e.apellido as ApellidoEmpleado, mp.nombre as NombrePago " +
            "FROM Facturas f LEFT JOIN Socios s ON f.nroSocio = s.nroSocio LEFT JOIN Empleados e ON f.legajoEmpleado = e.legajoEmpleado LEFT JOIN Metodos_Pagos mp " +
            $"ON f.id_metodoPago = mp.id_metodoPago LEFT JOIN Tipos_Documentos td ON s.id_tipoDoc = td.id_tipoDoc WHERE nroFactura LIKE '%%'";
            if ( f.NroFactura != 0)
                sentenciaSql += $" AND nroFactura = {f.NroFactura}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var factura = MapearFactura(fila);
                facturas.Add(factura);
            }
            return facturas;
        }

        public bool ValidarExistenciaFactura(Factura f)
        {
            var sentenciaSql = $"SELECT nroFactura FROM Facturas WHERE nroSocio = {f.Socio.NroSocio} AND legajoEmpleado = {f.Empleado.LegajoEmpleado} " +
                $"AND id_metodoPago = {f.MetodoPago.Id_MetodoPago} AND CONVERT(VARCHAR(10), fecha, 103) >= CONVERT(VARCHAR(10), {f.Fecha}, 103) AND montoTotal = {f.MontoTotal}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        public bool RegistrarFactura(Factura f, Dictionary<int, DetalleFactura> listDf)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var condicionCobro = f.CondicionCobro ? "Cobrado" : "No cobrado";
                    var montoTotal = f.MontoTotal.ToString().Replace(',', '.');
                    var sentenciaSql = "INSERT INTO Facturas (nroSocio, legajoEmpleado, id_metodoPago, fecha, montoTotal, condicionCobro) " +
                           $" VALUES ({f.Socio.NroSocio}, {f.Empleado.LegajoEmpleado}, {f.MetodoPago.Id_MetodoPago}, '{f.Fecha}', {montoTotal}, '{condicionCobro}') " +
                            " DECLARE @nroFactura int " +
                            " SET @nroFactura = (SELECT SCOPE_IDENTITY())";
                    foreach (DetalleFactura df in listDf.Values)
                    {
                        var precioUnitario = df.PrecioUnitario.ToString().Replace(',', '.');
                        var promocion = df.Promocion.ToString().Replace(',', '.');
                        sentenciaSql += " INSERT INTO Detalles_Facturas (nroFactura, id_actividad, id_plan, precioUnitario, promocion, fechaDevPrevista, fechaDevReal) " +
                            $" VALUES (@nroFactura, {df.Actividad.Id_Actividad}, {df.Plan.Id_Plan}, {precioUnitario}, {promocion}, '{df.FechaDevPrevista}', '{df.FechaDevReal}') " +
                            $" INSERT INTO Actividades_Y_Planes_X_Socios (id_actividad, id_plan, nroSocio) VALUES ({df.Actividad.Id_Actividad}, {df.Plan.Id_Plan}, {f.Socio.NroSocio})";
                    }
                    var identity = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sentenciaSql);
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

        private DetalleFactura MapearDF(DataRow row)
        {
            var actividad = new Actividad
            {
                Id_Actividad = Convert.ToInt32(row["Id_Actividad"]),
                Nombre = row["NombreActividad"].ToString(),
                Precio = float.Parse(row["Precio"].ToString()),
            };
            var plan = new Plan
            {
                Id_Plan = Convert.ToInt32(row["Id_plan"]),
                Nombre = row["NombrePlan"].ToString(),
                PrecioEstandar = float.Parse(row["PrecioEstandar"].ToString()),
            };
            var factura = new Factura
            {
                NroFactura = Convert.ToInt32(row["NroFactura"])
            };
            var detalleFactura = new DetalleFactura
            {
                Factura = factura,
                Orden = Convert.ToInt32(row["Orden"]),
                Actividad = actividad,
                Plan = plan,
                PrecioUnitario = Convert.ToSingle(row["PrecioUnitario"]),
                Promocion = Convert.ToSingle(row["Promocion"]),
                FechaDevPrevista = Convert.ToDateTime(row["FechaDevPrevista"]),
                FechaDevReal = Convert.ToDateTime(row["FechaDevReal"])
            };
            return detalleFactura;
        }

        public List<DetalleFactura> ObtenerDetallesFacturas(DetalleFactura df)
        {
            var detalleFacturas = new List<DetalleFactura>();
            var sentenciaSql = "SELECT df.*, a.nombre as NombreActividad, a.precio, p.nombre as NombrePlan, p.precioEstandar " +
                "FROM Detalles_Facturas df LEFT JOIN Actividades a ON df.id_actividad = a.id_actividad LEFT JOIN Planes p ON df.id_plan = p.id_plan " +
                "WHERE nroFactura LIKE '%%'";
            if (df.Factura.NroFactura != 0)
                sentenciaSql += $" AND nroFactura = {df.Factura.NroFactura}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var detalleFactura = MapearDF(fila);
                detalleFacturas.Add(detalleFactura);
            }
            return detalleFacturas;
        }

        public bool EliminarFactura(int nroFactura)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sentenciaSql = $"DELETE FROM Facturas WHERE nroFactura = {nroFactura}";
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
    }
}