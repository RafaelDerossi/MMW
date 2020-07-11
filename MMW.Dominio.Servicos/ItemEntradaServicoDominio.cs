using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Repositorios;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMW.Dominio.Servicos
{
   public class ItemEntradaServicoDominio : BaseServicoDominio<ItemEntrada>, IItemEntradaServicoDominio
    {
        public readonly IItemEntradaRepositorio _itemEntradaRepositorio;

        public ItemEntradaServicoDominio(IItemEntradaRepositorio itemEntradaRepositorio)
            : base(itemEntradaRepositorio)
        {
            _itemEntradaRepositorio = itemEntradaRepositorio;
        }
    }
}
