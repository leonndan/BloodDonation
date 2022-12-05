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
    public partial class Agregar_donador : Form
    {
        bool bandera_editar = false;
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Agregar_donador()
        {
            InitializeComponent();
            conn.Open();
        }
        public void Insertar(string CURP, string nombre, string ap_paterno, string ap_materno, string telefono, string correo, string c_elegibilidad, string tipo_sangre)
        {
            string query = "Insert into \"donador\" (curp,nombre,apellido_paterno,apellido_materno,telefono,correo,elegibilidad,tipo_sangre)   values ('"
                + CURP + "','" + nombre + "','" + ap_paterno + "','" + ap_materno + "','" + telefono + "','" + correo + "','" + c_elegibilidad + "','" + tipo_sangre + "')";

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
        public void Actualizar(string nombre, string ap_paterno, string ap_materno, string telefono, string correo, string c_elegibilidad, string tipo_sangre, string n)
        {
            string query = "Update \"donador\" set \"nombre\"='" + nombre + "',\"apellido_paterno\"='" + ap_paterno + "',\"apellido_materno\"='" + ap_materno + "',\"telefono\"='" + telefono + "',\"correo\"='" + correo + "',\"elegibilidad\"='" + c_elegibilidad + "',\"tipo_sangre\"='" + tipo_sangre + "'" + "where \"curp\"='" + n + "'";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

        }
        public void bandera(bool editar)
        {
            if (editar)
            {
                bandera_editar = true;
            }
            else
            {
                bandera_editar = false;
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_CURP.Text == "" | txt_Nombre.Text == "" | txt_am.Text == "" | txt_ap.Text == "" | txt_telefono.Text == "" | txt_email.Text == "" | tipo_Sangre.Text == "" || elegibilidad.Text == "")
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
                    if(elegibilidad.Text == "FALSO")
                    {
                        MessageBox.Show("No se pueden registrar donadores con elegibilidad negativa");
                    }
                    if (bandera_editar == false)
                    {
                        if (bandera_editar == false)
                        {
                            Insertar(
                               txt_CURP.Text,
                               txt_Nombre.Text,
                               txt_ap.Text,
                               txt_am.Text,
                               txt_telefono.Text,
                               txt_email.Text,
                               Convert.ToString(elegibilidad.SelectedItem),
                               Convert.ToString(tipo_Sangre.SelectedItem)
                               );
                            conn.Close();
                            MessageBox.Show("Exito!");
                            this.Close();
                        }
                        else
                        {
                            Actualizar(
                               txt_Nombre.Text,
                               txt_ap.Text,
                               txt_am.Text,
                               txt_telefono.Text,
                               txt_email.Text,
                               Convert.ToString(elegibilidad.SelectedItem),
                               Convert.ToString(tipo_Sangre.SelectedItem),
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
}
