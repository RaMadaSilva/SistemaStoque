using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestãoDeEstoque.Models;
using GestãoDeEstoque.Repositorio;

namespace GestãoDeEstoque.Ecrans.User
{
    public static class EcranCrud
    {

        public static void Novo()
        {

            Console.Clear();
            Console.WriteLine("Inserir Novo Utilizador");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.Write("Nome: ");
            var nome = Console.ReadLine()!;
            Console.Write("Função: ");
            var funcao = Console.ReadLine()!;
            Console.WriteLine();

            var ul = new Utilizador(nome, funcao);
            var repo = new RepositorioUtilizador();
            repo.Criar(ul);
            Console.WriteLine("Utilizador Criado com Sucecesso ");
            Console.WriteLine("Prima qualquer tecla para sair");
            Console.ReadKey();
            MenuUtilizador.Load();

        }
        public static void LerTodos()
        {
            Console.Clear();
            var repo = new RepositorioUtilizador();
            var repo1 = new Repositorio<Utilizador>();
            var itens = repo.Ler();
            var values = repo1.Ler();
            foreach (var item in itens)
            {
                Console.WriteLine(item);
            }
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Prima qualquer tecla para sair");
            Console.ReadKey();
            MenuUtilizador.Load();
        }

        public static void LerUm()
        {
            Console.Clear();
            Console.Write("Inser O Id do Utilizador: ");
            var entrada = int.TryParse(Console.ReadLine(), out int id);

            if (entrada)
            {
                Console.Clear();
                Console.WriteLine("Utilizador Selecionado");
                var repo = new RepositorioUtilizador();
                var repo1 = new Repositorio<Utilizador>();
                var user = repo.Ler(id);
                var usr = repo1.Ler(id);
                Console.WriteLine(user);
                Console.WriteLine(usr);

                Console.WriteLine();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Prima qualquer tecla para sair");
                Console.ReadKey();
                MenuUtilizador.Load();
            }
        }
    }
}