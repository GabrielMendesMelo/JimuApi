using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class AlimentoMap : IEntityTypeConfiguration<AlimentoEntity>
    {
        public void Configure(EntityTypeBuilder<AlimentoEntity> builder)
        {
            builder.ToTable("Alimento");

            builder.HasKey(a => a.Id);

            builder.HasIndex(a => a.Nome)
                .IsUnique();
        }
    }
}
