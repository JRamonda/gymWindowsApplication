using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using System.Data;

namespace PAV1_GYM.RepositoriosBD
{
    public class PerfilesRepositorio
    {
        public List<Perfil> GetPerfiles(int id_perfilUsuario)
        {
            var perfiles = new List<Perfil>();
            var sentenciaSql = $"SELECT * FROM Perfiles WHERE nombre LIKE '%%'";
            if (id_perfilUsuario == 2)
                sentenciaSql += $" AND id_perfil != 1 AND id_perfil != 2";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var perfil = new Perfil();
                perfil.Id_Perfil = Convert.ToInt32(fila["id_perfil"]);
                perfil.Nombre = fila["nombre"].ToString();
                perfiles.Add(perfil);
            }
            return perfiles;
        }
    }
}
