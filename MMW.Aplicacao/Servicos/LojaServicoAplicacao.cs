using AutoMapper;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;
using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;


namespace MMW.Aplicacao.Servicos
{
    public class LojaServicoAplicacao : ILojaServicoAplicacao
    {
        public readonly ILojaServicoDominio _lojaServicoDominio;
        public readonly IMapper _mapper;

        public LojaServicoAplicacao(ILojaServicoDominio lojaServicoDominio, IMapper mapper)            
        {
            _lojaServicoDominio = lojaServicoDominio;
            _mapper = mapper;
        }

        public void Adicionar(LojaViewModel lojaViewModel)
        {
            try
            {
                //var produto = _mapper.Map<Produto>(produtoViewModel);
                Loja loja = new Loja();
                _mapper.Map(lojaViewModel, loja);
                _lojaServicoDominio.Adicionar(loja);
            }
            catch (Exception e)
            {
                throw e;
            }            
        }

        public void Atualizar(LojaViewModel lojaViewModel)
        {
            var loja = _mapper.Map<Loja>(lojaViewModel);
            _lojaServicoDominio.Atualizar(loja);
        }

        public LojaViewModel DetalharId(int id)
        {
            var lojaViewModel = _mapper.Map<LojaViewModel>(_lojaServicoDominio.DetalharId((id)));
            return lojaViewModel;
        }

        public void Excluir(int id)
        {           
            _lojaServicoDominio.Excluir(id);
        }

        public IEnumerable<LojaViewModel> Listar()
        {
            var loja = _lojaServicoDominio.Listar();
            LojaViewModel lojaViewModel;
            var lojasViewModel = new List<LojaViewModel>();
            foreach (Loja item in loja)
            {
                lojaViewModel = _mapper.Map<LojaViewModel>(item);
                lojasViewModel.Add(lojaViewModel);
            }
            return lojasViewModel;
        }



        public void Dispose()
        {

        }
    }
}
