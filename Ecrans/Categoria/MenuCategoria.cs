using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoDeEstoque.Ecrans.Categoria
{
    public static class MenuCategoria
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("+ CATEGORIAS + ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("-1 = INSERIR NOVO CATEGORIA");
            Console.WriteLine("-2 = LISTAR TODOS CATEGORIAS");
            Console.WriteLine("-3 = LISTAR UM CATEGORIA");
            Console.WriteLine("-4 = ACTUALIZAR CATEGORIA");
            Console.WriteLine("-5 = DAR BAIXA DE CATEGORIA");
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