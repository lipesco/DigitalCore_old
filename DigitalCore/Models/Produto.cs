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
        public string Descricao { get; set; }

        [Required]
        public string Caracteristicas { get; set; }

        [Required]
        public int Preco { get; set; }

        public string Imagem { get; set; }

        [Required]
        public int NumeroSerie { get; set; }

        public virtual ICollection<ProdutoCompra> ListaDeObjectosProdutoCompra { get; set; }


    }
}