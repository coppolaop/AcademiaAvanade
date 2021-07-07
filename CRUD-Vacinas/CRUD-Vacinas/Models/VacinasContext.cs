using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Vacinas.Models
{
    public class VacinasContext : DbContext
    {

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cidade>( p => {
                p.ToTable("Cidades");
                p.HasKey(p => p.CodCidade);
                p.Property(p => p.Nome);
                p.Property(p => p.Populacao).HasColumnType("INTEGER");
                p.Property(p => p.Aniversario).HasColumnType("DATETIME");
            });


            modelBuilder.Entity<Estado>( p => {
                p.ToTable("Estados");
                p.HasKey(p => p.CodEstado);
                p.Property(p => p.Nome);
                p.Property(p => p.Fundacao).HasColumnType("DATETIME");
                p.Property(p => p.Populacao).HasColumnType("INTEGER");
                p.Property(p => p.Sigla).HasColumnType("CHAR(2)").HasColumnName("UF");
                p.HasMany(p => p.Cidades)
                   .WithOne(p => p.NomeEstado)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasConstraintName("CodEstado")
                   .HasForeignKey("CodEstado");
            });

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
       "Server=localhost;Database=Vacinas;Uid=root;Pwd=root;";

            var serverVersion = ServerVersion.AutoDetect(connectionString);
            
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

    }
}
