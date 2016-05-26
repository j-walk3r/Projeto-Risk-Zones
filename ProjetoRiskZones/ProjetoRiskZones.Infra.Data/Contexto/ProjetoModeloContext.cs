using ProjetoRiskZones.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRiskZones.Infra.Data.Contexto
{
    class ProjetoModeloContext : DbContext
    {

        public ProjetoModeloContext()
            : base ("ProjetoRiskZones")
        {

        }
        //BdSet: Comando pra criar a tabela da class
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
