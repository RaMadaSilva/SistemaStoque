using System;
using GestãoDeEstoque.Ecrans.Categoria;
using GestãoDeEstoque.Ecrans.Fornecedor;
using GestãoDeEstoque.Ecrans.Produto;
using GestãoDeEstoque.Ecrans.User;

namespace GestãoDeEstoque.Ecrans
{
    public static class MenuPrincipal
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("+ MENU PRICIPAL + ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("-1 = Gestão de Produtos");
            Console.WriteLine("-2 = Gestão de Fornecedores");
            Console.WriteLine("-3 = Gestão de Categorias");
            Console.WriteLine("-4 = Gestão de Utilizadores");
            Console.WriteLine("-0 = Encerrar o programa");
            Console.WriteLine("-----------------------------");
            Console.Write("Escolhe uma das opções: ");


            var valor = int.TryParse(Console.ReadLine(), out int opcao);
            if (valor)
            {

                switch (opcao)
                {
                    case 1:
                        MenuProduto.Load(); break;
                    case 2:
                        MenuFornecedor.Load(); break;
                    case 3:
                        MenuCategoria.Load(); break;
                    case 4:
                        MenuUtilizador.Load(); break;
                    case 0:
                        Environment.Exit(0); break;
                }
            }
            else
            {

                Console.WriteLine("Valor Invalido prima qualquer tecla para continuar");
                Console.ReadKey();
                Menu();
            }
        }

    }
}