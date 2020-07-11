using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Servicos
{
   public class FornecedorServicoDominio : BaseServicoDominio<Fornecedor>, IFornecedorServicoDominio
    {
        public readonly IFornecedorRepositorio _fornecedorRepositorio;

        public FornecedorServicoDominio(IFornecedorRepositorio fornecedorRepositorio)
            : base(fornecedorRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
        }
    }
}
