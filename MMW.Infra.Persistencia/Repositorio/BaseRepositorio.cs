using Microsoft.EntityFrameworkCore;
using MMW.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MMW.Infra.Persistencia.Repositorio
{
    public abstract class BaseRepositorio<T> : IDisposable, IBaseRepositorio<T> where T : class
    {
        private readonly MMWDbContext _contexto;

        public BaseRepositorio(MMWDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(T obj)
        {
            try
            {
                _contexto.Set<T>().Add(obj);
                _contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Atualizar(T obj)
        {
            try
            {
                _contexto.Entry(obj).State = EntityState.Modified;
                _contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public T DetalharId(int id)
        {
            return _contexto.Set<T>().Find(id);
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public void Excluir(int id)
        {
            try
            {
                _contexto.Set<T>().Remove(_contexto.Set<T>().Find(id));
                _contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<T> Listar()
        {
            return _contexto.Set<T>().ToList();
        }
    }
}
