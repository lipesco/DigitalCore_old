using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalCore.Models
{
    public class TipoPagamento
    {
        public TipoPagamento()
        {
            // inicialização da lista de compras de um cliente
            ListaCompras = new HashSet<Compra>();
        }

        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Descricao { get; set; }

        // um TipoPagamento tem uma coleção de compras
        public virtual ICollection<Compra> ListaCompras { get; set; }

    }
}