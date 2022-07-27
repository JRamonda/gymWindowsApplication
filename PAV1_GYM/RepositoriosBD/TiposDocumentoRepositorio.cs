using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using System.Data;

namespace PAV1_GYM.RepositoriosBD
{
    public class TiposDocumentoRepositorio
    {
        public List<TipoDocumento> GetTiposDocumento()
        {
            var tiposDocumento = new List<TipoDocumento>();
            var sentenciaSql = $"SELECT * FROM Tipos_Documentos";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var tipoDocumento = new TipoDocumento();
                tipoDocumento.Id_TipoDoc = Convert.ToInt32(fila["id_tipoDoc"]);
                tipoDocumento.Nombre = fila["nombre"].ToString();
                tiposDocumento.Add(tipoDocumento);
            }
            return tiposDocumento;
        }
    }
}