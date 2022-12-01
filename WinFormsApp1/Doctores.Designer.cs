namespace WinFormsApp1
{
    partial class Doctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Consulta_Doc = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.button_Consulta = new System.Windows.Forms.Button();
            this.datagridMedicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÉDICOS";
            // 
            // txt_Consulta_Doc
            // 
            this.txt_Consulta_Doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Consulta_Doc.Location = new System.Drawing.Point(27, 77);
            this.txt_Consulta_Doc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Consulta_Doc.Name = "txt_Consulta_Doc";
            this.txt_Consulta_Doc.Size = new System.Drawing.Size(170, 23);
            this.txt_Consulta_Doc.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(202, 77);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Editar.Location = new System.Drawing.Point(334, 376);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(82, 22);
            this.btn_Editar.TabIndex = 6;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(115, 376);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(82, 22);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Consulta
            // 
            this.button_Consulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Consulta.Location = new System.Drawing.Point(564, 376);
            this.button_Consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Consulta.Name = "button_Consulta";
            this.button_Consulta.Size = new System.Drawing.Size(82, 22);
            this.button_Consulta.TabIndex = 8;
            this.button_Consulta.Text = "Consultar";
            this.button_Consulta.UseVisualStyleBackColor = false;
            this.button_Consulta.Click += new System.EventHandler(this.button_Consulta_Click);
            // 
            // datagridMedicos
            // 
            this.datagridMedicos.AllowUserToAddRows = false;
            this.datagridMedicos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridMedicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridMedicos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMedicos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridMedicos.Location = new System.Drawing.Point(27, 104);
            this.datagridMedicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridMedicos.Name = "datagridMedicos";
            this.datagridMedicos.ReadOnly = true;
            this.datagridMedicos.RowHeadersWidth = 51;
            this.datagridMedicos.RowTemplate.Height = 29;
            this.datagridMedicos.Size = new System.Drawing.Size(742, 241);
            this.datagridMedicos.TabIndex = 11;
            // 
            // Doctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(799, 440);
            this.Controls.Add(this.datagridMedicos);
            this.Controls.Add(this.button_Consulta);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_Consulta_Doc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Doctores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctores";
            this.Load += new System.EventHandler(this.Doctores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txt_Consulta_Doc;
        private PictureBox pictureBox2;
        private Button btn_Editar;
        private Button btn_Eliminar;
        private Button button_Consulta;
        private DataGridView datagridMedicos;
    }
}