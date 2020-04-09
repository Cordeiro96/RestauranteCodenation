using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteCodenation.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Data.Map
{
    public class IngredienteMap : IEntityTypeConfiguration<Ingredinte>
    {

        void IEntityTypeConfiguration<Ingredinte>.Configure(EntityTypeBuilder<Ingredinte> builder)
        {
            builder.ToTable("Ingrediente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(500)");
        }
    }
}
