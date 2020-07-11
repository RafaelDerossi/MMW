using AutoMapper;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;
using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;


namespace MMW.Aplicacao.Servicos
{
    public class ProdutoServicoAplicacao : IProdutoServicoAplicacao
    {
        public readonly IProdutoServicoDominio _produtoServicoDominio;
        public readonly IMapper _mapper;

        public ProdutoServicoAplicacao(IProdutoServicoDominio produtoServicoDominio, IMapper mapper)            
        {
            _produtoServicoDominio = produtoServicoDominio;
            _mapper = mapper;
        }

        public void Adicionar(ProdutoViewModel produtoViewModel)
        {
            try
            {
                //var produto = _mapper.Map<Produto>(produtoViewModel);
                Produto produto = new Produto();
                _mapper.Map(produtoViewModel, produto);
                _produtoServicoDominio.Adicionar(produto);
            }
            catch (Exception e)
            {
                throw e;
            }            
        }

        public void Atualizar(ProdutoViewModel produtoViewModel)
        {
            var produto = _mapper.Map<Produto>(produtoViewModel);
            _produtoServicoDominio.Atualizar(produto);
        }

        public ProdutoViewModel DetalharId(int id)
        {
            var produtoViewModel = _mapper.Map<ProdutoViewModel>(_produtoServicoDominio.DetalharId((id)));
            return produtoViewModel;
        }

        public void Excluir(int id)
        {            
            _produtoServicoDominio.Excluir(id);
        }

        public IEnumerable<ProdutoViewModel> Listar()
        {
            var produtos = _produtoServicoDominio.Listar();
            ProdutoViewModel produtoViewModel;
            var produtosViewModel = new List<ProdutoViewModel>();
            foreach (Produto item in produtos)
            {
                produtoViewModel = _mapper.Map<ProdutoViewModel>(item);
                produtosViewModel.Add(produtoViewModel);
            }
            return produtosViewModel;
        }



        public void Dispose()
        {

        }
    }
}
