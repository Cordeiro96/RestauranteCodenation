using RestauranteCodenation.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteCodenation.Domain
{
    public class PratosIngredientes : IEntity
    {
        public int IdPrato { get; set; }
        public Prato Prato { get; set; }

        public int IdIngrediente { get; set; }
        public Ingredinte Ingredinte { get; set; }

        public int Id { get; set; }
    }
}
