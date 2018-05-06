using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalCore.Models
{
    public class Cliente
    {
        public Cliente()
        {
            // inicialização da lista de compras de um cliente
            ListaCompras = new HashSet<Compra>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required]
        [StringLength(30)]
        public string username { get; set; }

        [Required]
        [StringLength(30)]
        public string password { get; set; }

        [Required]
        [StringLength(30)]
        public string morada { get; set; }

        [Required]
        [StringLength(30)]
        public string email { get; set; }

        public float telefone { get; set; }

        public float NIF { get; set; }

        // um cliente tem uma coleção de compras
        public virtual ICollection<Compra> ListaCompras { get; set; }

        

    }
}