namespace ConsultorioMedico
{
    class Paciente
    {
        public string idPaciente { get; set; }
        public string nombrePaciente { get; set; }
        public string apellidoPaciente { get; set; }
        public int edadPaciente { get; set; }
        public float pesoPaciente { get; set; }
        public float alturaPaciente { get; set; }
        public string enfermedad { get; set; }
        public int idDoctor { get; set; }
        public int phabilitado { set; get; }
        public string correo { set; get; }
    }
}
