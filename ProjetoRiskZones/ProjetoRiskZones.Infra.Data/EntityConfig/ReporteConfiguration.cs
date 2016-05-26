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

            Property(c => c.IDUsuario)
                .IsRequired();
            Property(c => c.IDSintoma)
                .IsRequired();

            Property(c => c.IDRisco)
                .IsRequired();

            Property(c => c.DataCheckin)
                .IsRequired();

        }
    }
}
