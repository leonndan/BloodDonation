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
   
    public partial class Agregar_unidad : Form
    {
        bool bandera_editar=false;
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Agregar_unidad()
        {
            InitializeComponent();
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
        public void Insertar(string CURP_enfermero, string CURP_donador, string tipo_sangre, int id_bolsa, int id_donacion, string fecha, int volumen, string vida_util, int id_grojos, int id_plasma, int id_paquetas, int v_grojos, int v_plasma, int v_plaqueta)
        {
            string query = "Insert into \"donacion\" values ('"
               + CURP_enfermero + "','" + CURP_donador + "'," + id_bolsa + "," + id_donacion + ",'" + fecha + "'); Insert into" +
                "\"bolsa_sangre\" values ("
                + id_bolsa + "," + volumen + "," + id_donacion + ",'" + vida_util + "'); Insert into" +
                "\"globulos_rojos\" values ("
                + id_bolsa + "," + id_grojos + ",'" + tipo_sangre + "'," + v_grojos + "); Insert into" +
                "\"plaquetas\" values ("
                + id_bolsa + "," + id_paquetas + ",'" + tipo_sangre + "'," + v_plaqueta + "); Insert into" +
                "\"plasma\" values ("
                + id_bolsa + "," + id_plasma + ",'" + tipo_sangre + "'," + v_plasma + ")";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Exito!");
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
            if (bandera_editar == false)
            {
                Insertar(
                Convert.ToString(comboEnferemero.SelectedItem),
                Convert.ToString(comboDonador.SelectedItem),
                Convert.ToString(combo_TipoSangre.SelectedItem),
                Convert.ToInt32(numericID.Text),
                Convert.ToInt32(numericID.Text),
                dateTimePicker1.Text,
                Convert.ToInt32(numericVolumen.Text),
                dateTimePicker2.Text,
                Convert.ToInt32(numericID.Text),
                Convert.ToInt32(numericID.Text),
                Convert.ToInt32(numericID.Text),
                Convert.ToInt32(numericGRojos.Text),
                Convert.ToInt32(numericPlasma.Text),
                Convert.ToInt32(numericPlaquetas.Text)
                ); 
                conn.Close();
                this.Close();
            }
           /* else
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
           */

        }

        private void txt_Vidautil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
