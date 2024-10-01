using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegAsistencia
    {
        DatosAsistencia objDatosAsist = new DatosAsistencia();

        public int abmAsistencias(string accion, Asistencia objAsistencia)
        {
            return objDatosAsist.abmAsistencias(accion, objAsistencia);
        }
        public DataSet listadoAsistencias(string documentoAlu, DateTime fecha)
        {
            return objDatosAsist.listadoAsistencias(documentoAlu, fecha);
        }
    }
}
