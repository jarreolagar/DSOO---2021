using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaDoctor doctor = new PantallaDoctor();
            doctor.MdiParent = this;
            doctor.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaPaciente paciente = new PantallaPaciente();
            paciente.MdiParent = this;
            paciente.Show();
        }

        private void clinicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaClinica clinica = new PantallaClinica();
            clinica.MdiParent = this;
            clinica.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaConsultas consulta = new PantallaConsultas();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaMedicamentos medicamento = new PantallaMedicamentos();
            medicamento.MdiParent = this;
            medicamento.Show();
        }
    }
}
