
using GestãoDeEstoque.Data;
using Microsoft.EntityFrameworkCore;

namespace GestãoDeEstoque.Repositorio
{
    public class Repositorio<TModel> where TModel : class
    {
        MyContext _context = new MyContext();

        public void Criar(TModel model)
        {
            _context.Set<TModel>().Add(model);
            _context.SaveChanges();

        }

        public IEnumerable<TModel> Ler()
            => _context.Set<TModel>().AsNoTracking().ToList();


        public TModel Ler(int id)
            => _context.Set<TModel>().Find(id);
        public void Actualizar(int id)
        {
            var model = _context.Set<TModel>().Find(id);
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