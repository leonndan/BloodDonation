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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridPaciente.DataSource = Consultar_Nombre(txt_Consulta_Pac.Text);
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
    }
}
