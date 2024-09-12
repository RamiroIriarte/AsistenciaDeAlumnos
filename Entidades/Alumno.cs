using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        #region Atributos
        private int documento;
        private string apellido;
        private string nombre;
        private bool cursado;

        #endregion

        #region Constructor
        public Alumno()
        {

        }
        #endregion

        #region propiedades
        public int Documento { get { return documento; } set { documento = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public bool Cursado { get { return cursado; } set { cursado = value; } }

        #endregion
    }
}
