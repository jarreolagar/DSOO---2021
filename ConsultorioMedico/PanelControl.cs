using System;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class PanelControl : Form
    {
        private PantallaDoctor _pantallaDoctor;

        public PanelControl()
        {
            InitializeComponent();
            _pantallaDoctor = new PantallaDoctor();
        }

        private void PanelControl_Load(object sender, EventArgs e)
        {

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            _pantallaDoctor.Show();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            
        }
    }
}
