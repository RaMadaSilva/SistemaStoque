using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoDeEstoque.Ecrans.Fornecedor
{
    public static class MenuFornecedor
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("+ FORNECEDORES + ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("-1 = INSERIR NOVO FORNECEDOR");
            Console.WriteLine("-2 = LISTAR TODOS FORNECEDORS");
            Console.WriteLine("-3 = LISTAR UM FORNECEDOR");
            Console.WriteLine("-4 = ACTUALIZAR FORNECEDOR");
            Console.WriteLine("-5 = DAR BAIXA DE FORNECEDOR");
            Console.WriteLine("-0 = VOLTAR AO MENU PRINCIPAL");
            Console.WriteLine("-----------------------------");
            Console.Write("Escolhe uma das opções: ");


            var valor = int.TryParse(Console.ReadLine(), out int opcao);
            if (valor)
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Caso 1"); break;
                    case 2:
                        Console.WriteLine("Caso 2"); break;
                    case 3:
                        Console.WriteLine("Caso 3"); break;
                    case 4:
                        Console.WriteLine("Caso 4"); break;
                    case 5:
                        Console.WriteLine("Caso 5"); break;
                    case 0:
                        MenuPrincipal.Menu(); break;
                    default:
                        Load(); break;

                }

            }
            else
            {
                Console.WriteLine("Valor Invalido prima qualquer tecla para continuar");
                Console.ReadKey();
                Load();
            }
        }
    }
}