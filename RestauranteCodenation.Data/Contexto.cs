﻿using Microsoft.EntityFrameworkCore;
using RestauranteCodenation.Data.Map;
using RestauranteCodenation.Domain;
using System;

namespace RestauranteCodenation.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cardapio> Cardapio { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Ingrediente> Ingredinte { get; set; }
        public DbSet<Prato> Prato { get; set; }
        public DbSet<TipoPrato> TipoPrato { get; set; }
        public DbSet<PratosIngredientes> PratosIngredientes { get; set; }
        public DbSet<AgendaCardapio> AgendaCardapio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-REEDLKL\SQLEXPRESS;Database=Codenation;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Aplicou essas configurações para que o model possa enxergar o que foi configurado nas classes MAP
            modelBuilder.ApplyConfiguration(new IngredienteMap());
            modelBuilder.ApplyConfiguration(new AgendaMap());
            modelBuilder.ApplyConfiguration(new CardapioMap());
            modelBuilder.ApplyConfiguration(new PratoMap());
            modelBuilder.ApplyConfiguration(new TipoPratoMap());
            modelBuilder.ApplyConfiguration(new PratosIngredientesMap());
            modelBuilder.ApplyConfiguration(new AgendaCardapioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
