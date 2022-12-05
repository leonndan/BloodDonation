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
     public partial class Agregar_insumoscs : Form
    {
        bool bandera_editar=false;
        string id_insumo;
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Agregar_insumoscs(string id)
        {
            InitializeComponent();
            id_insumo= id;
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Insertar(string marca, string tipo, int cantidad)
        {
            string query = "Insert into \"insumo\" (tipo,marca,cantidad)  values ("
                + "'" + marca + "','" + tipo  +  "','" + cantidad + "')";
            
            try
            {

                NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
                ejecutor.ExecuteNonQuery();
                MessageBox.Show("Exito!");
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado");
            }
        }
        public void Actualizar(string marca, string tipo, int cantidad)
        {
            string query = "Update \"insumo\" set \"marca\"='" + marca + "',\"tipo\"='" + tipo +  "'" + "where \"id_insumo\"='" + id_insumo + "'";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

        }
        public void bandera(bool editar)
        {
            if (editar)
            {
                bandera_editar=true;
            }
            else
            {
                bandera_editar=false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Marca.Text == "" | txt_Tipo.Text == "" | numericCantidad.Value == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Error!");
            }
            else
            {

                if (bandera_editar == false)
                {
                    Insertar(
                    txt_Marca.Text,
                    txt_Tipo.Text,
                    Convert.ToInt32(numericCantidad.Text)
                    );
                    conn.Close();
                    this.Close();
                }
                else
                {
                    Actualizar(
                        txt_Marca.Text,
                        txt_Tipo.Text,
                        Convert.ToInt32(numericCantidad.Text)
                        );
                    conn.Close();
                    MessageBox.Show("Registro Actualizado!");
                    this.Close();
                    
                }
                

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_Marca.Text == "" | txt_Tipo.Text == "" | numericCantidad.Value < 1)
            {
                MessageBox.Show("Faltan campos por llenar", "Error!");
            }
            else
            {

                if (bandera_editar == false)
                {
                    Insertar(
                    txt_Marca.Text,
                    txt_Tipo.Text,
                    Convert.ToInt32(numericCantidad.Text)
                    );
                    conn.Close();
                    this.Close();
                }
                else
                {
                    Actualizar(
                         txt_Marca.Text,
                         txt_Tipo.Text,
                         Convert.ToInt32(numericCantidad.Text)
                         );
                    conn.Close();
                    MessageBox.Show("Registro Actualizado!");
                    this.Close();
                }


            }
        }
    }
}
