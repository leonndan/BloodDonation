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
    public partial class Agregar_paciente : Form
    {
        bool bandera_editar = false;
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Agregar_paciente()
        {
            InitializeComponent();
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bandera_editar == false)
            {
                Insertar(
                Convert.ToInt32(numericID.Text),
                txt_CURP.Text,
                txt_Nombre.Text,
                txt_Paterno.Text,
                txt_Materno.Text,
                txt_Telefono.Text,
                txt_Email.Text,
                Convert.ToString(comboEnfermero.SelectedItem),
                Convert.ToString(comboMedico.SelectedItem),
                Convert.ToString(comboSangre.SelectedItem)
                );
                conn.Close();
                this.Close();
                MessageBox.Show("Exito!");

            }
            else
            {
                Actualizar(
                    txt_Nombre.Text,
                    txt_Paterno.Text,
                    txt_Materno.Text,
                    txt_Telefono.Text,
                    txt_Email.Text,
                    Convert.ToString(comboEnfermero.SelectedItem),
                    Convert.ToString(comboMedico.SelectedItem),
                    Convert.ToString(comboSangre.SelectedItem),
                    txt_CURP.Text
                    );
                conn.Close();
                MessageBox.Show("Registro Actualizado!");
                this.Close();
            }
        }
        public void Insertar(int id, string CURP, string nombre, string ap_paterno, string ap_materno, string telefono, string correo,string enfermero,string medico,string tipo_sangre)
        {
            string query = "Insert into \"pacientes\" values ("
                + id + ",'" + CURP + "','" + nombre + "','" + ap_paterno + "','" + ap_materno + "','" + telefono + "','" + correo + "','" + tipo_sangre + "','" + enfermero + "','" + medico + "')";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

        }
        public void Actualizar(string nombre, string ap_paterno, string ap_materno, string telefono, string correo, string enfermero, string medico, string tipo_sangre, string n)
        {
            string query = "Update \"pacientes\" set \"nombre\"='" + nombre + "',\"apellido_paterno\"='" + ap_paterno + "',\"apellido_materno\"='" + ap_materno + "',\"telefono\"='" + telefono + "',\"correo\"='" + correo + "',\"tipo_sangre\"='" + tipo_sangre + "',\"enfermero_encargado\"='" + enfermero + "'" + "',\"medico_encargado\"='" + medico + "'"+ "where \"curp\"='" + n + "'";
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
        private void Agregar_paciente_Load(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT curp from \"enfermero\"", conn);
            NpgsqlCommand command_enf = new NpgsqlCommand("SELECT curp from \"medico\"", conn);
            NpgsqlDataReader registro = command.ExecuteReader();
            while (registro.Read())
            {
                comboEnfermero.Items.Add(registro["curp"].ToString());
            }
            registro.Close();
            NpgsqlDataReader registro_enf = command_enf.ExecuteReader();
            while (registro_enf.Read())
            {
                comboMedico.Items.Add(registro["curp"].ToString());
            }
            registro_enf.Close();
        }
    }
}
