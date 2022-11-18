using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestãoDeEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestãoDeEstoque.Data.Mapeamento
{
    public class UtilizadorMap : IEntityTypeConfiguration<Utilizador>
    {
        public void Configure(EntityTypeBuilder<Utilizador> builder)
        {
            builder.ToTable("Utilizador");

            builder.HasKey("Id");

            builder.Property("Id").ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property("Nome").IsRequired().HasColumnName("Nome").HasColumnType("NVARCHAR").HasMaxLength(80);

            builder.Property("Funcao").IsRequired().HasColumnName("Funcao").HasColumnType("NVARCHAR").HasMaxLength(60);

            builder.Property("Removido").IsRequired().HasColumnName("Removido").HasColumnType("BIT");

        }
    }
}