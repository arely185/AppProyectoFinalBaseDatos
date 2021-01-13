
namespace AppProyectoFinalBaseDatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbMenuServidores = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mostrarTablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUnRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAviso = new System.Windows.Forms.Label();
            this.groupBoxParaConexion = new System.Windows.Forms.GroupBox();
            this.groupBoxSecundario = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTextoDato6 = new System.Windows.Forms.Label();
            this.lblTextoDato5 = new System.Windows.Forms.Label();
            this.lblTextoDato4 = new System.Windows.Forms.Label();
            this.lblTextoDato3 = new System.Windows.Forms.Label();
            this.lblTextoDato2 = new System.Windows.Forms.Label();
            this.lblTextoDato1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAñadirRegistro = new System.Windows.Forms.Button();
            this.time2 = new System.Windows.Forms.TextBox();
            this.time1 = new System.Windows.Forms.TextBox();
            this.txtDato6 = new System.Windows.Forms.TextBox();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.txtDato3 = new System.Windows.Forms.TextBox();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.txtDato5 = new System.Windows.Forms.TextBox();
            this.txtDato4 = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColumna = new System.Windows.Forms.TextBox();
            this.txtNuevoDato = new System.Windows.Forms.TextBox();
            this.btnModificarRegistro = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.bntEliminarRegistro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMenuDeTrablas = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxParaConexion.SuspendLayout();
            this.groupBoxSecundario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(812, 208);
            this.dataGridView1.TabIndex = 16;
            // 
            // cmbMenuServidores
            // 
            this.cmbMenuServidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuServidores.FormattingEnabled = true;
            this.cmbMenuServidores.Items.AddRange(new object[] {
            "SQL SERVER",
            "POSTGRE SQL",
            "MARIA DB"});
            this.cmbMenuServidores.Location = new System.Drawing.Point(68, 22);
            this.cmbMenuServidores.Name = "cmbMenuServidores";
            this.cmbMenuServidores.Size = new System.Drawing.Size(121, 21);
            this.cmbMenuServidores.TabIndex = 26;
            this.cmbMenuServidores.SelectedIndexChanged += new System.EventHandler(this.cmbMenuServidores_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTablasToolStripMenuItem,
            this.agregarUnRegistroToolStripMenuItem,
            this.modificarRegistroToolStripMenuItem,
            this.eliminarRegistroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mostrarTablasToolStripMenuItem
            // 
            this.mostrarTablasToolStripMenuItem.Name = "mostrarTablasToolStripMenuItem";
            this.mostrarTablasToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.mostrarTablasToolStripMenuItem.Text = "Mostrar tablas";
            this.mostrarTablasToolStripMenuItem.Click += new System.EventHandler(this.mostrarTablasToolStripMenuItem_Click);
            // 
            // agregarUnRegistroToolStripMenuItem
            // 
            this.agregarUnRegistroToolStripMenuItem.Name = "agregarUnRegistroToolStripMenuItem";
            this.agregarUnRegistroToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.agregarUnRegistroToolStripMenuItem.Text = "Agregar un registro";
            this.agregarUnRegistroToolStripMenuItem.Click += new System.EventHandler(this.agregarUnRegistroToolStripMenuItem_Click);
            // 
            // modificarRegistroToolStripMenuItem
            // 
            this.modificarRegistroToolStripMenuItem.Name = "modificarRegistroToolStripMenuItem";
            this.modificarRegistroToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.modificarRegistroToolStripMenuItem.Text = "Modificar registro";
            this.modificarRegistroToolStripMenuItem.Click += new System.EventHandler(this.modificarRegistroToolStripMenuItem_Click);
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.eliminarRegistroToolStripMenuItem.Text = "Eliminar registro";
            this.eliminarRegistroToolStripMenuItem.Click += new System.EventHandler(this.eliminarRegistroToolStripMenuItem_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(22, 56);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(168, 13);
            this.lblAviso.TabIndex = 29;
            this.lblAviso.Text = "                Estado: (No conectado)";
            // 
            // groupBoxParaConexion
            // 
            this.groupBoxParaConexion.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxParaConexion.Controls.Add(this.cmbMenuServidores);
            this.groupBoxParaConexion.Controls.Add(this.lblAviso);
            this.groupBoxParaConexion.Location = new System.Drawing.Point(581, 27);
            this.groupBoxParaConexion.Name = "groupBoxParaConexion";
            this.groupBoxParaConexion.Size = new System.Drawing.Size(255, 84);
            this.groupBoxParaConexion.TabIndex = 32;
            this.groupBoxParaConexion.TabStop = false;
            // 
            // groupBoxSecundario
            // 
            this.groupBoxSecundario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxSecundario.Controls.Add(this.label13);
            this.groupBoxSecundario.Controls.Add(this.lblTextoDato6);
            this.groupBoxSecundario.Controls.Add(this.lblTextoDato5);
            this.groupBoxSecundario.Controls.Add(this.lblTextoDato4);
            this.groupBoxSecundario.Controls.Add(this.lblTextoDato3);
            this.groupBoxSecundario.Controls.Add(this.lblTextoDato2);
            this.groupBoxSecundario.Controls.Add(this.lblTextoDato1);
            this.groupBoxSecundario.Controls.Add(this.label7);
            this.groupBoxSecundario.Controls.Add(this.label6);
            this.groupBoxSecundario.Controls.Add(this.btnAñadirRegistro);
            this.groupBoxSecundario.Controls.Add(this.time2);
            this.groupBoxSecundario.Controls.Add(this.time1);
            this.groupBoxSecundario.Controls.Add(this.txtDato6);
            this.groupBoxSecundario.Controls.Add(this.dateTime1);
            this.groupBoxSecundario.Controls.Add(this.txtDato3);
            this.groupBoxSecundario.Controls.Add(this.txtDato1);
            this.groupBoxSecundario.Controls.Add(this.txtDato5);
            this.groupBoxSecundario.Controls.Add(this.txtDato4);
            this.groupBoxSecundario.Controls.Add(this.txtDato2);
            this.groupBoxSecundario.Location = new System.Drawing.Point(20, 64);
            this.groupBoxSecundario.Name = "groupBoxSecundario";
            this.groupBoxSecundario.Size = new System.Drawing.Size(511, 172);
            this.groupBoxSecundario.TabIndex = 38;
            this.groupBoxSecundario.TabStop = false;
            this.groupBoxSecundario.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Fecha:";
            // 
            // lblTextoDato6
            // 
            this.lblTextoDato6.AutoSize = true;
            this.lblTextoDato6.Location = new System.Drawing.Point(16, 149);
            this.lblTextoDato6.Name = "lblTextoDato6";
            this.lblTextoDato6.Size = new System.Drawing.Size(49, 13);
            this.lblTextoDato6.TabIndex = 53;
            this.lblTextoDato6.Text = "--------------";
            // 
            // lblTextoDato5
            // 
            this.lblTextoDato5.AutoSize = true;
            this.lblTextoDato5.Location = new System.Drawing.Point(17, 123);
            this.lblTextoDato5.Name = "lblTextoDato5";
            this.lblTextoDato5.Size = new System.Drawing.Size(49, 13);
            this.lblTextoDato5.TabIndex = 52;
            this.lblTextoDato5.Text = "--------------";
            // 
            // lblTextoDato4
            // 
            this.lblTextoDato4.AutoSize = true;
            this.lblTextoDato4.Location = new System.Drawing.Point(16, 96);
            this.lblTextoDato4.Name = "lblTextoDato4";
            this.lblTextoDato4.Size = new System.Drawing.Size(49, 13);
            this.lblTextoDato4.TabIndex = 51;
            this.lblTextoDato4.Text = "--------------";
            // 
            // lblTextoDato3
            // 
            this.lblTextoDato3.AutoSize = true;
            this.lblTextoDato3.Location = new System.Drawing.Point(17, 70);
            this.lblTextoDato3.Name = "lblTextoDato3";
            this.lblTextoDato3.Size = new System.Drawing.Size(49, 13);
            this.lblTextoDato3.TabIndex = 50;
            this.lblTextoDato3.Text = "--------------";
            // 
            // lblTextoDato2
            // 
            this.lblTextoDato2.AutoSize = true;
            this.lblTextoDato2.Location = new System.Drawing.Point(17, 44);
            this.lblTextoDato2.Name = "lblTextoDato2";
            this.lblTextoDato2.Size = new System.Drawing.Size(49, 13);
            this.lblTextoDato2.TabIndex = 49;
            this.lblTextoDato2.Text = "--------------";
            // 
            // lblTextoDato1
            // 
            this.lblTextoDato1.AutoSize = true;
            this.lblTextoDato1.Location = new System.Drawing.Point(17, 16);
            this.lblTextoDato1.Name = "lblTextoDato1";
            this.lblTextoDato1.Size = new System.Drawing.Size(49, 13);
            this.lblTextoDato1.TabIndex = 48;
            this.lblTextoDato1.Text = "--------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Hora fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Hora inicio";
            // 
            // btnAñadirRegistro
            // 
            this.btnAñadirRegistro.Location = new System.Drawing.Point(382, 133);
            this.btnAñadirRegistro.Name = "btnAñadirRegistro";
            this.btnAñadirRegistro.Size = new System.Drawing.Size(118, 27);
            this.btnAñadirRegistro.TabIndex = 45;
            this.btnAñadirRegistro.Text = "AñadirRegistro";
            this.btnAñadirRegistro.UseVisualStyleBackColor = true;
            this.btnAñadirRegistro.Click += new System.EventHandler(this.btnAñadirRegistro_Click);
            // 
            // time2
            // 
            this.time2.Location = new System.Drawing.Point(382, 97);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(58, 20);
            this.time2.TabIndex = 44;
            this.time2.Text = "8:00:00";
            // 
            // time1
            // 
            this.time1.Location = new System.Drawing.Point(382, 71);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(58, 20);
            this.time1.TabIndex = 43;
            this.time1.Text = "7:00:00";
            // 
            // txtDato6
            // 
            this.txtDato6.Location = new System.Drawing.Point(158, 148);
            this.txtDato6.Name = "txtDato6";
            this.txtDato6.Size = new System.Drawing.Size(100, 20);
            this.txtDato6.TabIndex = 25;
            this.txtDato6.Text = "6";
            // 
            // dateTime1
            // 
            this.dateTime1.Location = new System.Drawing.Point(357, 37);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(148, 20);
            this.dateTime1.TabIndex = 25;
            // 
            // txtDato3
            // 
            this.txtDato3.Location = new System.Drawing.Point(158, 69);
            this.txtDato3.Name = "txtDato3";
            this.txtDato3.Size = new System.Drawing.Size(100, 20);
            this.txtDato3.TabIndex = 22;
            this.txtDato3.Text = "3";
            // 
            // txtDato1
            // 
            this.txtDato1.Location = new System.Drawing.Point(158, 15);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(100, 20);
            this.txtDato1.TabIndex = 20;
            // 
            // txtDato5
            // 
            this.txtDato5.Location = new System.Drawing.Point(158, 122);
            this.txtDato5.Name = "txtDato5";
            this.txtDato5.Size = new System.Drawing.Size(100, 20);
            this.txtDato5.TabIndex = 24;
            this.txtDato5.Text = "5";
            // 
            // txtDato4
            // 
            this.txtDato4.Location = new System.Drawing.Point(158, 95);
            this.txtDato4.Name = "txtDato4";
            this.txtDato4.Size = new System.Drawing.Size(100, 20);
            this.txtDato4.TabIndex = 23;
            this.txtDato4.Text = "4";
            // 
            // txtDato2
            // 
            this.txtDato2.Location = new System.Drawing.Point(158, 43);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(100, 20);
            this.txtDato2.TabIndex = 21;
            this.txtDato2.Text = "2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtColumna);
            this.groupBox1.Controls.Add(this.txtNuevoDato);
            this.groupBox1.Controls.Add(this.btnModificarRegistro);
            this.groupBox1.Location = new System.Drawing.Point(20, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 75);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Seleccionar columna a editar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "escribir nuevo dato";
            // 
            // txtColumna
            // 
            this.txtColumna.Location = new System.Drawing.Point(158, 18);
            this.txtColumna.Name = "txtColumna";
            this.txtColumna.Size = new System.Drawing.Size(200, 20);
            this.txtColumna.TabIndex = 19;
            // 
            // txtNuevoDato
            // 
            this.txtNuevoDato.Location = new System.Drawing.Point(158, 43);
            this.txtNuevoDato.Name = "txtNuevoDato";
            this.txtNuevoDato.Size = new System.Drawing.Size(200, 20);
            this.txtNuevoDato.TabIndex = 25;
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.Location = new System.Drawing.Point(382, 31);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Size = new System.Drawing.Size(118, 23);
            this.btnModificarRegistro.TabIndex = 23;
            this.btnModificarRegistro.Text = "Modificar registro";
            this.btnModificarRegistro.UseVisualStyleBackColor = true;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtIndice);
            this.groupBox4.Controls.Add(this.bntEliminarRegistro);
            this.groupBox4.Location = new System.Drawing.Point(20, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(511, 42);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Seleccionar numero de indice";
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(159, 11);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(200, 20);
            this.txtIndice.TabIndex = 20;
            // 
            // bntEliminarRegistro
            // 
            this.bntEliminarRegistro.BackColor = System.Drawing.Color.Gainsboro;
            this.bntEliminarRegistro.Location = new System.Drawing.Point(382, 8);
            this.bntEliminarRegistro.Name = "bntEliminarRegistro";
            this.bntEliminarRegistro.Size = new System.Drawing.Size(118, 24);
            this.bntEliminarRegistro.TabIndex = 15;
            this.bntEliminarRegistro.Text = "eliminar registro";
            this.bntEliminarRegistro.UseVisualStyleBackColor = false;
            this.bntEliminarRegistro.Click += new System.EventHandler(this.bntEliminarRegistro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbMenuDeTrablas);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Location = new System.Drawing.Point(20, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 38);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seleccionar tabla para mostrar";
            // 
            // cbMenuDeTrablas
            // 
            this.cbMenuDeTrablas.BackColor = System.Drawing.SystemColors.Window;
            this.cbMenuDeTrablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuDeTrablas.Enabled = false;
            this.cbMenuDeTrablas.FormattingEnabled = true;
            this.cbMenuDeTrablas.Items.AddRange(new object[] {
            "Convenio",
            "Consultorio",
            "Diagnostico",
            "Enfermedad",
            "Enfermera",
            "HorarioMedico",
            "Planta",
            "Recepcionista",
            "Paciente",
            "HistoriaClinica",
            "Medico",
            "Consulta",
            "PaseVisita",
            "Cama",
            "Receta",
            "FabricanteMedicina",
            "Farmacia",
            "ProveedorMedicina",
            "Medicina",
            "Farmaceutico",
            "AlmacenMedicina",
            "AlmacenInstrumental",
            "FabricanteInstrumental",
            "ProveedorInstrumental",
            "InstrumentalMedico",
            "ExamenLaboratorio",
            "Laboratorio",
            "Laboratorista",
            "ExamenRadiologo",
            "Radiologia",
            "Radiologo",
            "CertificadoRecoleccion",
            "CertificadoSanitizacion",
            "FacturaMantenimiento",
            "Mantenimiento",
            "TecnicoMantenimiento",
            "RecoleccionBiologica",
            "RecolectoraBiologica",
            "Sanitizacion",
            "Sanitizadora",
            "Administrador",
            "Caja",
            "ReporteIngresos",
            "Cajero",
            "FacturaConsulta",
            "Nomina",
            "Emergencias",
            "Ambulancia",
            "Conductor",
            "HospitalExterno",
            "RecepcionistaConsulta",
            "RecepcionistaPaciente",
            "MedicoPaciente",
            "EnfermeraPaciente",
            "MedicoDiagnostico",
            "DiagnosticoPaciente",
            "PacienteEnfermedad",
            "DiagnosticoEnfermedad",
            "RecetaMedicina",
            "MedicinaFarmaceutico",
            "AlmacenMedicinaMedicina",
            "MedicoExamenRadiologo",
            "MedicoExamenLaboratorio",
            "LaboratoristaExamenLaboratorio",
            "RadiologoExamenRadiologo",
            "ConsultorioMantenimiento",
            "ConsultorioSanitizacion",
            "ConsultorioRecoleccion",
            "TecnicoMantenimientoMantenimiento",
            "SanitizadoraSanitizacion",
            "RecolectoraRecoleccion",
            "FacturaMantenimientoTecnico",
            "CertificadoSanitizadora",
            "CertificadoRecolectora",
            "NominaMedico",
            "FacturaConsultaMedico",
            "ReporteIngresosCajero",
            "AmbulanciaConductor"});
            this.cbMenuDeTrablas.Location = new System.Drawing.Point(158, 13);
            this.cbMenuDeTrablas.Name = "cbMenuDeTrablas";
            this.cbMenuDeTrablas.Size = new System.Drawing.Size(200, 21);
            this.cbMenuDeTrablas.TabIndex = 17;
            this.cbMenuDeTrablas.SelectedIndexChanged += new System.EventHandler(this.cbMenuDeTrablas_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(382, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(118, 21);
            this.btnSelect.TabIndex = 14;
            this.btnSelect.Text = "Ejecutar select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxSecundario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxParaConexion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion con bases de datos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxParaConexion.ResumeLayout(false);
            this.groupBoxParaConexion.PerformLayout();
            this.groupBoxSecundario.ResumeLayout(false);
            this.groupBoxSecundario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbMenuServidores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarTablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.GroupBox groupBoxParaConexion;
        private System.Windows.Forms.ToolStripMenuItem agregarUnRegistroToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxSecundario;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.TextBox txtDato3;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.TextBox txtDato5;
        private System.Windows.Forms.TextBox txtDato4;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.TextBox txtDato6;
        private System.Windows.Forms.TextBox time2;
        private System.Windows.Forms.TextBox time1;
        private System.Windows.Forms.Button btnAñadirRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColumna;
        private System.Windows.Forms.TextBox txtNuevoDato;
        private System.Windows.Forms.Button btnModificarRegistro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Button bntEliminarRegistro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMenuDeTrablas;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTextoDato6;
        private System.Windows.Forms.Label lblTextoDato5;
        private System.Windows.Forms.Label lblTextoDato4;
        private System.Windows.Forms.Label lblTextoDato3;
        private System.Windows.Forms.Label lblTextoDato2;
        private System.Windows.Forms.Label lblTextoDato1;
    }
}

