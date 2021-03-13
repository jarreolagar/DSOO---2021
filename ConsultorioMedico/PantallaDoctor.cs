using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace ConsultorioMedico
{
    public partial class PantallaDoctor : Form
    {
        private DataAccessLayer _dataAccessLayer;
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=consultorio;Data Source=THINKPAD-L470\\MSSQLSERVER02");

        public PantallaDoctor()
        {
            InitializeComponent();
            _dataAccessLayer = new DataAccessLayer();
            llenarComboBoxClinica();
        }

        private void btnGuardarDoctor_Click(object sender, EventArgs e)
        {
            int habilitado = 1;
            bool flag = true;
            Doctor doctor = new Doctor();

            doctor.nombreDoctor = txtNombreDoc.Text;
            doctor.apellidoDoctor = txtApellidoDoc.Text;
            doctor.edadDoctor = Int32.Parse(txtEdadDoc.Text);
            doctor.especialidad = cmbEspecialidad.Text;
            doctor.universidad = txtUniversidadDoc.Text;
            doctor.idClinica = Convert.ToInt32(cmbClinica.SelectedValue.ToString());
            doctor.dhabilitado = habilitado;

            while (String.IsNullOrWhiteSpace(txtNombreDoc.Text) || String.IsNullOrWhiteSpace(txtApellidoDoc.Text) || String.IsNullOrWhiteSpace(txtEdadDoc.Text) || String.IsNullOrWhiteSpace(cmbEspecialidad.Text) || String.IsNullOrWhiteSpace(txtUniversidadDoc.Text) || String.IsNullOrWhiteSpace(cmbClinica.Text))
            {
                MessageBox.Show("Llena todos los campos");
                flag = false;
                break;
            }

            if (flag == false)
            {
                return;
            }
            else
            {
                int resultado = _dataAccessLayer.guardarDoctor(
                    "insertarDoctor",
                    new ArrayList { "@nombreDoctor", "@apellidoDoctor", "@edadDoctor", "@especialidad", "@universidad", "@idClinica", "@dhabilitado" },
                    new ArrayList { doctor.nombreDoctor,doctor.apellidoDoctor,doctor.edadDoctor,doctor.especialidad,doctor.universidad,doctor.idClinica,doctor.dhabilitado});
                if(resultado == 1)
                {
                    MessageBox.Show("Registro incertado");
                    llenarTablaDoctores();
                }
                  
            }
        }

        private void PantallaDoctor_Load(object sender, EventArgs e)
        {
            llenarTablaDoctores();
        }

        private void llenarTablaDoctores()
        {
            conn.Open();
            string query = @"SELECT doc.idDoctor, doc.nombreDoctor, doc.apellidoDoctor, doc.edadDoctor, doc.especialidad, doc.universidad, cli.nombreClinica
                             FROM doctores as doc
                             INNER JOIN clinica as cli ON doc.idClinica=cli.idClinica
                             WHERE doc.dhabilitado=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            sda.Fill(ds, "doctores");
            dgvDoc.DataSource = ds.Tables["doctores"].DefaultView;
            conn.Close();
        }

        private void btnEliminarDoctor_Click(object sender, EventArgs e)
        {
            int inhabilitar = 0;
            Doctor doctor = new Doctor();

            doctor.idDoctor = dgvDoc.CurrentRow.Cells[0].Value.ToString();
            doctor.dhabilitado = inhabilitar;
            if (MessageBox.Show("¿Desea Eliminar?", "AVISO", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {

                int resultado = _dataAccessLayer.eliminarDoctor("eliminarDoc", new ArrayList { "@idDoctor", "@dhabilitado" }, new ArrayList { doctor.idDoctor, doctor.dhabilitado });
                if (resultado == 1)
                {
                    MessageBox.Show("Se eliminó correctamente");
                    llenarTablaDoctores();
                }
                else
                {
                    MessageBox.Show("No se eliminó");
                }      
            }
        }

        public void llenarCamposDoctores()
        {
            Doctor doctor = new Doctor();

            doctor.idDoctor = dgvDoc.CurrentRow.Cells[0].Value.ToString();
            DataTable mostrarInfo = _dataAccessLayer.obtenerDoctores("obtenerDoctores", "@idDoctor", doctor.idDoctor);
            txtNombreDoc.Text = mostrarInfo.Rows[0][0].ToString();
            txtApellidoDoc.Text = mostrarInfo.Rows[0][1].ToString();
            txtEdadDoc.Text = mostrarInfo.Rows[0][2].ToString();
            cmbEspecialidad.Text = mostrarInfo.Rows[0][3].ToString();
            txtUniversidadDoc.Text = mostrarInfo.Rows[0][4].ToString();
            cmbClinica.Text = mostrarInfo.Rows[0][5].ToString();
        }

        private void btnModificarDoctor_Click(object sender, EventArgs e)
        {
            //Instanciar clase Doctor
            Doctor doctor = new Doctor();

            doctor.nombreDoctor = txtNombreDoc.Text;
            doctor.apellidoDoctor = txtApellidoDoc.Text;
            doctor.edadDoctor = Int32.Parse(txtEdadDoc.Text);
            doctor.especialidad = cmbEspecialidad.Text;
            doctor.universidad = txtUniversidadDoc.Text;
            doctor.idClinica = Convert.ToInt32(cmbClinica.SelectedValue.ToString());

            doctor.idDoctor = dgvDoc.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Desea modificar?", "AVISO", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                int resultado = _dataAccessLayer.actualizarDoctor(
                    "actualizarDoctor",
                    new ArrayList { "@idDoctor", "@nombreDoctor", "@apellidoDoctor", "@edadDoctor", "@especialidad", "@universidad", "@idClinica" },
                    new ArrayList { doctor.idDoctor, doctor.nombreDoctor, doctor.apellidoDoctor, doctor.edadDoctor, doctor.especialidad, doctor.universidad, doctor.idClinica });
                if (resultado == 1)
                {
                    MessageBox.Show("Registro actualizado");
                    llenarTablaDoctores();
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            llenarCamposDoctores();
        }

        private void txtNombreDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo es sólo para letras");
            }
        }

        private void txtApellidoDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo es sólo para letras");
            }
        }

        private void txtEdadDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo es sólo para números");
            }
        }

        private void txtUniversidadDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo es sólo para letras");
            }
        }

        private void txtBuscarDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
             
            DataTable mostrarInfo = _dataAccessLayer.obtenerDoctores("buscarDoctor", "@buscar", e.KeyChar.ToString());
            dgvDoc.DataSource = mostrarInfo;
    
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreDoc.Clear();
            txtApellidoDoc.Clear();
            txtEdadDoc.Clear();
            cmbEspecialidad.ResetText();
            txtUniversidadDoc.Clear();
            cmbClinica.ResetText();
        }

        void llenarComboBoxClinica()
        {
            DataRow dr;
            conn.Open();
            string query = "SELECT idClinica, nombreClinica FROM clinica";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Seleccione Clínica--" };
            dt.Rows.InsertAt(dr, 0);

            cmbClinica.ValueMember = "idClinica";
            cmbClinica.DisplayMember = "nombreClinica";
            cmbClinica.DataSource = dt;

            conn.Close();
        }

        private void dgvDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarCamposDoctores();
        }
    }
}
