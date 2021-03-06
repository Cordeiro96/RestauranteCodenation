﻿using System;
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
    public class CardapioController : ControllerBase
    {
        private readonly ICardapioRepositorio _repo;

        public CardapioController(ICardapioRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Cardapio> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET: api/Cardapio/5
        [HttpGet("{id}")]
        public Cardapio Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST: api/Cardapio
        [HttpPost]
        public Cardapio Post([FromBody] Cardapio cardapio)
        {
            _repo.Incluir(cardapio);
            return cardapio;
        }

        // PUT: api/Cardapio/5
        [HttpPut("{id}")]
        public Cardapio Put([FromBody] Cardapio cardapio)
        {
            _repo.Alterar(cardapio);
            return cardapio;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<Cardapio> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
