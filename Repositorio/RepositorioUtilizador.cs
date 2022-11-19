using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestãoDeEstoque.Data;
using GestãoDeEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace GestãoDeEstoque.Repositorio
{
    public class RepositorioUtilizador : Repositorio<Utilizador>
    {
        MyContext _context = new MyContext();

        public void Remover(int id)
        {
            var usr = _context.Utilizadores.FirstOrDefault(x => x.Id == id);
            usr.Remover();
            _context.Utilizadores.Update(usr);
            _context.SaveChanges();
        }
        public IEnumerable<Utilizador> LerUtilizadoresActivos()
            => _context.Utilizadores.AsNoTracking().Where(x => x.Removido == false).ToList();
    }
}
