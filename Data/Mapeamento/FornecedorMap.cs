using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestãoDeEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestãoDeEstoque.Data.Mapeamento
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey("Id");
            builder.Property("Id").ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property("Nome").IsRequired().HasColumnName("Nome").HasColumnType("NVARCHAR").HasMaxLength(80);
            builder.Property("Pais").IsRequired().HasColumnName("Pais").HasColumnType("NVARCHAR").HasMaxLength(120).HasDefaultValue("ANGOLA");


        }
    }
}