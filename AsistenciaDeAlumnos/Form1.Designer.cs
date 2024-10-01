namespace AsistenciaDeAlumnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_Alumnos = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_msj = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtm_Presencial = new System.Windows.Forms.RadioButton();
            this.rbtm_Virtual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_CargarAlumno = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtn_Asistio = new System.Windows.Forms.RadioButton();
            this.cmb_Documentos = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgv_Asistencias = new System.Windows.Forms.DataGridView();
            this.epv_Alumnos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epv_Alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Alumnos
            // 
            this.dgv_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alumnos.Location = new System.Drawing.Point(376, -10);
            this.dgv_Alumnos.Name = "dgv_Alumnos";
            this.dgv_Alumnos.Size = new System.Drawing.Size(265, 382);
            this.dgv_Alumnos.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 404);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_msj);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_Nombre);
            this.tabPage1.Controls.Add(this.txt_Apellido);
            this.tabPage1.Controls.Add(this.txt_Documento);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btn_CargarAlumno);
            this.tabPage1.Controls.Add(this.dgv_Alumnos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alumnos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_msj
            // 
            this.lbl_msj.AutoSize = true;
            this.lbl_msj.Location = new System.Drawing.Point(237, 347);
            this.lbl_msj.Name = "lbl_msj";
            this.lbl_msj.Size = new System.Drawing.Size(0, 13);
            this.lbl_msj.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtm_Presencial);
            this.groupBox1.Controls.Add(this.rbtm_Virtual);
            this.groupBox1.Location = new System.Drawing.Point(195, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 81);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursado virtual";
            // 
            // rbtm_Presencial
            // 
            this.rbtm_Presencial.AutoSize = true;
            this.rbtm_Presencial.Location = new System.Drawing.Point(6, 51);
            this.rbtm_Presencial.Name = "rbtm_Presencial";
            this.rbtm_Presencial.Size = new System.Drawing.Size(74, 17);
            this.rbtm_Presencial.TabIndex = 12;
            this.rbtm_Presencial.TabStop = true;
            this.rbtm_Presencial.Text = "Presencial";
            this.rbtm_Presencial.UseVisualStyleBackColor = true;
            // 
            // rbtm_Virtual
            // 
            this.rbtm_Virtual.AutoSize = true;
            this.rbtm_Virtual.Location = new System.Drawing.Point(6, 19);
            this.rbtm_Virtual.Name = "rbtm_Virtual";
            this.rbtm_Virtual.Size = new System.Drawing.Size(54, 17);
            this.rbtm_Virtual.TabIndex = 11;
            this.rbtm_Virtual.TabStop = true;
            this.rbtm_Virtual.Text = "Virtual";
            this.rbtm_Virtual.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = " Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "D N I";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(6, 94);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 6;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(6, 149);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 5;
            // 
            // txt_Documento
            // 
            this.txt_Documento.Location = new System.Drawing.Point(6, 33);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(100, 20);
            this.txt_Documento.TabIndex = 4;
            this.txt_Documento.Text = " ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = " Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = " Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_CargarAlumno
            // 
            this.btn_CargarAlumno.Location = new System.Drawing.Point(6, 201);
            this.btn_CargarAlumno.Name = "btn_CargarAlumno";
            this.btn_CargarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarAlumno.TabIndex = 1;
            this.btn_CargarAlumno.Text = "Cargar";
            this.btn_CargarAlumno.UseVisualStyleBackColor = true;
            this.btn_CargarAlumno.Click += new System.EventHandler(this.btn_CargarAlumno_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.rbtn_Asistio);
            this.tabPage2.Controls.Add(this.cmb_Documentos);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.dgv_Asistencias);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Asistencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Documentos de Alumnos";
            // 
            // rbtn_Asistio
            // 
            this.rbtn_Asistio.AutoSize = true;
            this.rbtn_Asistio.Location = new System.Drawing.Point(20, 118);
            this.rbtn_Asistio.Name = "rbtn_Asistio";
            this.rbtn_Asistio.Size = new System.Drawing.Size(55, 17);
            this.rbtn_Asistio.TabIndex = 4;
            this.rbtn_Asistio.TabStop = true;
            this.rbtn_Asistio.Text = "Asistio";
            this.rbtn_Asistio.UseVisualStyleBackColor = true;
            // 
            // cmb_Documentos
            // 
            this.cmb_Documentos.FormattingEnabled = true;
            this.cmb_Documentos.Location = new System.Drawing.Point(20, 33);
            this.cmb_Documentos.Name = "cmb_Documentos";
            this.cmb_Documentos.Size = new System.Drawing.Size(79, 21);
            this.cmb_Documentos.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dgv_Asistencias
            // 
            this.dgv_Asistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Asistencias.Location = new System.Drawing.Point(379, 0);
            this.dgv_Asistencias.Name = "dgv_Asistencias";
            this.dgv_Asistencias.Size = new System.Drawing.Size(265, 382);
            this.dgv_Asistencias.TabIndex = 1;
            // 
            // epv_Alumnos
            // 
            this.epv_Alumnos.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epv_Alumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Alumnos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_CargarAlumno;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtm_Presencial;
        private System.Windows.Forms.RadioButton rbtm_Virtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Asistencias;
        private System.Windows.Forms.ErrorProvider epv_Alumnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtn_Asistio;
        private System.Windows.Forms.ComboBox cmb_Documentos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_msj;
    }
}

