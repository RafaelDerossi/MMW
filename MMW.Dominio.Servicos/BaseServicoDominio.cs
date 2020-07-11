using MMW.Dominio.Interfaces.Repositorios;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace MMW.Dominio.Servicos
{
    public abstract class BaseServicoDominio<T> : IDisposable, IBaseServicoDominio<T> where T : class
    {
        private readonly IBaseRepositorio<T> _repositorio;

        public BaseServicoDominio(IBaseRepositorio<T> repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(T obj)
        {
            _repositorio.Adicionar(obj);
        }

        public void Atualizar(T obj)
        {
            _repositorio.Atualizar(obj);
        }

        public T DetalharId(int id)
        {
            return _repositorio.DetalharId(id);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public void Excluir(int id)
        {
            _repositorio.Excluir(id);
        }

        public IEnumerable<T> Listar()
        {
            return _repositorio.Listar();
        }
    }
}
