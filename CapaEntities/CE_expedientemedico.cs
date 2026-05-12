namespace CapaEntities
{
    public class CE_expedientemedico
    {
        public int IdExpediente { get; set; }
        public int IdPaciente { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Ocupacion { get; set; }
        public string LugarOrigen { get; set; }
        public string Religion { get; set; }
        public string NombreResponsable { get; set; }
        public string ContactoResponsable { get; set; }
        public string AntHeredofamiliares { get; set; }
        public string AntPatologicos { get; set; }
        public string AntNoPatologicos { get; set; }
        public DateTime FechaApertura { get; set; }
    }
}
