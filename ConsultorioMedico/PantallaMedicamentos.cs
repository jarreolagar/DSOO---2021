using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class PantallaMedicamentos : Form
    {
        private DataAccessLayer _dataAccessLayer;
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=consultorio;Data Source=THINKPAD-L470\\MSSQLSERVER02");
        public PantallaMedicamentos()
        {
            InitializeComponent();
            _dataAccessLayer = new DataAccessLayer();
        }

        private void btnGuardarMed_Click(object sender, EventArgs e)
        {
            int habilitado = 1;
            bool flag = true;

            Medicamento medicamento = new Medicamento();

            medicamento.nombre = txtNombreMed.Text;
            medicamento.laboratorio = txtLaboratorio.Text;
            medicamento.administracion = txtAdministracion.Text;
            medicamento.especialidad = cmbEspecialidad.Text;
            medicamento.habilitado = habilitado;

            while (String.IsNullOrWhiteSpace(txtNombreMed.Text) || String.IsNullOrWhiteSpace(txtLaboratorio.Text) || String.IsNullOrWhiteSpace(txtAdministracion.Text) || String.IsNullOrWhiteSpace(cmbEspecialidad.Text) || String.IsNullOrWhiteSpace(cmbEspecialidad.Text))
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
                    "insertarMedicamento",
                    new ArrayList { "@nombreMedicamento", "@laboratorio", "@administracion", "@habilitado", "@especialidad" },
                    new ArrayList { medicamento.nombre, medicamento.laboratorio, medicamento.administracion, medicamento.habilitado, medicamento.especialidad});
                if (resultado == 1)
                {
                    MessageBox.Show("Registro incertado");
                    llenarTablaMedicamentos();
                }

            }

            
        }

        private void llenarTablaMedicamentos()
        {
            conn.Open();
            string query = @"SELECT idMedicamento, nombreMedicamento, laboratorio, administracion, especialidad
                             FROM medicamentos
                             WHERE mhabilitado=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            sda.Fill(ds, "medicamentos");
            dataGridMed.DataSource = ds.Tables["medicamentos"].DefaultView;
            conn.Close();
        }

        private void PantallaMedicamentos_Load(object sender, EventArgs e)
        {
            llenarTablaMedicamentos();
        }

        private void dataGridMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarCamposMedicina();
        }

        private void llenarCamposMedicina()
        {
            Medicamento medicamento = new Medicamento()
;
            medicamento.idMedicamento = dataGridMed.CurrentRow.Cells[0].Value.ToString();
            DataTable mostrarInfo = _dataAccessLayer.obtenerDatosMedicamento("obtenerMedicamento", "@idMedicamento", medicamento.idMedicamento);
            txtNombreMed.Text = mostrarInfo.Rows[0][0].ToString();
            txtLaboratorio.Text = mostrarInfo.Rows[0][1].ToString();
            txtAdministracion.Text = mostrarInfo.Rows[0][2].ToString();
            cmbEspecialidad.Text = mostrarInfo.Rows[0][3].ToString();
        }
    }
}
