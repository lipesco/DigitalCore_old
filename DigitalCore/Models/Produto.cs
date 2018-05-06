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

        public int ID { get; set; }

        [Required]
        public int numeroSerie { get; set; }

        [Required]
        public int tipo { get; set; }

        [Required]
        public string descricao { get; set; }

        [Required]
        public string caracteristicas { get; set; }

        [Required]
        public string preco { get; set; }

        public string imagem { get; set; }

        public virtual ICollection<ProdutoCompra> ListaDeObjectosProdutoCompra { get; set; }


    }
}