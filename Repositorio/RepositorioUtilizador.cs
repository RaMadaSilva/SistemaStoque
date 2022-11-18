using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestãoDeEstoque.Data;
using GestãoDeEstoque.Models;

namespace GestãoDeEstoque.Repositorio
{
    public class RepositorioUtilizador : Repositorio<Utilizador>
    {
        MyContext _context = new MyContext();

    }
}
