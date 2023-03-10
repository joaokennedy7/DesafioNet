using DesafioNet.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioNet.Data.Mappings
{
    class ChaveMapping : IEntityTypeConfiguration<Chave>
    {
        public void Configure(EntityTypeBuilder<Chave> builder)
        {
            builder.HasKey(x => x.Id); // Indicando que Id será a chave primaria

            builder.Property(t => t.Descricao)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.ToTable("Chave");
        }
    }
}
