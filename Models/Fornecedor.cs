using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoDeEstoque.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Pais { get; set; } = string.Empty;
        public IList<Produto> Produtos { get; set; }

        public Fornecedor()
        {
            Produtos = new List<Produto>();
        }
    }
}