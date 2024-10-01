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
    public class DatosAsistencia : DatosConexion
    {
        public int abmAsistencias(string accion, Asistencia objAsistencia)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = "INSERT INTO Asistencias (docAlumno, Fecha, Asistio) VALUES (@DocAlumno, @Fecha, @Asistio)";
            }
            else if (accion == "Borrar")
            {
                orden = "DELETE FROM Asistencias WHERE  docAlumno = @DocAlumno AND Fecha = @Fecha";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);
            //cmd.Parameters.AddWithValue("@NuevaFecha", nuevaFecha);
            cmd.Parameters.AddWithValue("@DocAlumno", objAsistencia.DocAlumno);
            cmd.Parameters.AddWithValue("@Fecha", objAsistencia.Fecha);
            cmd.Parameters.AddWithValue("@Presente", objAsistencia.Asistio);

            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar las asistencias de los alumnos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return resultado;
        }
        public DataSet listadoAsistencias(string documentoAlu, DateTime fecha)
        {
            string orden = string.Empty;
            if (documentoAlu != "Todos")
                orden = "select * from Asistencias where docAlumno = " + int.Parse(documentoAlu) + " and Fecha = @fecha;";
            else
                orden = "select * from Asistencias;";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@fecha", fecha);

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
                throw new Exception("Error al listar las asistencias", e);
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
