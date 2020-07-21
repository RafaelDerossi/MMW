using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Servicos
{
   public class EstoqueServicoDominio : BaseServicoDominio<Estoque>, IEstoqueServicoDominio
    {
        public readonly IEstoqueRepositorio _estoqueRepositorio;

        public EstoqueServicoDominio(IEstoqueRepositorio estoqueRepositorio)
            : base(estoqueRepositorio)
        {
            _estoqueRepositorio = estoqueRepositorio;
        }
    }
}
