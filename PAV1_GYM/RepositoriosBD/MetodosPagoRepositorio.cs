using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using System.Data;

namespace PAV1_GYM.RepositoriosBD
{
    public class MetodosPagoRepositorio
    {
        public List<MetodoPago> GetMetodosPago()
        {
            var metodosPago = new List<MetodoPago>();
            var sentenciaSql = $"SELECT * FROM Metodos_Pagos";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var metodoPago = new MetodoPago();
                metodoPago.Id_MetodoPago = Convert.ToInt32(fila["id_metodoPago"]);
                metodoPago.Nombre = fila["nombre"].ToString();
                metodosPago.Add(metodoPago);
            }
            return metodosPago;
        }
    }
}
