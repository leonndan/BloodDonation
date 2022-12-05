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
    public partial class Banco : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Banco()
        {
            InitializeComponent();
            conn.Open();
            dataGridBanco.DataSource = Consultar();
        }
        public DataTable Consultar()
        {
            string query = "select id_donacion,volumen,fecha,fecha_util,tipo_donacion,tipo_sangre,curp_donador,curp_enfermero from \"donacion\"";
            NpgsqlCommand connector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public DataTable Consultar_Nombre(string nom)
        {
            string query = "select * from \"bolsa_sangre\" where \"id_bolsa\"= '" + nom + "'";
            NpgsqlCommand connector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public void Eliminar(string n)
        {
            string query = "Delete from \"donacion\"" + "where \"id_donacion\"='" + n + "'";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            dataGridBanco.DataSource = Consultar_Nombre(txt_Consulta_Banco.Text);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Banco.Text))
            {
                MessageBox.Show("Favor de ingresar el ID!");
            }
            else
            {
                Agregar_unidad ag = new Agregar_unidad();
                ag.bandera(true);
                ag.Show();
                this.Close();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Banco.Text))
            {
                MessageBox.Show("Favor de ingresar el ID!");
            }
            else
            {
                Eliminar(txt_Consulta_Banco.Text);
                MessageBox.Show("Registro Eliminado!");
                this.Close();
            }
        }
    }
}
