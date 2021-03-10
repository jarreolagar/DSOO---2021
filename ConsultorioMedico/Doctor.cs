using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico
{
    public class Doctor
    {
        public string nombreDoctor { get; set; }
        public string apellidoDoctor { get; set; }
        public int edadDoctor { get; set; }
        public string especialidad { get; set; }
        public string universidad { get; set; }
        public string idDoctor { get; set; }
        public int idClinica { get; set; }
        public int dhabilitado { get; set; }
    }
}
