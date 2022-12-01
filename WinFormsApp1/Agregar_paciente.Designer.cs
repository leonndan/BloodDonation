namespace WinFormsApp1
{
    partial class Agregar_paciente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_paciente));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CURP = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Materno = new System.Windows.Forms.TextBox();
            this.txt_Paterno = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.comboEnfermero = new System.Windows.Forms.ComboBox();
            this.comboMedico = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_agregar = new System.Windows.Forms.Button();
            this.comboSangre = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PACIENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_CURP
            // 
            this.txt_CURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CURP.Location = new System.Drawing.Point(43, 92);
            this.txt_CURP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CURP.MaxLength = 18;
            this.txt_CURP.Name = "txt_CURP";
            this.txt_CURP.Size = new System.Drawing.Size(196, 23);
            this.txt_CURP.TabIndex = 1;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(546, 164);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(196, 23);
            this.txt_Email.TabIndex = 2;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(288, 164);
            this.txt_Telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Telefono.MaxLength = 10;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(196, 23);
            this.txt_Telefono.TabIndex = 3;
            // 
            // txt_Materno
            // 
            this.txt_Materno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Materno.Location = new System.Drawing.Point(43, 164);
            this.txt_Materno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Materno.Name = "txt_Materno";
            this.txt_Materno.Size = new System.Drawing.Size(196, 23);
            this.txt_Materno.TabIndex = 4;
            // 
            // txt_Paterno
            // 
            this.txt_Paterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Paterno.Location = new System.Drawing.Point(546, 92);
            this.txt_Paterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Paterno.Name = "txt_Paterno";
            this.txt_Paterno.Size = new System.Drawing.Size(196, 23);
            this.txt_Paterno.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nombre.Location = new System.Drawing.Point(288, 92);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(196, 23);
            this.txt_Nombre.TabIndex = 6;
            // 
            // comboEnfermero
            // 
            this.comboEnfermero.FormattingEnabled = true;
            this.comboEnfermero.Location = new System.Drawing.Point(43, 344);
            this.comboEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboEnfermero.Name = "comboEnfermero";
            this.comboEnfermero.Size = new System.Drawing.Size(196, 23);
            this.comboEnfermero.TabIndex = 10;
            // 
            // comboMedico
            // 
            this.comboMedico.FormattingEnabled = true;
            this.comboMedico.Location = new System.Drawing.Point(43, 422);
            this.comboMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboMedico.Name = "comboMedico";
            this.comboMedico.Size = new System.Drawing.Size(196, 23);
            this.comboMedico.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 258);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "CURP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(546, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "APELLIDO PATERNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "APELLIDO MATERNO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(288, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "TELEFONO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(546, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "CORREO ELECTRONICO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(42, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "TIPO DE SANGRE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(42, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "ENFERMERO A CARGO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(42, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "MÉDICO A CARGO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(288, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "NOMBRE";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.Location = new System.Drawing.Point(660, 505);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(109, 32);
            this.btn_agregar.TabIndex = 22;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboSangre
            // 
            this.comboSangre.FormattingEnabled = true;
            this.comboSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.comboSangre.Location = new System.Drawing.Point(43, 283);
            this.comboSangre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSangre.Name = "comboSangre";
            this.comboSangre.Size = new System.Drawing.Size(196, 23);
            this.comboSangre.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(43, 460);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "ID";
            // 
            // numericID
            // 
            this.numericID.Location = new System.Drawing.Point(43, 488);
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(120, 23);
            this.numericID.TabIndex = 25;
            // 
            // Agregar_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(814, 561);
            this.Controls.Add(this.numericID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboSangre);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboMedico);
            this.Controls.Add(this.comboEnfermero);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Paterno);
            this.Controls.Add(this.txt_Materno);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_CURP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Agregar_paciente";
            this.Text = "Agregar_paciente";
            this.Load += new System.EventHandler(this.Agregar_paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_CURP;
        private TextBox txt_Email;
        private TextBox txt_Telefono;
        private TextBox txt_Materno;
        private TextBox txt_Paterno;
        private TextBox txt_Nombre;
        private ComboBox comboEnfermero;
        private ComboBox comboMedico;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ContextMenuStrip contextMenuStrip1;
        private Button btn_agregar;
        private ComboBox comboSangre;
        private Label label11;
        private NumericUpDown numericID;
    }
}