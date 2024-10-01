using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenciaDeAlumnos
{
    public partial class Form1 : Form
    {
        public Alumno entidadAlumno = new Alumno();
        public Asistencia entidadAsistencia = new Asistencia();
        public NegAlumno objNegAlu = new NegAlumno();
        public NegAsistencia objNegAsi = new NegAsistencia();
        public Form1()
        {
            InitializeComponent();
            CrearDGVs();
            LlenarDGVAlumnos();
        }
        private void CrearDGVs()
        {
            dgv_Alumnos.Columns.Add("0", "Documento");
            dgv_Alumnos.Columns.Add("1", "Apellido");
            dgv_Alumnos.Columns.Add("2", "Nombre");
            dgv_Alumnos.Columns.Add("3", "Cursado");

            dgv_Asistencias.Columns.Add("0", "DNI");
            dgv_Asistencias.Columns.Add("1", "Fecha");
            dgv_Asistencias.Columns.Add("2", "Asistio");

        }

        private void LlenarDGVAlumnos()
        {
            //limpiamos el DataGridView
            dgv_Alumnos.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegAlu.listadoAlumnos("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_Alumnos.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
            }
            else
            {
                lbl_msj.Text = "No hay Alumnos cargados en el sistema.";
            }
        }
        private void Formar_Alumno()
        {
            entidadAlumno.Documento = int.Parse(txt_Documento.Text);
            entidadAlumno.Apellido = txt_Apellido.Text;
            entidadAlumno.Nombre = txt_Nombre.Text;
            entidadAlumno.Cursado = rbtm_Virtual.Checked;
        }

        private void btn_CargarAlumno_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            Formar_Alumno();
            nGrabados = objNegAlu.abmAlumnos("Alta", entidadAlumno);

            if (nGrabados == -1)
            {
                lbl_msj.Text = "No se pudo cargar el alumno en el sistema.";
            }
            else
            {
                lbl_msj.Text = "Se cargo el Alumno con éxito.";
                LlenarDGVAlumnos();
                Limpiar();
            }
        }

        private void Limpiar()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                txt_Documento.Text = string.Empty;
                txt_Apellido.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                rbtm_Virtual.Checked = false;
                btn_CargarAlumno.Visible = true;
                epv_Alumnos.Clear();
            }
            else
            {
                rbtn_Asistio.Checked = false;
            }
        }
        private void LlenarCampos()
        {

        }
    }
}
