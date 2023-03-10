using DesafioNet.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioNet.Data.Mappings
{
    public class TransacaoMapping : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.DataTransacao)
                .IsRequired()
                .HasColumnType("date");

            builder.HasOne(p => p.Recebedor) // Temos um recebedor com varias transacoes
                .WithMany(p => p.Transacoes)
                .IsRequired();

            builder.HasOne(p => p.Pagador) // Termos um Pagador com varias transacoes
                .WithMany(p => p.Transacoes)
                .IsRequired();

            builder.ToTable("Transacoes");
        }
    }
}
