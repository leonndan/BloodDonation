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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void fewewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void daadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void consultarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pacientescs pacientescs = new Pacientescs();
            pacientescs.Show();
        }

        private void consultarMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctores doctores = new Doctores();
            doctores.Show();
        }

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_paciente ag_paciente = new Agregar_paciente();
            ag_paciente.Show();
        }

        private void registrarMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_medico ag_medico = new Agregar_medico();
            ag_medico.Show();
        }

        private void bancoDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarEnfermeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_enfermerocs ag_enfermero = new Agregar_enfermerocs();
            ag_enfermero.Show();
        }

        private void consultarEnfermeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enfermero consultarEnfermero = new Enfermero();
            consultarEnfermero.Show();
        }

        private void registrarDonadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_donador ag_donador = new Agregar_donador();
            ag_donador.Show();
        }

        private void consultarDonadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donador donador= new Donador();
            donador.Show();
        }

        private void agregarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_insumoscs ag_insumo = new Agregar_insumoscs("null");
            ag_insumo.Show();
        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.Show();
        }

        private void sangreUnidadBolsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_unidad ag_unidad = new Agregar_unidad("null");
            ag_unidad.Show();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void almacenInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insumos insumos = new Insumos();
            insumos.Show();
        }
    }
}
