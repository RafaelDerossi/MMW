using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Interfaces.Servicos
{
    public interface IBaseServicoDominio<T> where T : class
    {
        T Adicionar(T obj);

        T DetalharId(int id);

        IEnumerable<T> Listar();

        void Atualizar(T obj);

        void Excluir(int id);

        void Dispose();
    }
}
