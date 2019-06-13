using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevisaoOficial_Web1.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

    }
}