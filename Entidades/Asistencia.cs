using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        #region Atributos
        private int docAlumno;
        private DateTime fecha;
        private bool asistio;

        #endregion

        #region Constructor
        public Asistencia()
        {

        }
        #endregion

        #region propiedades
        public int DocAlumno { get { return docAlumno; } set { docAlumno = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public bool Asistio { get { return asistio; } set { asistio = value; } }

        #endregion
    }
}
