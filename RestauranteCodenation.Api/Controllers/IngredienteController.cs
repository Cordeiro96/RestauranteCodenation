using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Data.Repositorio;
using RestauranteCodenation.Domain;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        private readonly IngredienteRepositorio _repositorio;
        public IngredienteController()
        {
            _repositorio = new IngredienteRepositorio();
        }

        // GET: api/Ingrediente
        [HttpGet]
        public IEnumerable<Ingredinte> Get()
        {
            return _repositorio.SelecionarTodos();
        }

        // GET: api/Ingrediente/5
        [HttpGet("{id}")]
        public Ingredinte Get(int id)
        {
            return _repositorio.SelecionarPorId(id);
        }

        // POST: api/Ingrediente
        [HttpPost]
        public Ingredinte Post([FromBody] Ingredinte ingredinte)
        {
            _repositorio.Incluir(ingredinte);
            return ingredinte;
        }

        // PUT: api/Ingrediente/5
        [HttpPut]
        public Ingredinte Put([FromBody] Ingredinte ingredinte)
        {
            _repositorio.Alterar(ingredinte);
            return ingredinte;
        }

        // DELETE: api/Ingrediente/5
        [HttpDelete("{id}")]
        public List<Ingredinte> Delete(int id)
        {
            _repositorio.Excluir(id);
            return _repositorio.SelecionarTodos();
        }
    }
}
