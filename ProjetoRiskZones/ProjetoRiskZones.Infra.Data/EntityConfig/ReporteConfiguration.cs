using ProjetoRiskZones.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoRiskZones.Infra.Data.EntityConfig
{
    public class ReporteConfiguration : EntityTypeConfiguration<Reporte>
    {
        public ReporteConfiguration()
        {
            HasKey(c => c.IDReporte);

            Property(c => c.Status)
                .IsRequired();

            Property(c => c.DataCheckin)
                .IsRequired();

            HasRequired(c => c.Usuario)
                .WithMany()
                .HasForeignKey(c => c.IDUsuario);

            HasRequired(c => c.Sitoma)
                .WithMany()
                .HasForeignKey(c => c.IDSintoma);

            HasRequired(c => c.Risco)
                .WithMany()
                .HasForeignKey(c => c.IDRisco);

        }
    }
}
