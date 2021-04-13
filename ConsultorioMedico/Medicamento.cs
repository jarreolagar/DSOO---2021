using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedico
{
    class Medicamento
    {
        public string idMedicamento { get; set; }
        public string nombre { get; set; }
        public string laboratorio { get; set; }
        public string administracion { get; set; }
        public string especialidad {get; set;}
        public int habilitado { get; set; }
    }
}
