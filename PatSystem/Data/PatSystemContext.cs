using Microsoft.EntityFrameworkCore;
using PatSystem.Models.Curriculo;
using PatSystem.Models.Curriculo.Cursos;
using PatSystem.Models.SegDesemprego;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Data
{
    public class PatSystemContext : DbContext
    {
        public PatSystemContext(DbContextOptions<PatSystemContext> options)
               : base(options)
        {
        }

        public DbSet<PatSystem.Models.Curriculo.Cliente> Cliente { get; set; }
        public DbSet<PatSystem.Models.Curriculo.Curriculo> Curriculo { get; set; }
        public DbSet<PatSystem.Models.Curriculo.Experiencia> Experiencia { get; set; }
        public DbSet<PatSystem.Models.Curriculo.Idioma> Idioma { get; set; }
        public DbSet<PatSystem.Models.Curriculo.Cursos.CursoSuperior> CursoSuperior { get; set; }
        public DbSet<PatSystem.Models.Curriculo.Cursos.CursoTecnico> CursoTecnico { get; set; }
        
        public DbSet<PatSystem.Models.SegDesemprego.Seguro> Seguro { get; set; }
        public DbSet<PatSystem.Models.SegDesemprego.Cbo> Cbo { get; set; }
        public DbSet<PatSystem.Models.SegDesemprego.Empresa> Empresa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(sc =>  sc.ClienteId);
            modelBuilder.Entity<Curriculo>().HasKey(sc => sc.CurriculoID);
            modelBuilder.Entity<Experiencia>().HasKey(sc => new { sc.CurriculoID, sc.ExperienciaId});
            modelBuilder.Entity<Idioma>().HasKey(sc => new { sc.CurriculoID, sc.IdiomaId});
            modelBuilder.Entity<CursoSuperior>().HasKey(sc => new { sc.CurriculoID, sc.CursoSuperiorId});
            modelBuilder.Entity<CursoTecnico>().HasKey(sc => new { sc.CurriculoID, sc.CursoTecnicoId});
            modelBuilder.Entity<Seguro>().HasKey(Pk => Pk.SeguroId);
            modelBuilder.Entity<Cbo>().HasKey(Pk => Pk.CodCboId);
            modelBuilder.Entity<Empresa>().HasKey(Pk => Pk.EmpresaId);
        }
    }
}
