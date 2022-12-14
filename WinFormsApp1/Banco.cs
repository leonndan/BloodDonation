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
            conn.Close();
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
            string query = "select * from \"donacion\" where \"id_donacion\"= '" + nom + "'";
            try
            {
                NpgsqlCommand connector = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, Solo valores numericos");
                string query1 = "select id_donacion,volumen,fecha,fecha_util,tipo_donacion,tipo_sangre,curp_donador,curp_enfermero from \"donacion\"";
                NpgsqlCommand connector = new NpgsqlCommand(query1, conn);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);

                return tabla;
            }

        }
        public void Eliminar(string n)
        {
            NpgsqlCommand cm = new NpgsqlCommand("Select id_donacion from donacion where id_donacion = '" + n + "'", conn);
            conn.Open();
            try
            {
                NpgsqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    conn.Close();
                    conn.Open();
                    string query = "Delete from \"donacion\"" + "where \"id_donacion\"='" + n + "'";
                    NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
                    ejecutor.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registro no existe!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, Solo valores numericos");
                conn.Close();
            }


        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Banco.Text))
            {
                MessageBox.Show("Favor de ingresar el ID!");
            }
            else
            {
                dataGridBanco.DataSource = Consultar_Nombre(txt_Consulta_Banco.Text);
            }
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Banco.Text))
            {
                MessageBox.Show("Favor de ingresar el ID!");
            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
                NpgsqlCommand cm = new NpgsqlCommand("Select id_donacion from donacion where id_donacion = '" + txt_Consulta_Banco.Text + "'", conn);
                conn.Open();
                try
                {
                    NpgsqlDataReader dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        Agregar_unidad ag = new Agregar_unidad(txt_Consulta_Banco.Text);
                        ag.bandera(true);
                        ag.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registro no existe!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, Solo Valoress numericos");
                }

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
                
            }
        }
    }
}
