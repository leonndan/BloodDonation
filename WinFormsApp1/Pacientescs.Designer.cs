namespace WinFormsApp1
{
    partial class Pacientescs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacientescs));
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Consulta_Pac = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.dataGridPaciente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(75, 375);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(137, 22);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click_1);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Editar.Location = new System.Drawing.Point(328, 375);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(134, 22);
            this.btn_Editar.TabIndex = 5;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Consulta_Pac
            // 
            this.txt_Consulta_Pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Consulta_Pac.Location = new System.Drawing.Point(27, 60);
            this.txt_Consulta_Pac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Consulta_Pac.Name = "txt_Consulta_Pac";
            this.txt_Consulta_Pac.Size = new System.Drawing.Size(185, 23);
            this.txt_Consulta_Pac.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(217, 60);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Consulta.Location = new System.Drawing.Point(584, 375);
            this.btn_Consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(135, 22);
            this.btn_Consulta.TabIndex = 9;
            this.btn_Consulta.Text = "Consulta";
            this.btn_Consulta.UseVisualStyleBackColor = false;
            this.btn_Consulta.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridPaciente
            // 
            this.dataGridPaciente.AllowUserToAddRows = false;
            this.dataGridPaciente.AllowUserToDeleteRows = false;
            this.dataGridPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPaciente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPaciente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPaciente.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPaciente.Location = new System.Drawing.Point(27, 87);
            this.dataGridPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridPaciente.Name = "dataGridPaciente";
            this.dataGridPaciente.ReadOnly = true;
            this.dataGridPaciente.RowHeadersWidth = 51;
            this.dataGridPaciente.RowTemplate.Height = 29;
            this.dataGridPaciente.Size = new System.Drawing.Size(742, 241);
            this.dataGridPaciente.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "PACIENTES";
            // 
            // Pacientescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(799, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridPaciente);
            this.Controls.Add(this.btn_Consulta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_Consulta_Pac);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Eliminar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pacientescs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientescs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Eliminar;
        private Button btn_Editar;
        private PictureBox pictureBox1;
        private TextBox txt_Consulta_Pac;
        private PictureBox pictureBox2;
        private Button btn_Consulta;
        private DataGridView dataGridPaciente;
        private Label label2;
    }
}