using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Servicos
{
   public class EntradaServicoDominio : BaseServicoDominio<Entrada>, IEntradaServicoDominio
    {
        public readonly IEntradaRepositorio _entradaRepositorio;

        public EntradaServicoDominio(IEntradaRepositorio entradaRepositorio)
            : base(entradaRepositorio)
        {
            _entradaRepositorio = entradaRepositorio;
        }
    }
}
