namespace WinFormsApp1
{
    partial class Agregar_unidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_unidad));
            this.label1 = new System.Windows.Forms.Label();
            this.comboEnferemero = new System.Windows.Forms.ComboBox();
            this.comboDonador = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericVolumen = new System.Windows.Forms.NumericUpDown();
            this.combo_TipoSangre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tipo_donacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(281, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTRO DE SANGRE";
            // 
            // comboEnferemero
            // 
            this.comboEnferemero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEnferemero.FormattingEnabled = true;
            this.comboEnferemero.Location = new System.Drawing.Point(332, 111);
            this.comboEnferemero.Name = "comboEnferemero";
            this.comboEnferemero.Size = new System.Drawing.Size(171, 23);
            this.comboEnferemero.TabIndex = 3;
            this.comboEnferemero.SelectedIndexChanged += new System.EventHandler(this.comboEnferemero_SelectedIndexChanged);
            // 
            // comboDonador
            // 
            this.comboDonador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDonador.FormattingEnabled = true;
            this.comboDonador.Location = new System.Drawing.Point(565, 111);
            this.comboDonador.Name = "comboDonador";
            this.comboDonador.Size = new System.Drawing.Size(169, 23);
            this.comboDonador.TabIndex = 4;
            this.comboDonador.SelectedIndexChanged += new System.EventHandler(this.comboDonador_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(312, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "VOLUMEN DE DONACION(ML)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(353, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "ENFERMERO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(591, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "DONADOR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(312, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "VIDA UTIL";
            // 
            // numericVolumen
            // 
            this.numericVolumen.Location = new System.Drawing.Point(312, 181);
            this.numericVolumen.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericVolumen.Name = "numericVolumen";
            this.numericVolumen.Size = new System.Drawing.Size(120, 23);
            this.numericVolumen.TabIndex = 15;
            // 
            // combo_TipoSangre
            // 
            this.combo_TipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_TipoSangre.FormattingEnabled = true;
            this.combo_TipoSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.combo_TipoSangre.Location = new System.Drawing.Point(45, 352);
            this.combo_TipoSangre.Name = "combo_TipoSangre";
            this.combo_TipoSangre.Size = new System.Drawing.Size(121, 23);
            this.combo_TipoSangre.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(45, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "TIPO DE SANGRE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(502, 229);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Agregar.Location = new System.Drawing.Point(644, 503);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(90, 41);
            this.btn_Agregar.TabIndex = 20;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(45, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "TIPO DE DONACION";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd ";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(283, 265);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // tipo_donacion
            // 
            this.tipo_donacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_donacion.FormattingEnabled = true;
            this.tipo_donacion.Items.AddRange(new object[] {
            "Globulos rojos",
            "Plaquetas",
            "Plasma",
            "Sangre completa"});
            this.tipo_donacion.Location = new System.Drawing.Point(45, 265);
            this.tipo_donacion.Name = "tipo_donacion";
            this.tipo_donacion.Size = new System.Drawing.Size(169, 23);
            this.tipo_donacion.TabIndex = 28;
            // 
            // Agregar_unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(816, 555);
            this.Controls.Add(this.tipo_donacion);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_TipoSangre);
            this.Controls.Add(this.numericVolumen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboDonador);
            this.Controls.Add(this.comboEnferemero);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Agregar_unidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_unidad";
            this.Load += new System.EventHandler(this.Agregar_unidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboEnferemero;
        private ComboBox comboDonador;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericVolumen;
        private ComboBox combo_TipoSangre;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btn_Agregar;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private ComboBox tipo_donacion;
    }
}