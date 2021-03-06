﻿using RestauranteCodenation.Domain;
using RestauranteCodenation.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestauranteCodenation.Data.Repositorio
{
    //Determinando que para entrar no repositório base, tem que ser uma classe e implementar a classe IEntity

    //public class RepositorioBase<T> where T : class, IEntity -> Declaração da classe sem injeção de dependência

    //declaração da classe com injeção de dependência
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class, IEntity
    {
        protected readonly Contexto _contexto;
        public RepositorioBase()
        {
            _contexto = new Contexto();
        }

        public void Incluir(T entity)
        {
            _contexto.Set<T>().Add(entity);
            _contexto.SaveChanges();
        }

        public void Alterar(T entity)
        {
            _contexto.Set<T>().Update(entity);
            _contexto.SaveChanges();
        }

        public T SelecionarPorId(int id)
        {
            return _contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> SelecionarTodos()
        {
            return _contexto.Set<T>().ToList();
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            _contexto.Set<T>().Remove(entity);
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
