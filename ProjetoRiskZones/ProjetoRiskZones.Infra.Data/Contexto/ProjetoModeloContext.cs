using ProjetoRiskZones.Domain.Entities;
using ProjetoRiskZones.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoRiskZones.Infra.Data.Contexto
{
    public class ProjetoModeloContext : DbContext
    {

        public ProjetoModeloContext()
            : base ("ProjetoRiskZones")
        {

        }
        //BdSet: Comando pra criar a tabela da class
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sintoma> Sintomas { get; set; }
        public DbSet<Risco> Riscos { get; set; }
        public DbSet<Reporte> Reportes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {  
            //Desabilitando algumas convenções

            //Não plulariza as tabelas do banco
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Não deleta itens em cascatas, com relação de um pra muitos
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //Não deleta relação em cascata, com relação de muitos pra muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Toda vez que tiver numa entidade diver "Id" ser uma Primerkey 
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());
            //Inperdir que as classe tipo string não seja tipo "Nvarch" que ocupa mais espaço
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
            
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new SintomaConfiguration());
            modelBuilder.Configurations.Add(new ReporteConfiguration());
            modelBuilder.Configurations.Add(new RiscoConfiguration());


        }

        public override int SaveChanges()
        {
            /*foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }*/
            return base.SaveChanges();
        }
    }
}
