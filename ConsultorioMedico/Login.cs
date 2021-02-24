using System;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class Login : Form
    {
        //Se crea esta clase para poder acceder a los métodos de _businessLogicLayer
        private DataAccessLayer _dataAccessLayer;
        public Login()
        {
            InitializeComponent();
            _dataAccessLayer = new DataAccessLayer();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            
            usuario.usuario = txtUsuario.Text;
            usuario.contrasena = txtContrasena.Text;

            _dataAccessLayer.loginUsuario(usuario);
           
        }
    }
}
