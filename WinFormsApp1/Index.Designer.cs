namespace WinFormsApp1
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fewewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedientePacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEnfermeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEnfermeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDonadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDonadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeSangreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sangreUnidadBolsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fewewToolStripMenuItem,
            this.daadToolStripMenuItem,
            this.enfermerosToolStripMenuItem,
            this.donadoresToolStripMenuItem,
            this.bancoDeSangreToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(946, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.nuevoUsuarioToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // fewewToolStripMenuItem
            // 
            this.fewewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPacienteToolStripMenuItem,
            this.consultarPacienteToolStripMenuItem,
            this.expedientePacienteToolStripMenuItem});
            this.fewewToolStripMenuItem.Name = "fewewToolStripMenuItem";
            this.fewewToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.fewewToolStripMenuItem.Text = "Pacientes";
            this.fewewToolStripMenuItem.Click += new System.EventHandler(this.fewewToolStripMenuItem_Click);
            // 
            // registrarPacienteToolStripMenuItem
            // 
            this.registrarPacienteToolStripMenuItem.Name = "registrarPacienteToolStripMenuItem";
            this.registrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.registrarPacienteToolStripMenuItem.Text = "Registrar Paciente";
            this.registrarPacienteToolStripMenuItem.Click += new System.EventHandler(this.registrarPacienteToolStripMenuItem_Click);
            // 
            // consultarPacienteToolStripMenuItem
            // 
            this.consultarPacienteToolStripMenuItem.Name = "consultarPacienteToolStripMenuItem";
            this.consultarPacienteToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.consultarPacienteToolStripMenuItem.Text = "Consultar Paciente";
            this.consultarPacienteToolStripMenuItem.Click += new System.EventHandler(this.consultarPacienteToolStripMenuItem_Click);
            // 
            // expedientePacienteToolStripMenuItem
            // 
            this.expedientePacienteToolStripMenuItem.Name = "expedientePacienteToolStripMenuItem";
            this.expedientePacienteToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.expedientePacienteToolStripMenuItem.Text = "Expediente Paciente";
            // 
            // daadToolStripMenuItem
            // 
            this.daadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarMédicoToolStripMenuItem,
            this.consultarMédicoToolStripMenuItem});
            this.daadToolStripMenuItem.Name = "daadToolStripMenuItem";
            this.daadToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.daadToolStripMenuItem.Text = "Médicos";
            this.daadToolStripMenuItem.Click += new System.EventHandler(this.daadToolStripMenuItem_Click);
            // 
            // registrarMédicoToolStripMenuItem
            // 
            this.registrarMédicoToolStripMenuItem.Name = "registrarMédicoToolStripMenuItem";
            this.registrarMédicoToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.registrarMédicoToolStripMenuItem.Text = "Registrar Médico";
            this.registrarMédicoToolStripMenuItem.Click += new System.EventHandler(this.registrarMédicoToolStripMenuItem_Click);
            // 
            // consultarMédicoToolStripMenuItem
            // 
            this.consultarMédicoToolStripMenuItem.Name = "consultarMédicoToolStripMenuItem";
            this.consultarMédicoToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.consultarMédicoToolStripMenuItem.Text = "Consultar Médico";
            this.consultarMédicoToolStripMenuItem.Click += new System.EventHandler(this.consultarMédicoToolStripMenuItem_Click);
            // 
            // enfermerosToolStripMenuItem
            // 
            this.enfermerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEnfermeroToolStripMenuItem,
            this.consultarEnfermeroToolStripMenuItem});
            this.enfermerosToolStripMenuItem.Name = "enfermerosToolStripMenuItem";
            this.enfermerosToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.enfermerosToolStripMenuItem.Text = "Enfermeros";
            // 
            // registrarEnfermeroToolStripMenuItem
            // 
            this.registrarEnfermeroToolStripMenuItem.Name = "registrarEnfermeroToolStripMenuItem";
            this.registrarEnfermeroToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.registrarEnfermeroToolStripMenuItem.Text = "Registrar Enfermero";
            this.registrarEnfermeroToolStripMenuItem.Click += new System.EventHandler(this.registrarEnfermeroToolStripMenuItem_Click);
            // 
            // consultarEnfermeroToolStripMenuItem
            // 
            this.consultarEnfermeroToolStripMenuItem.Name = "consultarEnfermeroToolStripMenuItem";
            this.consultarEnfermeroToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.consultarEnfermeroToolStripMenuItem.Text = "Consultar Enfermero";
            this.consultarEnfermeroToolStripMenuItem.Click += new System.EventHandler(this.consultarEnfermeroToolStripMenuItem_Click);
            // 
            // donadoresToolStripMenuItem
            // 
            this.donadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarDonadorToolStripMenuItem,
            this.consultarDonadorToolStripMenuItem});
            this.donadoresToolStripMenuItem.Name = "donadoresToolStripMenuItem";
            this.donadoresToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.donadoresToolStripMenuItem.Text = "Donadores";
            // 
            // registrarDonadorToolStripMenuItem
            // 
            this.registrarDonadorToolStripMenuItem.Name = "registrarDonadorToolStripMenuItem";
            this.registrarDonadorToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.registrarDonadorToolStripMenuItem.Text = "Registrar Donador";
            this.registrarDonadorToolStripMenuItem.Click += new System.EventHandler(this.registrarDonadorToolStripMenuItem_Click);
            // 
            // consultarDonadorToolStripMenuItem
            // 
            this.consultarDonadorToolStripMenuItem.Name = "consultarDonadorToolStripMenuItem";
            this.consultarDonadorToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.consultarDonadorToolStripMenuItem.Text = "Consultar Donador";
            this.consultarDonadorToolStripMenuItem.Click += new System.EventHandler(this.consultarDonadorToolStripMenuItem_Click);
            // 
            // bancoDeSangreToolStripMenuItem
            // 
            this.bancoDeSangreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarInventarioToolStripMenuItem,
            this.bancoToolStripMenuItem,
            this.sangreUnidadBolsaToolStripMenuItem});
            this.bancoDeSangreToolStripMenuItem.Name = "bancoDeSangreToolStripMenuItem";
            this.bancoDeSangreToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.bancoDeSangreToolStripMenuItem.Text = "Banco de sangre";
            this.bancoDeSangreToolStripMenuItem.Click += new System.EventHandler(this.bancoDeSangreToolStripMenuItem_Click);
            // 
            // agregarInventarioToolStripMenuItem
            // 
            this.agregarInventarioToolStripMenuItem.Name = "agregarInventarioToolStripMenuItem";
            this.agregarInventarioToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.agregarInventarioToolStripMenuItem.Text = "Agregar Insumo";
            this.agregarInventarioToolStripMenuItem.Click += new System.EventHandler(this.agregarInventarioToolStripMenuItem_Click);
            // 
            // bancoToolStripMenuItem
            // 
            this.bancoToolStripMenuItem.Name = "bancoToolStripMenuItem";
            this.bancoToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.bancoToolStripMenuItem.Text = "Banco";
            this.bancoToolStripMenuItem.Click += new System.EventHandler(this.bancoToolStripMenuItem_Click);
            // 
            // sangreUnidadBolsaToolStripMenuItem
            // 
            this.sangreUnidadBolsaToolStripMenuItem.Name = "sangreUnidadBolsaToolStripMenuItem";
            this.sangreUnidadBolsaToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.sangreUnidadBolsaToolStripMenuItem.Text = "Sangre/Unidad/Bolsa";
            this.sangreUnidadBolsaToolStripMenuItem.Click += new System.EventHandler(this.sangreUnidadBolsaToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(336, 417);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(336, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "BloodDonation+";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(298, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(946, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fewewToolStripMenuItem;
        private ToolStripMenuItem daadToolStripMenuItem;
        private ToolStripMenuItem enfermerosToolStripMenuItem;
        private ToolStripMenuItem donadoresToolStripMenuItem;
        private ToolStripMenuItem bancoDeSangreToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private PictureBox pictureBox1;
        private PageSetupDialog pageSetupDialog1;
        private ToolStripMenuItem registrarPacienteToolStripMenuItem;
        private ToolStripMenuItem registrarMédicoToolStripMenuItem;
        private ToolStripMenuItem registrarEnfermeroToolStripMenuItem;
        private ToolStripMenuItem registrarDonadorToolStripMenuItem;
        private ToolStripMenuItem consultarPacienteToolStripMenuItem;
        private ToolStripMenuItem expedientePacienteToolStripMenuItem;
        private ToolStripMenuItem consultarMédicoToolStripMenuItem;
        private ToolStripMenuItem consultarEnfermeroToolStripMenuItem;
        private ToolStripMenuItem consultarDonadorToolStripMenuItem;
        private ToolStripMenuItem agregarInventarioToolStripMenuItem;
        private ToolStripMenuItem bancoToolStripMenuItem;
        private ToolStripMenuItem sangreUnidadBolsaToolStripMenuItem;
        private ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
    }
}