using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace relatorio.Models.EntityConfig
{
    public class PublicadorConfig : IEntityTypeConfiguration<Publicador>
    {
        public void Configure(EntityTypeBuilder<Publicador> builder)
        {
            builder.ToTable("Publicador");
            
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Nome)
                .HasColumnType("varchar(80)")
                .HasMaxLength(80)
                .IsRequired();
            
            builder.HasOne(x => x.Grupo)
                .WithMany()
                .HasForeignKey(x => x.GrupoId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.Property(x => x.Sexo).HasColumnType("varchar(5)");
        }
    }
}