﻿using Microsoft.EntityFrameworkCore;
using RestauranteCodenation.Domain;
using RestauranteCodenation.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestauranteCodenation.Data.Repositorio
{
    public class PratosIngredientesRepositorio : RepositorioBase<PratosIngredientes>, IPratosIngredientesRepositorio
    {
        public IEnumerable<PratosIngredientes> SelecionarCompleto()
        {
            return _contexto
                .PratosIngredientes
                .Include(x => x.Ingredinte)
                .Include(x => x.Prato)
                .Include(x => x.Prato.TipoPrato)
                .ToList();
        }
    }
}
