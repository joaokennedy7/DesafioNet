using DesafioNet.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioNet.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Transacao> Transacoes { get; set; }

        public DbSet<Recebedor> Recebedores { get; set; }

        public DbSet<Pagador> Pagadores { get; set; }

        public DbSet<Chave> Chaves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly); // Vai pegar todos mapeamentos(classes) que tiverem herdando ou implementando o IEntityType...
            base.OnModelCreating(modelBuilder);
        }
    }
}
