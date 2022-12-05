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
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
   
    public partial class Agregar_unidad : Form
    {
        bool bandera_editar=false;
        string id_donacion;
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Agregar_unidad(string id)
        {
            InitializeComponent();
            id_donacion = id;
            conn.Open();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboEnferemero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboDonador_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        public void Insertar(string CURP_enfermero, string CURP_donador, string tipo_sangre, string tipo_donacion, string fecha, int volumen, string vida_util)
        {
            string query = "Insert into \"donacion\"  (curp_enfermero,curp_donador,fecha,tipo_donacion,tipo_sangre,volumen,fecha_util) values ('"
               + CURP_enfermero + "','" + CURP_donador  + "','" + fecha + "','" + tipo_donacion + "','" + tipo_sangre + "','" + volumen + "','" + vida_util + "')";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Exito!");
        }
        public void Actualizar(string CURP_enfermero, string CURP_donador, string tipo_sangre, string tipo_donacion, string fecha, int volumen, string vida_util)
        {
            string query = "Update \"donacion\" set \"curp_enfermero\"='" + CURP_enfermero + "',\"curp_donador\"='" + CURP_donador + "',\"fecha\"='" + fecha + "',\"tipo_donacion\"='" + tipo_donacion + "',\"tipo_sangre\"='" + tipo_sangre + "',\"volumen\"='" + volumen + "',\"fecha_util\"='" + vida_util + "'";
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
        private void Agregar_unidad_Load(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT curp from \"enfermero\"", conn);
            NpgsqlCommand command_enf = new NpgsqlCommand("SELECT curp from \"donador\"", conn);
            NpgsqlDataReader registro = command.ExecuteReader();
            while (registro.Read())
            {
                comboEnferemero.Items.Add(registro["curp"].ToString());
            }
            registro.Close();
            NpgsqlDataReader registro_enf = command_enf.ExecuteReader();
            while (registro_enf.Read())
            {
                comboDonador.Items.Add(registro["curp"].ToString());
            }
            registro_enf.Close();

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (comboEnferemero.Text == "" | comboDonador.Text == "" | combo_TipoSangre.Text == "" | tipo_donacion.Text == "" | combo_TipoSangre.Text == "" | numericVolumen.Value < 1)
            {
                MessageBox.Show("Faltan campos por llenar", "Error!");
            }
            else
            {
                if (bandera_editar == false)
                {
                    Insertar(
                    Convert.ToString(comboEnferemero.SelectedItem),
                    Convert.ToString(comboDonador.SelectedItem),
                    Convert.ToString(combo_TipoSangre.SelectedItem),
                    Convert.ToString(tipo_donacion.SelectedItem),
                    dateTimePicker1.Text,
                    Convert.ToInt32(numericVolumen.Text),
                    dateTimePicker2.Text
                    );
                    conn.Close();
                    this.Close();
                }
                 else
                 {
                     Actualizar(
                        Convert.ToString(comboEnferemero.SelectedItem),
                        Convert.ToString(comboDonador.SelectedItem),
                        Convert.ToString(combo_TipoSangre.SelectedItem),
                        Convert.ToString(tipo_donacion.SelectedItem),
                        dateTimePicker1.Text,
                        Convert.ToInt32(numericVolumen.Text),
                        dateTimePicker2.Text
                         );
                     conn.Close();
                     MessageBox.Show("Registro Actualizado!");
                     this.Close();

                 }
                

            }
        }

        private void txt_Vidautil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
