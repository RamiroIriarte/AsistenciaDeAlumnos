using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosAlumno : DatosConexion
    {
        public int abmAlumnos(string accion, Alumno objAlumno)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = "INSERT INTO Alumnos (Documento, Apellido, Nombre, Cursado) VALUES (@Documento, @Apellido, @Nombre, @Cursado);";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Alumnos SET Apellido = @Apellido, Nombre = @Nombre WHERE Documento = @Documento;";
            }
            else if (accion == "Borrar")
            {
                orden = "DELETE FROM Alumnos WHERE Documento = @Documento;";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@Documento", objAlumno.Documento);
            cmd.Parameters.AddWithValue("@Apellido", objAlumno.Apellido);
            cmd.Parameters.AddWithValue("@Nombre", objAlumno.Nombre);
            cmd.Parameters.AddWithValue("@Cursado", objAlumno.Cursado);


            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar Alumnos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return resultado;

        }
        public DataSet listadoAlumnos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Alumnos where Documento = " + int.Parse(cual) + ";";
            else
                orden = "select * from Alumnos;";

            SqlCommand cmd = new SqlCommand(orden, conexion);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar alumnos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return ds;
        }
    }
}
