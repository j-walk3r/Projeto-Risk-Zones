using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRiskZones.Domain.Entities
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Raca { get; set; }
        public string Senha { get; set; }
        public string IDUsuario { get; set; }
        public string IDFacebook { get; set; }
        public DateTime Nascimento { get; set; }
        public bool ISMembro { get; set; }

        // public virtual IEquatable<Reporte> Reportes { get; set; }

    }
}
