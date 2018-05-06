namespace DigitalCore.Migrations
{
    using DigitalCore.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DigitalCoreDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DigitalCoreDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //*********************************************************************
            // adiciona Clientes
            var cliente = new List<Cliente> {
                new Cliente {ID=1, Nome="Miguel Vitor", username="mvitor", password="123", morada="Rua do Comércio, Nº18", email="mvitor@gmail.com", telefone=249123456, NIF=115347923 },
                new Cliente {ID=2, Nome="Pedro Conceição", username="pconceicaor", password="213", morada="Rua João Torres, Nº94", email="pconceicao@yahoo.com", telefone=249765638, NIF=115836783 },
                new Cliente {ID=3, Nome="Maria Isabel", username="misabel", password="321", morada="Praça do Bom Jardim, Nº25", email="misabel@sapo.pt", telefone=249654321, NIF=102385734 },
                new Cliente {ID=4, Nome="João Silva", username="jsilva", password="132", morada="Rua da Alcântara, Nº142", email="jsilva@gmail.pt", telefone=249538247, NIF=201482693 },
                new Cliente {ID=5, Nome="Teresa Pinheiro", username="tpinheiro", password="312", morada="Rua D. Pedro, Nº11", email="tpinheiro@hotmail.com", telefone=249823953, NIF=159385395 },
                new Cliente {ID=6, Nome="Marta Santos", username="msantos", password="231", morada="Rua Oliveira Gaio, Nº275", email="msantos@sapo.pt", telefone=249839258, NIF=128573957 }
            };
            cliente.ForEach(CL => context.Cliente.AddOrUpdate(cl => cl.Nome, CL));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Tipo de Produtos
            var tipoProduto = new List<TipoProduto> {
                new TipoProduto {ID=1, descricao="Computador Desktop"},
                new TipoProduto {ID=2, descricao="Monitor"},
                new TipoProduto {ID=3, descricao="Portátil"},
                new TipoProduto {ID=4, descricao="Tablet"},
                new TipoProduto {ID=5, descricao="Disco"},
                new TipoProduto {ID=6, descricao="Memória RAM"},
                new TipoProduto {ID=7, descricao="Placa Gráfica"},
                new TipoProduto {ID=8, descricao="Impressora"},
                new TipoProduto {ID=9, descricao="Pen USB"},
                new TipoProduto {ID=10, descricao="Rato"},
                new TipoProduto {ID=11, descricao="Teclado"}


            };
            tipoProduto.ForEach(TPR => context.TipoProduto.AddOrUpdate(tpr => tpr.descricao, TPR));
            context.SaveChanges();


            //*********************************************************************
            // adiciona Tipo de Produtos
            var produto = new List<Produto> {
                new Produto {ID=1, numeroSerie=123456789, tipo=1, descricao="HP Omen 880-106Np", caracteristicas="Processador Intel i7 8700, RAM 16GB", preco="€1200", imagem="computador01.jpg" },
                new Produto {ID=2, numeroSerie=123456790, tipo=5, descricao="Toshiba TR200 3D TLC SATA III", caracteristicas="Disco SSD 240GB", preco="€55", imagem="discossd01.jpg" },
                new Produto {ID=3, numeroSerie=123456791, tipo=1, descricao="Asus ROG GR8II-T022Z Auta", caracteristicas="Processador Intel i5 7400, RAM 9GB", preco="€950", imagem="computador02.jpg" },
                new Produto {ID=4, numeroSerie=123456792, tipo=1, descricao="Asus D320MT", caracteristicas="Processador Intel i7 7700, RAM 8GB", preco="€600", imagem="computador03.jpg" },
                new Produto {ID=5, numeroSerie=123456793, tipo=5, descricao="Samsung 500GB EVO 850", caracteristicas="Disco SSD 500GB", preco="€125", imagem="discossd02.jpg" },
                new Produto {ID=6, numeroSerie=123456794, tipo=5, descricao="Kingston 120GB SSD A400 SATA III", caracteristicas="Disco SSD 120GB", preco="€35", imagem="discossd03.jpg" },
                new Produto {ID=7, numeroSerie=123456795, tipo=3, descricao="HP 15-bs109np", caracteristicas="Processador Intel i5 8250U, RAM 8GB, Disco 1TB", preco="€550", imagem="portatil01.jpg" },
                new Produto {ID=8, numeroSerie=123456796, tipo=3, descricao="Asus Zenbook UX430UA-78DHDCB1", caracteristicas="Processador Intel i7-8550U, 16GB RAM, Disco SSD 512GB", preco="€55", imagem="portatil02.jpg" }

            };
            produto.ForEach(PR => context.Produto.AddOrUpdate(pr => pr.numeroSerie, PR));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Tipo de Pagamentos
            var tipoPagamento = new List<TipoPagamento> {
                new TipoPagamento {ID=1, descricao="Cartão de Crédito"},
                new TipoPagamento {ID=2, descricao="Multibanco"},
                new TipoPagamento {ID=3, descricao="Paypal"}
            };
            tipoPagamento.ForEach(TPC => context.TipoPagamento.AddOrUpdate(tpc => tpc.descricao, TPC));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Compras
            var compra = new List<Compra> {
                new Compra {ID=1, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=1, PagamentoFK=1 },
                new Compra {ID=2, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=3, PagamentoFK=2 },
                new Compra {ID=3, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=6, PagamentoFK=1 },
                new Compra {ID=4, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=1, PagamentoFK=1 },
                new Compra {ID=5, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=2, PagamentoFK=1 },
                new Compra {ID=6, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=5, PagamentoFK=3 },
                new Compra {ID=7, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=2, PagamentoFK=1 },
                new Compra {ID=8, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=4, PagamentoFK=1 },
                new Compra {ID=9, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=5, PagamentoFK=3 },
                new Compra {ID=10, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=3, PagamentoFK=2 }

            };
            compra.ForEach(C => context.Compra.AddOrUpdate(c => c.dataCompra, C));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Relação Compras & Produto
            var produtoCompra = new List<ProdutoCompra> {
                new ProdutoCompra {ID=1, IDProd=1, IDCompr=1, quantidade=1, IVA="23" },
                new ProdutoCompra {ID=2, IDProd=4, IDCompr=2, quantidade=1, IVA="23" },
                new ProdutoCompra {ID=3, IDProd=8, IDCompr=3, quantidade=1, IVA="23" },
                new ProdutoCompra {ID=4, IDProd=3, IDCompr=4, quantidade=1, IVA="23" },
                new ProdutoCompra {ID=5, IDProd=1, IDCompr=5, quantidade=1, IVA="23" },
                new ProdutoCompra {ID=6, IDProd=5, IDCompr=6, quantidade=1, IVA="23" },
                new ProdutoCompra {ID=7, IDProd=6, IDCompr=7, quantidade=1, IVA="23" },
                new ProdutoCompra {ID=8, IDProd=2, IDCompr=8, quantidade=1, IVA="23" },
                new ProdutoCompra {ID=9, IDProd=7, IDCompr=9, quantidade=1, IVA="23" },
                new ProdutoCompra {ID=10, IDProd=1, IDCompr=10, quantidade=1, IVA="23" }
            };
            produtoCompra.ForEach(PC => context.ProdutoCompra.AddOrUpdate(pc => pc.IDProd, PC));
            context.SaveChanges();




        }
    }
}
