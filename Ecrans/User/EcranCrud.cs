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
            Console.WriteLine("Lista de Utilizadores");
            Console.WriteLine();
            var repo = new RepositorioUtilizador();
            var itens = repo.Ler();
            Console.WriteLine("------------------------------------------"); ;
            foreach (var item in itens)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Prima qualquer tecla para sair");
            Console.ReadKey();
            MenuUtilizador.Load();
        }

        public static void LerActivos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Utilizadores Activos");
            Console.WriteLine();
            var repo = new RepositorioUtilizador();
            var itens = repo.LerUtilizadoresActivos();
            Console.WriteLine("------------------------------------------");
            foreach (var item in itens)
            {
                Console.WriteLine(item);
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
            Console.WriteLine("Listar um Utilizadore");
            Console.WriteLine();
            Console.Write("Inser O Id do Utilizador: ");
            var entrada = int.TryParse(Console.ReadLine(), out int id);

            if (entrada)
            {
                Console.Clear();
                Console.WriteLine("Utilizador Selecionado");
                var repo = new RepositorioUtilizador();
                var user = repo.Ler(id);
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(user);

                Console.WriteLine();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Prima qualquer tecla para sair");
                Console.ReadKey();
                MenuUtilizador.Load();
            }
            else
            {
                Console.WriteLine("O valor inserido é invalido");
                Console.WriteLine();
                Console.WriteLine("Prima qualquer tecla para sair");
                Console.ReadKey();
                MenuUtilizador.Load();
            }
        }

        public static void Remover()
        {
            Console.Clear();
            Console.WriteLine("Desativar de um Utilizador: ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.Write("Inser O Id do Utilizador: ");
            var entrada = int.TryParse(Console.ReadLine(), out int id);

            if (entrada)
            {
                var repo = new RepositorioUtilizador();
                var valido = repo.Remover(id);

                if (valido)
                {
                    Console.WriteLine("Utilizador removido com sucesso");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Prima qualquer tecla para sair");
                    Console.ReadKey();
                    MenuUtilizador.Load();
                }
                else
                {
                    Console.WriteLine("Não foi possivel remover Este utilizador");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Prima qualquer tecla para sair");
                    Console.ReadKey();
                    MenuUtilizador.Load();
                }

            }
            else
            {
                Console.WriteLine("O valor inserido é invalido");
                Console.WriteLine();
                Console.WriteLine("Prima qualquer tecla para sair");
                Console.ReadKey();
                MenuUtilizador.Load();
            }
        }
        public static void Actualizar()
        {
            Console.Clear();
            Console.WriteLine("Actualizar Utilizador");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.Write("Id: ");
            var validacao = int.TryParse(Console.ReadLine(), out int id)!;
            if (validacao)
            {
                Console.Write("Nome: ");
                var nome = Console.ReadLine()!;
                Console.Write("Função: ");
                var funcao = Console.ReadLine()!;
                Console.WriteLine();

                var user = new Utilizador(id, nome, funcao);
                var repo = new RepositorioUtilizador();

                repo.Actualizar(user);
                Console.WriteLine("Utilizador Actualizado com Sucecesso ");
                Console.WriteLine("Prima qualquer tecla para sair");
                Console.ReadKey();
                MenuUtilizador.Load();
            }
            else
            {
                Console.WriteLine("Id Invalido");
                Console.WriteLine("Prima qualquer tecla para sair");
                Console.ReadKey();
                MenuUtilizador.Load();
            }
        }
    }
}