using ProjetoRiskZones.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoRiskZones.Infra.Data.EntityConfig
{
    public class SintomaConfiguration : EntityTypeConfiguration<Sintoma>
    {
        public SintomaConfiguration()
        {
            HasKey(c => c.IDSintoma);

            Property(c => c.SintNome)
                .IsRequired();

        }
    }
}
