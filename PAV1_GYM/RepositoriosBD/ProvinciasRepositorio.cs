using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV1_GYM.Entidades;

namespace PAV1_GYM.RepositoriosBD
{
    public class ProvinciasRepositorio
    {
        public List<Provincia> GetProvincias()
        {
            var provincias = new List<Provincia>();
            var sentenciaSql = "SELECT * FROM Provincias";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var provincia = new Provincia();
                provincia.Id_Provincia = Convert.ToInt32(fila["id_provincia"]);
                provincia.Nombre = fila["nombre"].ToString();
                provincias.Add(provincia);
            }
            return provincias;
        }

        public List<Provincia> GetProvinciasConCiudad()
        {
            var provincias = new List<Provincia>();
            var sentenciaSql = "SELECT DISTINCT p.* FROM Ciudades c LEFT JOIN Provincias p ON c.id_provincia = p.id_provincia";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var provincia = new Provincia();
                provincia.Id_Provincia = Convert.ToInt32(fila["id_provincia"]);
                provincia.Nombre = fila["nombre"].ToString();
                provincias.Add(provincia);
            }
            return provincias;
        }
    }
}