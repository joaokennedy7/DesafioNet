using DesafioNet.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioNet.Data.Mappings
{
    class RecebedorMapping : IEntityTypeConfiguration<Recebedor>
    {
        public void Configure(EntityTypeBuilder<Recebedor> builder)
        {
            builder.HasKey(x => x.Id); // Indicando que Id será a chave primaria
            builder.Property(t => t.Nome)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.ToTable("Recebedor");
        }
    }
}
