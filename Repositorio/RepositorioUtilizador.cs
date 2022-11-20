using GestãoDeEstoque.Data;
using GestãoDeEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace GestãoDeEstoque.Repositorio
{
    public class RepositorioUtilizador : Repositorio<Utilizador>
    {
        MyContext _context = new MyContext();

        public bool Remover(int id)
        {
            var usr = _context.Utilizadores.FirstOrDefault(x => x.Id == id)!;
            if (!usr.Removido)
            {
                usr.Remover();
                _context.Utilizadores.Update(usr);
                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }
        public IEnumerable<Utilizador> LerUtilizadoresActivos()
            => _context.Utilizadores.AsNoTracking().Where(x => x.Removido == false).ToList();
    }
}
