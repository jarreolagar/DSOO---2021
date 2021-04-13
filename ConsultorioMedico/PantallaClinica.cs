using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace ConsultorioMedico
{
    public partial class PantallaClinica : Form
    {
        
        public PantallaClinica()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int habilitado = 1;
            using (consultorioEntities1 db = new consultorioEntities1())
            {
                clinica clinica1 = new clinica();

                clinica1.nombreClinica = txtNombreClinica.Text;
                clinica1.direccionClinica = txtDireccionClinica.Text;
                clinica1.clihabilitado = habilitado;

                db.clinicas.Add(clinica1);
                db.SaveChanges();
                MessageBox.Show("Clinica insertada");
                Refrescar();
            }
        }

       

        private void PantallaClinica_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            using (consultorioEntities1 db = new consultorioEntities1())
            {
                var query = from datos in db.clinicas
                            where datos.clihabilitado == 1
                            select datos;
                /*var lst = from datos in db.clinicas
                          select datos;*/

                dataGridClinica.DataSource = query.ToList();
            }
        }

        private void dataGridClinica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridClinica.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dataGridClinica.SelectedRows)
                {
                    labelid.Text = row.Cells[0].Value.ToString();
                    txtNombreClinica.Text = row.Cells[1].Value.ToString();
                    txtDireccionClinica.Text = row.Cells[2].Value.ToString();
                    
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(labelid.Text);
            using(consultorioEntities1 db = new consultorioEntities1())
            {
                clinica modificar = db.clinicas.Where(i => i.idClinica == id).FirstOrDefault();
                modificar.nombreClinica = txtNombreClinica.Text;
                modificar.direccionClinica = txtDireccionClinica.Text;
                db.SaveChanges();
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int inhabilitado = 0;
            int id = Convert.ToInt32(labelid.Text);
            using (consultorioEntities1 db = new consultorioEntities1())
            {
                clinica modificar = db.clinicas.Where(i => i.idClinica == id).FirstOrDefault();
                modificar.clihabilitado = inhabilitado;
                
                db.SaveChanges();
                Refrescar();
            }
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (consultorioEntities1 db = new consultorioEntities1())
            {
                var query = from datos in db.clinicas
                            where datos.nombreClinica == txtBuscarClinica.Text
                            select datos;
                /*var lst = from datos in db.clinicas
                          select datos;*/

                dataGridClinica.DataSource = query.ToList();
            }
        }

        private void txtBuscarClinica_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarClinica.Text.Equals(string.Empty))
            {
                Refrescar();
            }
        }
    }
}
