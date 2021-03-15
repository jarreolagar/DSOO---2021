using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class PantallaPaciente : Form
    {
        private DataAccessLayer _dataAccessLayer;
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=consultorio;Data Source=THINKPAD-L470\\MSSQLSERVER02");

        public PantallaPaciente()
        {
            InitializeComponent();
            _dataAccessLayer = new DataAccessLayer();
            llenarComboBoxDoc();
        }

        private void btnGuardarPac_Click(object sender, EventArgs e)
        {
            int habilitado = 1;
            Paciente paciente = new Paciente();

            paciente.nombrePaciente = txtNombrePac.Text;
            paciente.apellidoPaciente = txtApellidoPac.Text;
            paciente.correo = txtCorreo.Text;
            paciente.edadPaciente = Int32.Parse(txtEdadPac.Text);
            paciente.pesoPaciente = float.Parse(txtPesoPac.Text);
            paciente.alturaPaciente = float.Parse(txtAlturaPac.Text);
            paciente.enfermedad = txtEnfermedad.Text;
            paciente.idDoctor = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            paciente.phabilitado = habilitado;

            int resultado = _dataAccessLayer.guardarPaciente(
                    "insertarPaciente",
                    new ArrayList { "@nombrePaciente", "@apellidoPaciente", "@correo","@edadPaciente", "@pesoPaciente", "@alturaPaciente", "@enfermedad", "@idDoctor", "@phabilitado"},
                    new ArrayList { paciente.nombrePaciente, paciente.apellidoPaciente, paciente.correo,paciente.edadPaciente, paciente.pesoPaciente, paciente.alturaPaciente, paciente.enfermedad, paciente.idDoctor, paciente.phabilitado });
            if (resultado == 1)
            {
                MessageBox.Show("Registro Insertado");
                llenarTablaPacientes();
            }
           
        }

       
        public void llenarComboBoxDoc()
        {
            DataRow dr;
            conn.Open();
            string query = "SELECT idDoctor, nombreDoctor FROM doctores WHERE dhabilitado=1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Seleccione Doctor--" };
            dt.Rows.InsertAt(dr, 0);

            comboBox1.ValueMember = "idDoctor";
            comboBox1.DisplayMember = "nombreDoctor";
            comboBox1.DataSource = dt;

            conn.Close();
        }

        private void PantallaPaciente_Load(object sender, EventArgs e)
        {
            llenarTablaPacientes();
        }

        private void llenarTablaPacientes()
        {
            conn.Open();
            string query = @"SELECT pac.idPaciente, pac.nombrePaciente, pac.apellidoPaciente, pac.correo,pac.edadPaciente,pac.pesoPaciente, pac.alturaPaciente,pac.enfermedad,doc.nombreDoctor
                             FROM pacientes as pac
                             INNER JOIN doctores as doc ON doc.idDoctor=pac.idDoctor
                             WHERE phabilitado=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            sda.Fill(ds, "pacientes");
            dgvPacientes.DataSource = ds.Tables["pacientes"].DefaultView;
            conn.Close();
        }

        private void llenarCamposPaciente()
        {
            Paciente paciente = new Paciente();

            paciente.idPaciente = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
            DataTable mostrarInfo = _dataAccessLayer.obtenerDoctores("obtenerPaciente", "@idPaciente", paciente.idPaciente);
            txtNombrePac.Text = mostrarInfo.Rows[0][0].ToString();
            txtApellidoPac.Text = mostrarInfo.Rows[0][1].ToString();
            txtCorreo.Text = mostrarInfo.Rows[0][2].ToString();
            txtEdadPac.Text = mostrarInfo.Rows[0][3].ToString();
            txtPesoPac.Text = mostrarInfo.Rows[0][4].ToString();
            txtAlturaPac.Text = mostrarInfo.Rows[0][5].ToString();
            comboBox1.Text = mostrarInfo.Rows[0][6].ToString();
            txtEnfermedad.Text = mostrarInfo.Rows[0][7].ToString();
        }

        private void btnModificarPac_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            paciente.nombrePaciente = txtNombrePac.Text;
            paciente.apellidoPaciente = txtApellidoPac.Text;
            paciente.correo = txtCorreo.Text;
            paciente.edadPaciente = Int32.Parse(txtEdadPac.Text);
            paciente.pesoPaciente = float.Parse(txtPesoPac.Text);
            paciente.alturaPaciente = float.Parse(txtAlturaPac.Text);
            paciente.enfermedad = txtEnfermedad.Text;
            paciente.idDoctor = Convert.ToInt32(comboBox1.SelectedValue.ToString());

            paciente.idPaciente = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Desea modificar?", "AVISO", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                int resultado = _dataAccessLayer.actualizarDoctor(
                    "actualizarPaciente",
                    new ArrayList { "@idPaciente", "@nombrePaciente", "@apellidoPaciente", "@correo" ,"@edadPaciente", "@pesoPaciente", "@alturaPaciente", "@enfermedad", "@idDoctor" },
                    new ArrayList { paciente.idPaciente, paciente.nombrePaciente, paciente.apellidoPaciente, paciente.correo,paciente.edadPaciente, paciente.pesoPaciente, paciente.alturaPaciente, paciente.enfermedad, paciente.idDoctor });
                if (resultado == 1)
                {
                    MessageBox.Show("Registro actualizado");
                    llenarTablaPacientes();
                }
            }

        }

        private void btnEliminarPac_Click(object sender, EventArgs e)
        {
            int inhabilitar = 0;
            Paciente paciente = new Paciente();

            paciente.idPaciente = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
            paciente.phabilitado = inhabilitar;
            if (MessageBox.Show("Desea Eliminar?", "AVISO", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {

                int resultado = _dataAccessLayer.eliminarDoctor("eliminarPac", new ArrayList { "@idPaciente", "@phabilitado" }, new ArrayList { paciente.idPaciente, paciente.phabilitado });
                if (resultado == 1)
                {
                    MessageBox.Show("Se eliminó correctamente");
                    llenarTablaPacientes();
                }
                else
                {
                    MessageBox.Show("No se eliminó");
                }
            }
        }

        private void btnLimpiarCamposPac_Click(object sender, EventArgs e)
        {
            txtNombrePac.Clear();
            txtApellidoPac.Clear();
            txtCorreo.Clear();
            txtEdadPac.Clear();
            txtPesoPac.Clear();
            txtAlturaPac.Clear();
            txtEnfermedad.Clear();
            comboBox1.ResetText();
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarCamposPaciente();
        }

        private void filtrado(object sender, EventArgs e)
        {
            string nombre = txtBuscarPaciente.Text;
            _dataAccessLayer.buscarDoctor("buscarPaciente", "buscar", nombre, dgvPacientes);
        }
    }
}
