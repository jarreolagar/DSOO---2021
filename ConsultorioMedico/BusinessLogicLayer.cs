using System.Windows.Forms;

namespace ConsultorioMedico
{
    class BusinessLogicLayer
    {
        //Se crea esta clase para poder acceder a los métodos de la clase de _dataAccessLayer
        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }
        public Usuario ingresar(Usuario usuario)
        {
            _dataAccessLayer.loginUsuario(usuario);
            
            return usuario;

        }

    }
}
