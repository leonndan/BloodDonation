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
        public void Insertar(string CURP, string nombre, string ap_paterno, string ap_materno, string telefono, string correo, int id, string c_elegibilidad, string tipo_sangre)
        {
            string query = "Insert into \"donador\" values ('"
                + CURP + "','" + nombre + "','" + ap_paterno + "','" + ap_materno + "','" + telefono + "','" + correo + "'," + id + ",'" + c_elegibilidad + "','" + tipo_sangre + "')";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            
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
            if (bandera_editar == false)
            {
                Insertar(
                   txt_curp.Text,
                   txt_nombre.Text,
                   txt_paterno.Text,
                   txt_materno.Text,
                   txt_telefono.Text,
                   txt_email.Text,
                   Convert.ToInt32(numericID.Text),
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
                   txt_nombre.Text,
                   txt_paterno.Text,
                   txt_materno.Text,
                   txt_telefono.Text,
                   txt_email.Text,
                   Convert.ToString(elegibilidad.SelectedItem),
                   Convert.ToString(tipo_Sangre.SelectedItem),
                   txt_curp.Text
                    );
                conn.Close();
                MessageBox.Show("Registro Actualizado!");
                this.Close();

            }
            
        }
    }
}
