using Npgsql;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; database=bloodDonation+; User Id= postgres; Password=danielleon");
        public Form1()
        {
            InitializeComponent();
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Index index = new Index();
            index.Show();
            
            this.Hide();
               
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Close();
            Application.Exit();
        }
    }
}