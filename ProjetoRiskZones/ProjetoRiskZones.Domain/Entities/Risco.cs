using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRiskZones.Domain.Entities
{
    public class Risco
    {
        public int IDRisco { get; set; }
        public string RiscoNome { get; set; }

        public virtual IEquatable<Reporte> Reportes { get; set; }

    }
}
