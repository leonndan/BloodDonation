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

    public partial class Agregar_enfermerocs : Form
    {
        bool bandera_editar=false;
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Agregar_enfermerocs()
        {
            InitializeComponent();
            txt_Telefono.Controls[0].Visible = false;
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Insertar(string CURP, string nombre, string ap_paterno, string ap_materno, string telefono, string correo, string password, string cedula)
        {
            string query = "Insert into \"enfermero\" (curp,nombre,apellido_paterno,apellido_materno,telefono,correo,password,cedula)  values ("
                + "'" + CURP + "','" + nombre + "','" + ap_paterno + "','" + ap_materno + "','" + telefono + "','" + correo + "','" + password + "','" + cedula + "')";
            
            try
            {

                NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
                ejecutor.ExecuteNonQuery();
                MessageBox.Show("Exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, CURP debe ser unica");
            }
        }
        public void Actualizar(string nombre, string ap_paterno, string ap_materno, string telefono, string correo, string password, string cedula, string n)
        {
            string query = "Update \"enfermero\" set \"nombre\"='" + nombre + "',\"apellido_paterno\"='" + ap_paterno + "',\"apellido_materno\"='" + ap_materno + "',\"telefono\"='" + telefono + "',\"correo\"='" + correo + "',\"password\"='" + password + "',\"cedula\"='" + cedula + "'" + "where \"curp\"='" + n + "'";
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
            if (txt_CURP.Text == "" | txt_Nombre.Text == "" | txt_Materno.Text == "" | txt_Paterno.Text == "" | txt_Telefono.Text == "" | txt_Email.Text == "" | txt_ARNP.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar", "Error!");
            }
            else
            {
                if (txt_CURP.Text.Length < 18)
                {
                    MessageBox.Show("CURP no tiene longitud de 18 caracteres", "Error CURP!");
                }
                else
                {
                    if (bandera_editar == false)
                    {
                        Insertar(
                        txt_CURP.Text,
                        txt_Nombre.Text,
                        txt_Paterno.Text,
                        txt_Materno.Text,
                        txt_Telefono.Text,
                        txt_Email.Text,
                        txt_contraseña.Text,
                        txt_ARNP.Text
                        );
                        conn.Close();
                        this.Close();
                    }
                    else
                    {
                        Actualizar(
                            txt_Nombre.Text,
                            txt_Paterno.Text,
                            txt_Materno.Text,
                            txt_Telefono.Text,
                            txt_Email.Text,
                            txt_contraseña.Text,
                            txt_ARNP.Text,
                            txt_CURP.Text
                            );
                        conn.Close();
                        MessageBox.Show("Registro Actualizado!");
                        this.Close();

                    }
                }
            }
        }
    }
}
