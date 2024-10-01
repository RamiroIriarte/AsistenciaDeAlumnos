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
    public class NegAlumno
    {
        DatosAlumno objDatosAlum = new DatosAlumno();

        public int abmAlumnos(string accion, Alumno objAlumno)
        {
            return objDatosAlum.abmAlumnos(accion, objAlumno);
        }
        public DataSet listadoAlumnos(string cual)
        {
            return objDatosAlum.listadoAlumnos(cual);
        }
    }
}
