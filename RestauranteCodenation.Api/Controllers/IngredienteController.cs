using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Data.Repositorio;
using RestauranteCodenation.Domain;
using RestauranteCodenation.Domain.Repositorio;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        private readonly IIngredienteRepositorio _repositorio;
        public IngredienteController(IIngredienteRepositorio repo)
        {
            _repositorio = repo;
        }

        // GET: api/Ingrediente
        [HttpGet]
        public IEnumerable<Ingrediente> Get()
        {
            return _repositorio.SelecionarTodos();
        }

        // GET: api/Ingrediente/5
        [HttpGet("{id}")]
        public Ingrediente Get(int id)
        {
            return _repositorio.SelecionarPorId(id);
        }

        // POST: api/Ingrediente
        [HttpPost]
        public Ingrediente Post([FromBody] Ingrediente ingredinte)
        {
            _repositorio.Incluir(ingredinte);
            return ingredinte;
        }

        // PUT: api/Ingrediente/5
        [HttpPut]
        public Ingrediente Put([FromBody] Ingrediente ingredinte)
        {
            _repositorio.Alterar(ingredinte);
            return ingredinte;
        }

        // DELETE: api/Ingrediente/5
        [HttpDelete("{id}")]
        public List<Ingrediente> Delete(int id)
        {
            _repositorio.Excluir(id);
            return _repositorio.SelecionarTodos();
        }
    }
}
