namespace WinFormsApp1
{
    partial class Enfermero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enfermero));
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Consulta_Enfermero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridEnfermero = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnfermero)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Consulta.Location = new System.Drawing.Point(592, 392);
            this.btn_Consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(82, 22);
            this.btn_Consulta.TabIndex = 15;
            this.btn_Consulta.Text = "Consultar";
            this.btn_Consulta.UseVisualStyleBackColor = false;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Editar.Location = new System.Drawing.Point(374, 392);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(82, 22);
            this.btn_Editar.TabIndex = 14;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(158, 392);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(82, 22);
            this.btn_Eliminar.TabIndex = 13;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(213, 94);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Consulta_Enfermero
            // 
            this.txt_Consulta_Enfermero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Consulta_Enfermero.Location = new System.Drawing.Point(38, 94);
            this.txt_Consulta_Enfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Consulta_Enfermero.Name = "txt_Consulta_Enfermero";
            this.txt_Consulta_Enfermero.Size = new System.Drawing.Size(170, 23);
            this.txt_Consulta_Enfermero.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(318, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ENFERMEROS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridEnfermero
            // 
            this.dataGridEnfermero.AllowUserToAddRows = false;
            this.dataGridEnfermero.AllowUserToDeleteRows = false;
            this.dataGridEnfermero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridEnfermero.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridEnfermero.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridEnfermero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEnfermero.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridEnfermero.Location = new System.Drawing.Point(38, 121);
            this.dataGridEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridEnfermero.Name = "dataGridEnfermero";
            this.dataGridEnfermero.ReadOnly = true;
            this.dataGridEnfermero.RowHeadersWidth = 51;
            this.dataGridEnfermero.RowTemplate.Height = 29;
            this.dataGridEnfermero.Size = new System.Drawing.Size(742, 241);
            this.dataGridEnfermero.TabIndex = 16;
            // 
            // Enfermero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(799, 440);
            this.Controls.Add(this.dataGridEnfermero);
            this.Controls.Add(this.btn_Consulta);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_Consulta_Enfermero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Enfermero";
            this.Text = "Enfermero";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnfermero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Consulta;
        private Button btn_Editar;
        private Button btn_Eliminar;
        private PictureBox pictureBox2;
        private TextBox txt_Consulta_Enfermero;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridEnfermero;
    }
}