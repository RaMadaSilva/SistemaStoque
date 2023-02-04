
using GestãoDeEstoque.Data;
using Microsoft.EntityFrameworkCore;

namespace GestãoDeEstoque.Repositorio
{
    public class Repositorio<TModel> where TModel : class
    {
        private readonly MyContext _context;

        public Repositorio(MyContext context)
            => _context = context;

        public void Criar(TModel model)
        {
            _context.Set<TModel>().Add(model);
            _context.SaveChanges();

        }

        public IEnumerable<TModel> Ler()
            => _context.Set<TModel>().AsNoTracking().ToList();


        public TModel Ler(int id)
            => _context.Set<TModel>().Find(id)!;

        public void Actualizar(int id)
        {
            var model = _context.Set<TModel>().Find(id)!;
            _context.Set<TModel>().Update(model);
            _context.SaveChanges();
        }

        public void Actualizar(TModel model)
        {
            _context.Set<TModel>().Update(model);
            _context.SaveChanges();
        }
    }
}