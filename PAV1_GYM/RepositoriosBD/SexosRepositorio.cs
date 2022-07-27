using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using System.Data;

namespace PAV1_GYM.RepositoriosBD
{
    public class SexosRepositorio
    {
        public List<Sexo> GetSexos()
        {
            var sexos = new List<Sexo>();
            var sentenciaSql = $"SELECT * FROM Sexos";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var sexo = new Sexo();
                sexo.Id_Sexo = Convert.ToInt32(fila["id_sexo"]);
                sexo.Nombre = fila["nombre"].ToString();
                sexos.Add(sexo);
            }
            return sexos;
        }
    }
}
