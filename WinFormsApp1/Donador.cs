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
    public partial class Donador : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Donador()
        {
            InitializeComponent();
            conn.Open();
            dataGridDonador.DataSource = Consultar();
            conn.Close();
        }
        public DataTable Consultar()
        {
            string query = "select * from \"donador\"";
            NpgsqlCommand connector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public DataTable Consultar_Nombre(string nom)
        {
            string query = "select * from \"donador\" where \"nombre\"= '" + nom + "'";
            NpgsqlCommand connector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public void Eliminar(string n)
        {
            NpgsqlCommand cm = new NpgsqlCommand("Select curp from donador where curp = '" + n + "'", conn);
            conn.Open();
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                string query = "Delete from \"donador\"" + "where \"curp\"='" + n + "'";
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
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Don.Text))
            {
                MessageBox.Show("Favor de ingresar la CURP!");
            }
            else
            {
                dataGridDonador.DataSource = Consultar_Nombre(txt_Consulta_Don.Text);
            }
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Don.Text))
            {
                MessageBox.Show("Favor de ingresar la CURP!");
            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
                NpgsqlCommand cm = new NpgsqlCommand("Select curp from donador where curp = '" + txt_Consulta_Don.Text + "'", conn);
                conn.Open();
                NpgsqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    Agregar_donador ag = new Agregar_donador();
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Don.Text))
            {
                MessageBox.Show("Favor de ingresar la CURP!");
            }
            else
            {
                Eliminar(txt_Consulta_Don.Text);
                
            }
        }
    }
}
