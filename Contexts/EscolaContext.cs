using escola.Models;
using Microsoft.EntityFrameworkCore;

namespace escola.Contexts
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("aluno");
            modelBuilder.Entity<Aluno>()
                .HasOne(e => e.Turma)
                .WithMany(e=> e.Aluno)
                .HasForeignKey(e => e.turmaid_Id);

            modelBuilder.Entity<Turma>().ToTable("turma");
        }

        public DbSet<Aluno> Aluno { get; set; }

        public DbSet<escola.Models.Turma>? Turma { get; set; }
    }
}
