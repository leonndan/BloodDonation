namespace WinFormsApp1
{
    partial class Agregar_donador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_donador));
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.txt_materno = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_curp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipo_Sangre = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.elegibilidad = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Insert.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Insert.Location = new System.Drawing.Point(662, 500);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(109, 32);
            this.btn_Insert.TabIndex = 67;
            this.btn_Insert.Text = "Agregar";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(290, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 66;
            this.label10.Text = "NOMBRE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(44, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 63;
            this.label7.Text = "TIPO DE SANGRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(548, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "CORREO ELECTRONICO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(290, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 61;
            this.label5.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "APELLIDO MATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(548, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "APELLIDO PATERNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "CURP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 250);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(290, 86);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(196, 23);
            this.txt_nombre.TabIndex = 55;
            // 
            // txt_paterno
            // 
            this.txt_paterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_paterno.Location = new System.Drawing.Point(548, 86);
            this.txt_paterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(196, 23);
            this.txt_paterno.TabIndex = 54;
            // 
            // txt_materno
            // 
            this.txt_materno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_materno.Location = new System.Drawing.Point(45, 159);
            this.txt_materno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_materno.Name = "txt_materno";
            this.txt_materno.Size = new System.Drawing.Size(196, 23);
            this.txt_materno.TabIndex = 53;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(290, 159);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telefono.MaxLength = 10;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(196, 23);
            this.txt_telefono.TabIndex = 52;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(548, 159);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(196, 23);
            this.txt_email.TabIndex = 51;
            // 
            // txt_curp
            // 
            this.txt_curp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_curp.Location = new System.Drawing.Point(45, 86);
            this.txt_curp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_curp.MaxLength = 18;
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(196, 23);
            this.txt_curp.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(253, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "REGISTRO DE DONADOR";
            // 
            // tipo_Sangre
            // 
            this.tipo_Sangre.FormattingEnabled = true;
            this.tipo_Sangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.tipo_Sangre.Location = new System.Drawing.Point(44, 267);
            this.tipo_Sangre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipo_Sangre.Name = "tipo_Sangre";
            this.tipo_Sangre.Size = new System.Drawing.Size(196, 23);
            this.tipo_Sangre.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(290, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 75;
            this.label12.Text = "ELEGIBILIDAD";
            // 
            // elegibilidad
            // 
            this.elegibilidad.FormattingEnabled = true;
            this.elegibilidad.Items.AddRange(new object[] {
            "VERDADERO",
            "FALSO"});
            this.elegibilidad.Location = new System.Drawing.Point(290, 267);
            this.elegibilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elegibilidad.Name = "elegibilidad";
            this.elegibilidad.Size = new System.Drawing.Size(196, 23);
            this.elegibilidad.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(45, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 15);
            this.label13.TabIndex = 77;
            this.label13.Text = "ID";
            // 
            // numericID
            // 
            this.numericID.Location = new System.Drawing.Point(45, 350);
            this.numericID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(131, 23);
            this.numericID.TabIndex = 78;
            // 
            // Agregar_donador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(814, 533);
            this.Controls.Add(this.numericID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.elegibilidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tipo_Sangre);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_paterno);
            this.Controls.Add(this.txt_materno);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_curp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Agregar_donador";
            this.Text = "Agregar_donador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Insert;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txt_nombre;
        private TextBox txt_paterno;
        private TextBox txt_materno;
        private TextBox txt_telefono;
        private TextBox txt_email;
        private TextBox txt_curp;
        private Label label1;
        private ComboBox tipo_Sangre;
        private Label label12;
        private ComboBox elegibilidad;
        private Label label13;
        private NumericUpDown numericID;
    }
}