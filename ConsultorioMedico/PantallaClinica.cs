using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class PantallaClinica : Form
    {
        private DataAccessLayer _dataAccessLayer;
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=consultorio;Data Source=THINKPAD-L470\\MSSQLSERVER02");
        public PantallaClinica()
        {
            InitializeComponent();
            _dataAccessLayer = new DataAccessLayer();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int habilitado = 1;
            Clinica clinica = new Clinica();

            clinica.nombreClinica = txtNombreClinica.Text;
            clinica.direccionClinica = txtDireccionClinica.Text;
            clinica.habilitado = habilitado;

            int resultado = _dataAccessLayer.guardarDoctor("guardarClinica",
                new ArrayList { "@nombreClinica", "@direccionClinica", "@chabilitado" },
                new ArrayList { clinica.nombreClinica, clinica.direccionClinica, clinica.habilitado });

            if (resultado == 1)
            {
                MessageBox.Show("Clinica insertada");
                llenarTablaClinica();
            }
        }

        private void llenarTablaClinica()
        {
            conn.Open();

            string query = @"SELECT idClinica, nombreClinica, direccionClinica
                             FROM clinica WHERE clihabilitado=1";

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            sda.Fill(ds, "clinica");
            dataGridClinica.DataSource = ds.Tables["clinica"].DefaultView;
            conn.Close();

        }

        private void PantallaClinica_Load(object sender, EventArgs e)
        {
            llenarTablaClinica();
        }

        private void dataGridClinica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clinica clinica = new Clinica();

            clinica.idClinica = dataGridClinica.CurrentRow.Cells[0].Value.ToString();
            DataTable mostrarInfo = _dataAccessLayer.obtenerDoctores("obtenerClinicas", "@idClinica", clinica.idClinica);
            txtNombreClinica.Text = mostrarInfo.Rows[0][0].ToString();
            txtDireccionClinica.Text = mostrarInfo.Rows[0][1].ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica();

            clinica.nombreClinica = txtNombreClinica.Text;
            clinica.direccionClinica = txtDireccionClinica.Text;

            clinica.idClinica = dataGridClinica.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Desea modificar?", "AVISO", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                int resultado = _dataAccessLayer.actualizarDoctor(
                    "actualizarClinica",
                    new ArrayList { "@idClinica", "@nombreClinica", "@direccionClinica" },
                    new ArrayList { clinica.idClinica, clinica.nombreClinica, clinica.direccionClinica });
                if (resultado == 1)
                {
                    MessageBox.Show("Registro actualizado");
                    llenarTablaClinica();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int inhabilitar = 0;
            Clinica clinica = new Clinica();

            clinica.idClinica = dataGridClinica.CurrentRow.Cells[0].Value.ToString();
            clinica.habilitado = inhabilitar;
            if (MessageBox.Show("¿Desea Eliminar?", "AVISO", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {

                int resultado = _dataAccessLayer.eliminarDoctor("eliminarClinica", new ArrayList { "@idClinica", "@clihabilitado" }, new ArrayList { clinica.idClinica, clinica.habilitado });
                if (resultado == 1)
                {
                    MessageBox.Show("Se eliminó correctamente");
                    llenarTablaClinica();
                }
                else
                {
                    MessageBox.Show("No se eliminó");
                }

            }
        }

        private void txtBuscarClinica_KeyUp(object sender, KeyEventArgs e)
        {
            /*DataTable mostrarInfo = _dataAccessLayer.obtenerDoctores("buscarClinica", "@buscar", txtNombreClinica.Text);
            dataGridClinica.DataSource = mostrarInfo;*/
            SqlDataAdapter adapt;
            DataTable dt;
            conn.Open();
            adapt = new SqlDataAdapter("SELECT * FROM clinica WHERE clihabilitado=1 AND nombreClinica LIKE '" + txtNombreClinica + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridClinica.DataSource = dt;
            conn.Close();
            llenarTablaClinica();

        }
    }
}
