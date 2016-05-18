using System;

namespace ProjetoRiskZones.Domain.Entities
{
    public class Sintoma
    {
        public int IDSintoma { get; set; }
        public string SintNome { get; set; }

        public virtual IEquatable<Reporte> Reportes { get; set; }
    }
}