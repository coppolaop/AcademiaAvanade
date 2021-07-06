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
            modelBuilder.Entity<Cidade>().ToTable("Cidades");
            modelBuilder.Entity<Estado>().ToTable("Estados");

        }

    }
}
