using GestãoDeEstoque.Data.Mapeamento;
using GestãoDeEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace GestãoDeEstoque.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; } = null!;
        public DbSet<Fornecedor> Fornecedores { get; set; } = null!;
        public DbSet<Produto> Produtos { get; set; } = null!;
        public DbSet<Utilizador> Utilizadores { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer("Server=RMATEIA-SILVA, 1433;Database=Stocagem;User Id=sa;Password=1q2w3e4r@#$;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new UtilizadorMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());


        }
    }
}