using ProjetoRiskZones.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoRiskZones.Infra.Data.EntityConfig
{
    public class RiscoConfiguration : EntityTypeConfiguration<Risco>
    {
        public RiscoConfiguration()
        {
            HasKey(c => c.IDRisco);

            Property(c => c.RiscoNome)
                .IsRequired();
            
        }
    }
}
