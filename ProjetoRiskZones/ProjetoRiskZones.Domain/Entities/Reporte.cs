using System;

namespace ProjetoRiskZones.Domain.Entities
{
    public class Reporte
    {
        public int ReporteID { get; set; }
        public string Logitude { get; set; }
        public string Latitude { get; set; }
        public string Status { get; set; }
        public int IDUsuario { get; set; }
        public int IDSintoma { get; set; }
        public int IDRisco { get; set; }
        public DateTime DataCheckin { get; set; }


        public virtual Risco Risco { get; set; }
        public virtual Sintoma Sitoma { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}