
using GestãoDeEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestãoDeEstoque.Data.Mapeamento
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey("Id");

            builder.Property("Id").ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property("Nome").IsRequired().HasColumnName("Nome").HasColumnType("NVARCHAR").HasMaxLength(80);

            builder.Property("Descricao").IsRequired().HasColumnName("Descricao").HasColumnType("NVARCHAR").HasMaxLength(500);

            //Relacionamentos

        }
    }
}