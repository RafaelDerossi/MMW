using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Servicos
{
   public class LojaServicoDominio : BaseServicoDominio<Loja>, ILojaServicoDominio
    {
        public readonly ILojaRepositorio _lojaRepositorio;

        public LojaServicoDominio(ILojaRepositorio lojaRepositorio)
            : base(lojaRepositorio)
        {
            _lojaRepositorio = lojaRepositorio;
        }
    }
}
