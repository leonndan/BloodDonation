using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Insumos : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Insumos()
        {
            InitializeComponent();
            conn.Open();
            dataGridInsumo.DataSource = Consultar();
            conn.Close();
        }
        public DataTable Consultar()
        {
            string query = "select id_insumo,tipo,marca,cantidad from \"insumo\"";
            NpgsqlCommand connector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
        public DataTable Consultar_Nombre(string nom)
        {
            string query = "select * from \"insumo\" where \"id_insumo\"= '" + nom + "'";
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
                string query1 = "select id_insumo,tipo,marca,cantidad from \"insumo\"";
                NpgsqlCommand connector = new NpgsqlCommand(query1, conn);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);

                return tabla;
            }
        }
        public void Eliminar(string n)
        {
            NpgsqlCommand cm = new NpgsqlCommand("Select id_insumo from insumo where id_insumo = '" + n + "'", conn);
            conn.Open();
            try
            {
                NpgsqlDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    conn.Close();
                    conn.Open();
                    string query = "Delete from \"insumo\"" + "where \"id_insumo\"='" + n + "'";
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
            if (string.IsNullOrEmpty(txt_Consulta_Insumo.Text))
            {
                MessageBox.Show("Favor de ingresar el ID!");
            }
            else
            {
                dataGridInsumo.DataSource = Consultar_Nombre(txt_Consulta_Insumo.Text);
            }
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Insumo.Text))
            {
                MessageBox.Show("Favor de ingresar el ID!");
            }
            else
            {
                Agregar_unidad ag = new Agregar_unidad(txt_Consulta_Insumo.Text);
                ag.bandera(true);
                ag.Show();
                this.Close();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Insumo.Text))
            {
                MessageBox.Show("Favor de ingresar el ID!");
            }
            else
            {
                Eliminar(txt_Consulta_Insumo.Text);
            }
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Insumo.Text))
            {
                MessageBox.Show("Favor de ingresar el ID!");
            }
            else
            {
                Eliminar(txt_Consulta_Insumo.Text);
                
            }
        }

        private void btn_consulta_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Insumo.Text))
            {
                MessageBox.Show("Favor de ingresar el ID!");
            }
            else
            {
                dataGridInsumo.DataSource = Consultar_Nombre(txt_Consulta_Insumo.Text);
            }
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Consulta_Insumo.Text))
            {
                MessageBox.Show("Favor de ingresar el ID!");
            }
            else
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
                NpgsqlCommand cm = new NpgsqlCommand("Select id_insumo from insumo where id_insumo = '" + txt_Consulta_Insumo.Text + "'", conn);
                conn.Open();
                try
                {
                    NpgsqlDataReader dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        Agregar_insumoscs ag = new Agregar_insumoscs(txt_Consulta_Insumo.Text);
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
    }
}
