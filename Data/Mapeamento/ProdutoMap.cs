using System.Security.Cryptography.X509Certificates;
using GestãoDeEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestãoDeEstoque.Data.Mapeamento
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey("Id");
            builder.Property("Id").ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property("Nome").IsRequired().HasColumnName("Nome")
                 .HasColumnType("NVARCHAR").HasMaxLength(80);

            builder.Property("Quantidade").IsRequired().HasColumnName("Quantidade")
                .HasColumnType("INT");

            builder.Property("PrecoUnitario").IsRequired().HasColumnName("PrecoUnitario")
                .HasColumnType("FLOAT");
            builder.Property("DataFabrico").IsRequired().HasColumnName("DataFabrico")
                .HasColumnType("DATETIME");
            builder.Property("DataExpiracao").IsRequired().HasColumnName("DataExpiracao")
                .HasColumnType("DATETIME");
            builder.Property("PrecoTotal").IsRequired().HasColumnName("PrecoTotal")
                .HasColumnType("FLOAT");

            //Relacionamentos;

            builder.HasOne(x => x.Categoria).WithMany(x => x.Produtos).HasForeignKey("CategoriaId")
                .HasConstraintName("FK_CategoriaId");

            builder.HasMany(x => x.Fornecedores).WithMany(x => x.Produtos)
                .UsingEntity<Dictionary<string, object>>("ProductoFornecedor",
                prod => prod.HasOne<Fornecedor>().WithMany().HasForeignKey("ProdutoId")
                .HasConstraintName("FK_ProdutoForneccedor_ProdutoId"),
                    forn => forn.HasOne<Produto>().WithMany().HasForeignKey("FornecedorId")
                    .HasConstraintName("FK_ProdutoFornecedor_FornecedorId"));

            builder.HasMany(x => x.Utilizadores).WithMany(x => x.Produtos)
                .UsingEntity<Dictionary<string, object>>(
                    "ProdutoUtilizadores", produto => produto.HasOne<Utilizador>().WithMany()
                    .HasForeignKey("UtilizadorId").HasConstraintName("FK_ProdutoUtilizadores_UtilizadorId"),
                    utilizador => utilizador.HasOne<Produto>().WithMany()
                    .HasForeignKey("ProdutoId").HasConstraintName("FK_ProdutoUtilizador_ProdutoId")
                );







        }
    }
}