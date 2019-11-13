using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace relatorio.Models.EntityConfig
{
    public class GrupoConfig : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("Grupo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Responsavel).HasColumnType("varchar(80)").HasMaxLength(80);
        }
    }
}