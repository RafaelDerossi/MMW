using AutoMapper;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;
using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;


namespace MMW.Aplicacao.Servicos
{
    public class EntradaServicoAplicacao : IEntradaServicoAplicacao
    {
        public readonly IEntradaServicoDominio _entradaServicoDominio;
        public readonly IMapper _mapper;

        public EntradaServicoAplicacao(IEntradaServicoDominio entradaServicoDominio, IMapper mapper)            
        {
            _entradaServicoDominio = entradaServicoDominio;
            _mapper = mapper;
        }

        public void Adicionar(EntradaViewModel entradaViewModel)
        {
            try
            {
                //var produto = _mapper.Map<Produto>(produtoViewModel);
                var entrada = new Entrada();
                _mapper.Map(entradaViewModel, entrada);
                _entradaServicoDominio.Adicionar(entrada);
            }
            catch (Exception e)
            {
                throw e;
            }            
        }

        public void Atualizar(EntradaViewModel entradaViewModel)
        {
            var entrada = _mapper.Map<Entrada>(entradaViewModel);
            _entradaServicoDominio.Atualizar(entrada);
        }

        public EntradaViewModel DetalharId(int id)
        {
            var entradaViewModel = _mapper.Map<EntradaViewModel>(_entradaServicoDominio.DetalharId((id)));
            return entradaViewModel;
        }

        public void Excluir(EntradaViewModel entradaViewModel)
        {
            var entrada = _mapper.Map<Entrada>(entradaViewModel);
            _entradaServicoDominio.Excluir(entrada);
        }

        public IEnumerable<EntradaViewModel> Listar()
        {
            var entrada = _entradaServicoDominio.Listar();
            EntradaViewModel entradaViewModel;
            var entradasViewModel = new List<EntradaViewModel>();
            foreach (Entrada item in entrada)
            {
                entradaViewModel = _mapper.Map<EntradaViewModel>(item);
                entradasViewModel.Add(entradaViewModel);
            }
            return entradasViewModel;
        }



        public void Dispose()
        {

        }
    }
}
