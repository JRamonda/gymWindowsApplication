using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using System.Data;

namespace PAV1_GYM.RepositoriosBD
{
    public class ActsXTursRepositorio
    {
        public List<ActividadXTurno> GetActsXTurns()
        {
            var actsXturs = new List<ActividadXTurno>();
            var sentenciaSql = "SELECT axt.id_actividad as Id_Actividad, " +
                "a.nombre as NombreActividad,a.descripcion as Descripcion, a.precio as Precio, a.estado as EstadoActividad, axt.id_turno as Id_Turno, t.nombre as NombreTurno, " +
                "t.hora_Inicio as Hora_Inicio, t.hora_Fin as Hora_Fin, t.dia as Dia, t.estado as EstadoTurno " +
                "FROM Actividades_X_Turnos axt JOIN Actividades a ON axt.id_actividad = a.id_actividad JOIN Turnos t ON axt.id_turno = t.id_turno";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow row in tablaResultado.Rows)
            {
                float precio;
                float.TryParse(row["Precio"].ToString(), out precio);
                var actXtur = new ActividadXTurno();
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
                actXtur.Actividad = actividad;
                actXtur.Turno = turno;
                actsXturs.Add(actXtur);
            }
            return actsXturs;
        }
    }
}