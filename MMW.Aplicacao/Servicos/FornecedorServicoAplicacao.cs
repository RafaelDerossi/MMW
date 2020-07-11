using AutoMapper;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;
using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;


namespace MMW.Aplicacao.Servicos
{
    public class FornecedorServicoAplicacao : IFornecedorServicoAplicacao
    {
        public readonly IFornecedorServicoDominio _fornecedorServicoDominio;
        public readonly IMapper _mapper;

        public FornecedorServicoAplicacao(IFornecedorServicoDominio fornecedorServicoDominio, IMapper mapper)            
        {
            _fornecedorServicoDominio = fornecedorServicoDominio;
            _mapper = mapper;
        }

        public void Adicionar(FornecedorViewModel FornecedorViewModel)
        {
            try
            {
                //var produto = _mapper.Map<Produto>(produtoViewModel);
                Fornecedor fornecedor = new Fornecedor();
                _mapper.Map(FornecedorViewModel, fornecedor);
                _fornecedorServicoDominio.Adicionar(fornecedor);
            }
            catch (Exception e)
            {
                throw e;
            }            
        }

        public void Atualizar(FornecedorViewModel FornecedorViewModel)
        {
            var fornecedor = _mapper.Map<Fornecedor>(FornecedorViewModel);
            _fornecedorServicoDominio.Atualizar(fornecedor);
        }

        public FornecedorViewModel DetalharId(int id)
        {
            var fornecedorViewModel = _mapper.Map<FornecedorViewModel>(_fornecedorServicoDominio.DetalharId((id)));
            return fornecedorViewModel;
        }

        public void Excluir(int id)
        {            
            _fornecedorServicoDominio.Excluir(id);
        }

        public IEnumerable<FornecedorViewModel> Listar()
        {
            var fornecedor = _fornecedorServicoDominio.Listar();
            FornecedorViewModel fornecedorViewModel;
            var fornecedoresViewModel = new List<FornecedorViewModel>();
            foreach (Fornecedor item in fornecedor)
            {
                fornecedorViewModel = _mapper.Map<FornecedorViewModel>(item);
                fornecedoresViewModel.Add(fornecedorViewModel);
            }
            return fornecedoresViewModel;
        }



        public void Dispose()
        {

        }
    }
}
