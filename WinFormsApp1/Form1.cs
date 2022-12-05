using Npgsql;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
         //bloodDonation //danielleon
        public Form1()
        {
            InitializeComponent();
            //conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "" | comboBox1.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            else
            {

                if (comboBox1.Text == "Medico")
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
                    NpgsqlCommand cm = new NpgsqlCommand("Select curp,password from medico where curp = '" + textBox1.Text + "' and password ='" + textBox2.Text + "'", conn);
                    conn.Open();
                    NpgsqlDataReader dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Acceso Autorizado");
                        Index index = new Index();
                        index.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso No Autorizado");
                    }
                }
                else if (comboBox1.Text == "Enfermero")
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
                    NpgsqlCommand cm = new NpgsqlCommand("Select curp,password from enfermero where curp = '" + textBox1.Text + "' and password ='" + textBox2.Text + "'", conn);
                    conn.Open();
                    NpgsqlDataReader dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Acceso Autorizado");
                        Index index = new Index();
                        index.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso No Autorizado");
                    }
                }
                else if (comboBox1.Text == "Almacenista")
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
                    NpgsqlCommand cm = new NpgsqlCommand("Select curp,password from almacenista where curp = '" + textBox1.Text + "' and password ='" + textBox2.Text + "'", conn);
                    conn.Open();
                    NpgsqlDataReader dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Acceso Autorizado");
                        Index index = new Index();
                        index.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso No Autorizado");
                    }
                }
                else if (comboBox1.Text == "Recepcionista")
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
                    NpgsqlCommand cm = new NpgsqlCommand("Select curp,password from recepcionista where curp = '" + textBox1.Text + "' and password ='" + textBox2.Text + "'", conn);
                    conn.Open();
                    NpgsqlDataReader dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Acceso Autorizado");
                        Index index = new Index();
                        index.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso No Autorizado");
                    }
                }

            }

            /*
            Index index = new Index();
            index.Show();
            
            this.Hide();*/

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //conn.Close();
            Application.Exit();
        }
    }
}