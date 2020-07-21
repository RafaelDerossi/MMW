using AutoMapper;
using MMW.Aplicacao.Interfaces;
using MMW.Aplicacao.ViewModels;
using MMW.Dominio.Entidades;
using MMW.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;


namespace MMW.Aplicacao.Servicos
{
    public class EstoqueServicoAplicacao : IEstoqueServicoAplicacao
    {
        public readonly IEstoqueServicoDominio _estoqueServicoDominio;
        public readonly IMapper _mapper;

        public EstoqueServicoAplicacao(IEstoqueServicoDominio estoqueServicoDominio, IMapper mapper)            
        {
            _estoqueServicoDominio = estoqueServicoDominio;
            _mapper = mapper;
        }
      
        public void Atualizar(EstoqueViewModel estoqueViewModel)
        {
            var estoque = _mapper.Map<Estoque>(estoqueViewModel);
            _estoqueServicoDominio.Atualizar(estoque);
        }

        public EstoqueViewModel DetalharId(int id)
        {
            var estoqueViewModel = _mapper.Map<EstoqueViewModel>(_estoqueServicoDominio.DetalharId((id)));
            return estoqueViewModel;
        }
                
        public IEnumerable<EstoqueViewModel> Listar()
        {
            var estoques = _estoqueServicoDominio.Listar();
            EstoqueViewModel estoqueViewModel;
            var estoquesViewModel = new List<EstoqueViewModel>();
            foreach (Estoque item in estoques)
            {
                estoqueViewModel = _mapper.Map<EstoqueViewModel>(item);
                estoquesViewModel.Add(estoqueViewModel);
            }
            return estoquesViewModel;
        }

        public IEnumerable<EstoqueViewModel> Listar(int produtoId)
        {
            var estoques = _estoqueServicoDominio.Listar();
            EstoqueViewModel estoqueViewModel;
            var estoquesViewModel = new List<EstoqueViewModel>();
            foreach (Estoque item in estoques)
            {
                estoqueViewModel = _mapper.Map<EstoqueViewModel>(item);
                estoquesViewModel.Add(estoqueViewModel);
            }
            return estoquesViewModel;
        }


        public void Dispose()
        {

        }
    }
}
