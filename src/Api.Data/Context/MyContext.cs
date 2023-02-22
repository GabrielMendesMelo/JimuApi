using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<AlimentoEntity> Alimentos { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            if (Alimentos == null)
            {
                Alimentos = Set<AlimentoEntity>();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AlimentoEntity>(new AlimentoMap().Configure);
        }
    }
}
