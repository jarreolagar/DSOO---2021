using System;
using System.Windows.Forms;

namespace Examen1erParcialPVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(cmbMes.SelectedItem == null || string.IsNullOrWhiteSpace(txtDia.Text))
            {
             
                MessageBox.Show("Datos inválidos");
                return;
            }
            if (Int32.Parse(txtDia.Text) >= 21 && cmbMes.SelectedItem.ToString() == "Marzo" || Int32.Parse(txtDia.Text) <= 19 && cmbMes.SelectedItem.ToString() == "Abril")
            {
                MessageBox.Show("Aries");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Aries");
            }
            if (Int32.Parse(txtDia.Text) >= 20 && cmbMes.SelectedItem.ToString() == "Abril" || Int32.Parse(txtDia.Text) <= 20 && cmbMes.SelectedItem.ToString() == "Mayo")
            {
                MessageBox.Show("Tauro");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Tauro");
            }
            if (Int32.Parse(txtDia.Text) >= 21 && cmbMes.SelectedItem.ToString() == "Mayo" || Int32.Parse(txtDia.Text) <= 21 && cmbMes.SelectedItem.ToString() == "Junio")
            {
                MessageBox.Show("Géminis");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Géminis");
            }
            if (Int32.Parse(txtDia.Text) >= 22 && cmbMes.SelectedItem.ToString() == "Junio" || Int32.Parse(txtDia.Text) <= 22 && cmbMes.SelectedItem.ToString() == "Julio")
            {
                MessageBox.Show("Cáncer");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Cáncer");
            }
            if (Int32.Parse(txtDia.Text) >= 23 && cmbMes.SelectedItem.ToString() == "Julio" || Int32.Parse(txtDia.Text) <= 22 && cmbMes.SelectedItem.ToString() == "Agosto")
            {
                MessageBox.Show("Leo");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Leo");
            }
            if (Int32.Parse(txtDia.Text) >= 23 && cmbMes.SelectedItem.ToString() == "Agosto" || Int32.Parse(txtDia.Text) <= 22 && cmbMes.SelectedItem.ToString() == "Septiembre")
            {
                MessageBox.Show("Virgo");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Virgo");
            }
            if (Int32.Parse(txtDia.Text) >= 23 && cmbMes.SelectedItem.ToString() == "Septiembre" || Int32.Parse(txtDia.Text) <= 23 && cmbMes.SelectedItem.ToString() == "Octubre")
            {
                MessageBox.Show("Libra");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Libra");
            }
            if (Int32.Parse(txtDia.Text) >= 24 && cmbMes.SelectedItem.ToString() == "Octubre" || Int32.Parse(txtDia.Text) <= 21 && cmbMes.SelectedItem.ToString() == "Noviembre")
            {
                MessageBox.Show("Escorpio");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Escorpio");
            }
            if (Int32.Parse(txtDia.Text) >= 22 && cmbMes.SelectedItem.ToString() == "Noviembre" || Int32.Parse(txtDia.Text) <= 21 && cmbMes.SelectedItem.ToString() == "Diciembre")
            {
                MessageBox.Show("Sagitario");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Sagitario");
            }
            if (Int32.Parse(txtDia.Text) >= 22 && cmbMes.SelectedItem.ToString() == "Diciembre" || Int32.Parse(txtDia.Text) <= 19 && cmbMes.SelectedItem.ToString() == "Enero")
            {
                MessageBox.Show("Capricornio");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Acuario");
            }
            if (Int32.Parse(txtDia.Text) >= 20 && cmbMes.SelectedItem.ToString() == "Enero" || Int32.Parse(txtDia.Text) <= 18 && cmbMes.SelectedItem.ToString() == "Febrero")
            {
                MessageBox.Show("Acuario");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Acuario");
            }
            if (Int32.Parse(txtDia.Text) >= 19 && cmbMes.SelectedItem.ToString() == "Febrero" || Int32.Parse(txtDia.Text) <= 20 && cmbMes.SelectedItem.ToString() == "Marzo")
            {
               
                MessageBox.Show("Piscis");
                lstDatos.Items.Add($"Día {txtDia.Text}, Mes {cmbMes.SelectedItem.ToString()}, Piscis");
            }

            
        }

    }
}
