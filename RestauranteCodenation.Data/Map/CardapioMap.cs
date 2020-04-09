using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteCodenation.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Data.Map
{
    class CardapioMap : IEntityTypeConfiguration<Cardapio>
    {
        public void Configure(EntityTypeBuilder<Cardapio> builder)
        {
            builder.ToTable("Cardapio");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(x => x.Descricao)
               .HasColumnType("varchar(100)");
        }
    }
}
