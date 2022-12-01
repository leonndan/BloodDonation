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
    public partial class Doctores : Form

    {
     
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Doctores()
        {
            InitializeComponent();
            conn.Open();
            datagridMedicos.DataSource = Consultar();

        }

        private void Doctores_Load(object sender, EventArgs e)
        {

        }

        private void datagridMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataTable Consultar()
        {
            string query = "select \"curp\",\"nombre\",\"apellido_paterno\",\"apellido_materno\",\"telefono\",\"correo\",\"cedula\"  from \"medico\"";
            NpgsqlCommand connector= new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos= new NpgsqlDataAdapter(connector);
            DataTable tabla= new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public DataTable Consultar_Nombre(string nom)
        {
            string query = "select id,curp,nombre,apellido_paterno,apellido_materno,telefono,correo,cedula  from \"medico\" where \"nombre\"= '" + nom+"'";
            NpgsqlCommand connector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        private void btn_Consultar(object sender, EventArgs e)
        {
          
          
          
            
        }

        private void button_Consulta_Click(object sender, EventArgs e)
        {
            datagridMedicos.DataSource = Consultar_Nombre(txt_Consulta_Doc.Text);
        }
        public void Eliminar(string n)
        {
            string query = "Delete from \"medico\"" + "where \"curp\"='" + n + "'";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Doc.Text))
            {
                MessageBox.Show("Favor de ingresar la CURP!");
            }
            else
            {
                Eliminar(txt_Consulta_Doc.Text);
                MessageBox.Show("Registro Eliminado!");
            }

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Doc.Text))
            {
                MessageBox.Show("Favor de ingresar la CURP!");
            }
            else
            {
                Agregar_medico ag = new Agregar_medico();
                ag.bandera(true);
                ag.Show();
                this.Close();
            }

        }
    }
}
