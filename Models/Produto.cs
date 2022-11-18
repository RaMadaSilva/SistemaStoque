using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoDeEstoque.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public DateTime DataFabrico { get; set; }
        public DateTime DataExpiracao { get; set; }
        public double PrecoTotal { get; set; }
        public Categoria Categoria { get; set; } = null!;

        public IEnumerable<Utilizador> Utilizadores { get; set; }
        public IEnumerable<Fornecedor> Fornecedores { get; set; }

        public Produto()
        {
            Utilizadores = new List<Utilizador>();
            Fornecedores = new List<Fornecedor>();
        }

    }
}