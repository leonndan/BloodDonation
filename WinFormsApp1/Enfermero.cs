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
    
    public partial class Enfermero : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Enfermero()
        {
            InitializeComponent();
            conn.Open();
            dataGridEnfermero.DataSource = Consultar();
            conn.Close();
        }
        public DataTable Consultar()
        {
            string query = "select curp,nombre,apellido_paterno,apellido_materno,telefono,correo,cedula  from \"enfermero\"";
            NpgsqlCommand connector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public DataTable Consultar_Nombre(string nom)
        {
            string query = "select id,curp,nombre,apellido_paterno,apellido_materno,telefono,correo,cedula from \"enfermero\" where \"nombre\"= '" + nom + "'";
            NpgsqlCommand connector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Enfermero.Text))
            {
                MessageBox.Show("Favor de ingresar el Nombre!");
                
            }
            else
            {
                dataGridEnfermero.DataSource = Consultar_Nombre(txt_Consulta_Enfermero.Text);
            }
        }
        
        public void Eliminar(string n)
        {
            NpgsqlCommand cm = new NpgsqlCommand("Select curp from enfermero where curp = '" + n + "'", conn);
            conn.Open();
            NpgsqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Open();
                string query = "Delete from \"enfermero\"" + "where \"curp\"='" + n + "'";
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
            if (string.IsNullOrEmpty(txt_Consulta_Enfermero.Text))
            {
                MessageBox.Show("Favor de ingresar la CURP!");
            }else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
                NpgsqlCommand cm = new NpgsqlCommand("Select curp from enfermero where curp = '" + txt_Consulta_Enfermero.Text + "'", conn);
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

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Enfermero.Text))
            {
                MessageBox.Show("Favor de ingresar la CURP!");
            }
            else
            {
                Eliminar(txt_Consulta_Enfermero.Text);
               ;
            }

        }
    }
}
