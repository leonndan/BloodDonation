using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    public partial class Pacientescs : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");

        public Pacientescs()
        {
            InitializeComponent();
            conn.Open();
            dataGridPaciente.DataSource = Consultar();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Pac.Text))
            {
                MessageBox.Show("Favor de ingresar el Nombre!");
            }
            else
            {
                dataGridPaciente.DataSource = Consultar_Nombre(txt_Consulta_Pac.Text);
            }
        }
        public DataTable Consultar()
        {
            string query = "select curp,nombre,ap_paterno,ap_materno,telefono,correo,tipo_sangre,enfermero_encargado,medico_encargado from \"pacientes\"";
            NpgsqlCommand connector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public DataTable Consultar_Nombre(string nom)
        {
            string query = "select * from \"pacientes\" where \"nombre\"= '" + nom + "'";
            NpgsqlCommand connector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void Eliminar(string n)
        {
            NpgsqlCommand cm = new NpgsqlCommand("Select curp from pacientes where curp = '" + n + "'", conn);
            conn.Open();
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                string query = "Delete from \"pacientes\"" + "where \"curp\"='" + n + "'";
                NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
                ejecutor.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario no existe!");
                conn.Close();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Pac.Text))
            {
                MessageBox.Show("Favor de ingresar la CURP!");
            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
                NpgsqlCommand cm = new NpgsqlCommand("Select curp from pacientes where curp = '" + txt_Consulta_Pac.Text + "'", conn);
                conn.Open();
                NpgsqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    conn.Close();
                    conn.Open();
                    Agregar_enfermerocs ag = new Agregar_enfermerocs();
                    ag.bandera(true);
                    ag.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario no existe!");
                    conn.Close();
                }
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Pac.Text))
            {
                MessageBox.Show("Favor de ingresar la CURP!");
            }
            else
            {
                Eliminar(txt_Consulta_Pac.Text);
            }

        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Pac.Text))
            {
                MessageBox.Show("Favor de ingresar la CURP!");
            }
            else
            {
                Eliminar(txt_Consulta_Pac.Text);
                
            }

        }

        private void btn_Editar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Pac.Text))
            {
                MessageBox.Show("Favor de ingresar la CURP!");
            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
                NpgsqlCommand cm = new NpgsqlCommand("Select curp from pacientes where curp = '" + txt_Consulta_Pac.Text + "'", conn);
                conn.Open();
                NpgsqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    Agregar_enfermerocs ag = new Agregar_enfermerocs();
                    ag.bandera(true);
                    ag.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario no existe!");
                }
            }
        }
    }
}
