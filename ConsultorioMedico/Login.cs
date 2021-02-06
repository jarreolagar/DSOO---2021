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
    public partial class Login : Form
    {
        //Se crea esta clase para poder acceder a los métodos de _businessLogicLayer
        private BusinessLogicLayer _businessLogicLayer;
        public Login()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.usuario = txtUsuario.Text;
            usuario.contrasena = txtContrasena.Text;

            _businessLogicLayer.ingresar(usuario);
            

        }
    }
}
