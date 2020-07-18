using AutoMapper;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;
using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;


namespace MMW.Aplicacao.Servicos
{
    public class ItemEntradaServicoAplicacao : IItemEntradaServicoAplicacao
    {
        public readonly IItemEntradaServicoDominio _itemEntradaServicoDominio;
        public readonly IMapper _mapper;

        public ItemEntradaServicoAplicacao(IItemEntradaServicoDominio itemEntradaServicoDominio, IMapper mapper)            
        {
            _itemEntradaServicoDominio = itemEntradaServicoDominio;
            _mapper = mapper;
        }

        public void Adicionar(ItemEntradaViewModel itemEntradaViewModel)
        {
            try
            {                
                var itemEntrada = _mapper.Map<ItemEntrada>(itemEntradaViewModel);
                itemEntrada.CalculaTotalItem();
                itemEntrada.CalculaPrcCusto();
                _itemEntradaServicoDominio.Adicionar(itemEntrada);
            }
            catch (Exception e)
            {
                throw e;
            }            
        }

        public void Atualizar(ItemEntradaViewModel itemEntradaViewModel)
        {
            var itemEntrada = _mapper.Map<ItemEntrada>(itemEntradaViewModel);
            _itemEntradaServicoDominio.Atualizar(itemEntrada);
        }

        public ItemEntradaViewModel DetalharId(int id)
        {
            var itemEntradaViewModel = _mapper.Map<ItemEntradaViewModel>(_itemEntradaServicoDominio.DetalharId((id)));
            return itemEntradaViewModel;
        }

        public void Excluir(int id)
        {            
            _itemEntradaServicoDominio.Excluir(id);
        }

        public IEnumerable<ItemEntradaViewModel> Listar()
        {
            var itemEntrada = _itemEntradaServicoDominio.Listar();
            ItemEntradaViewModel itemEntradaViewModel;
            var itensEntradaViewModel = new List<ItemEntradaViewModel>();
            foreach (ItemEntrada item in itemEntrada)
            {
                itemEntradaViewModel = _mapper.Map<ItemEntradaViewModel>(item);
                itensEntradaViewModel.Add(itemEntradaViewModel);
            }
            return itensEntradaViewModel;
        }



        public void Dispose()
        {

        }
    }
}
