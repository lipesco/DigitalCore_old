using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DigitalCore.Models
{
    public class Compra
    {
        public Compra()
        {
            ListaDeObjectosProdutoCompra = new HashSet<ProdutoCompra>();
        }

        public int ID { get; set; }

        [Column(TypeName = "date")] //só regista 'datas', não 'horas'
        public DateTime DataCompra { get; set; }

        [Column(TypeName = "date")] //só regista 'datas', não 'horas'
        public DateTime DataEntrega { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteFK { get; set; }
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("TipoPagamento")]
        public int PagamentoFK { get; set; }
        public virtual TipoPagamento TipoPagamento { get; set; }

        public virtual ICollection<ProdutoCompra> ListaDeObjectosProdutoCompra { get; set; }

    }
}