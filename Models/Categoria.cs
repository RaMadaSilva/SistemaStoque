using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoDeEstoque.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public IEnumerable<Produto> Produtos { get; set; }

        public Categoria()
        {
            Produtos = new List<Produto>();
        }

    }
}