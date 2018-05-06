using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DigitalCore.Models
{
    public class DigitalCoreDb : DbContext
    {

        // criar o construtor
        public DigitalCoreDb() : base("DigitalCoreDbConnectionString")
        {

        }

        // definir as 'tabelas' da base de dados
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<TipoPagamento> TipoPagamento { get; set; }
        public virtual DbSet<ProdutoCompra> ProdutoCompra { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<TipoProduto> TipoProduto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}