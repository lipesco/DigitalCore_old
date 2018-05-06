using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalCore.Models
{
    public class Produto
    {
        public Produto()
        {
            ListaDeObjectosProdutoCompra = new HashSet<ProdutoCompra>();
        }

        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Descricao { get; set; }

        [Required]
        public int Preco { get; set; }

        [Required]
        public int NumeroSerie { get; set; }

        public virtual ICollection<ProdutoCompra> ListaDeObjectosProdutoCompra { get; set; }


    }
}