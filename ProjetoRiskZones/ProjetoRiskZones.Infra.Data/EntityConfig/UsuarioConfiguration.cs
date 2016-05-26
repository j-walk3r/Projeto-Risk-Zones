using ProjetoRiskZones.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoRiskZones.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(c => c.ID);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
