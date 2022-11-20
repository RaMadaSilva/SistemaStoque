using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoDeEstoque.Models
{
    public class Utilizador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public bool Removido { get; private set; }
        public IList<Produto> Produtos { get; set; }

        public Utilizador(string nome, string funcao)
        {
            Nome = nome;
            Funcao = funcao;
            Removido = false;
            Produtos = new List<Produto>();
        }

        public Utilizador(int id, string nome, string funcao)
        {
            Id = id;
            Nome = nome;
            Funcao = funcao;
            Produtos = new List<Produto>();

        }

        public void Remover()
        {
            Removido = true;
        }

        public override string ToString()
        {
            return $"Id: {Id} | Nome: {Nome} | Função: {Funcao}| Estado:{(Removido == false ? "Activo" : "Inativo")}";
        }
    }
}