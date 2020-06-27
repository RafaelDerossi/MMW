using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Servicos
{
   public class ProdutoServicoDominio : BaseServicoDominio<Produto>, IProdutoServicoDominio
    {
        public readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServicoDominio(IProdutoRepositorio produtoRepositorio)
            : base(produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
    }
}
