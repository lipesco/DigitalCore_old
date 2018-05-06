using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DigitalCore.Models
{
    public class ProdutoCompra
    {
        public int ID { get; set; } // PK, por exigência da Entity Framework

        // atributos específicos do relacionamento
        public int IDProduto { get; set; }
        public int IDCompra { get; set; }

        //***********************************************************************
        // definição da chave forasteira (FK) que referencia a classe Produto
        //***********************************************************************
        [ForeignKey("IDProd")]
        public Produto Produto { get; set; }
        public int IDProd { get; set; }

        //***********************************************************************
        // definição da chave forasteira (FK) que referencia a classe Compra
        //***********************************************************************
        [ForeignKey("IDCompr")]
        public Compra Compra { get; set; }
        public int IDCompr { get; set; }

        //***********************************************************************

        public float Quantidade { get; set; }

        public int IVA { get; set; }
    }
}