using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalCore.Models
{
    public class TipoProduto
    {
        public TipoProduto()
        {
            // inicialização da lista de Produtos de um Tipo de Produto
            ListaTipoProduto = new HashSet<Produto>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string descricao { get; set; }

        // um TipoPagamento tem uma coleção de compras
        public virtual ICollection<Produto> ListaTipoProduto { get; set; }
    }
}