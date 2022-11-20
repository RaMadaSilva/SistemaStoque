using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoDeEstoque.Ecrans.User
{
    public static class MenuUtilizador
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("+ UTILIZADORES + ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("-1 = Inserir Novo Utilizador");
            Console.WriteLine("-2 = Listar Todos Utilizadores");
            Console.WriteLine("-3 = Listar Utilizadores Activos");
            Console.WriteLine("-4 = Listar Um Utilizador");
            Console.WriteLine("-5 = Actualizar  Utilizador");
            Console.WriteLine("-6 = Desativar  Utilizador");
            Console.WriteLine("-0 = Voltar Ao Menu Principal");
            Console.WriteLine("-----------------------------");
            Console.Write("Escolhe uma das opções: ");

            var valor = int.TryParse(Console.ReadLine(), out int opcao);
            if (valor)
            {
                switch (opcao)
                {
                    case 1:
                        EcranCrud.Novo(); break;
                    case 2:
                        EcranCrud.LerTodos(); break;
                    case 3:
                        EcranCrud.LerActivos(); break;
                    case 4:
                        EcranCrud.LerUm(); break;
                    case 5:
                        EcranCrud.Actualizar(); break;
                    case 6:
                        EcranCrud.Remover(); break;
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