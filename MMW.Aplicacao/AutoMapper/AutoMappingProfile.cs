using AutoMapper;
using MMW.Aplicacao.ViewModels;
using MMW.Dominio.Entidades;

namespace MMW.Aplicacao.AutoMapper
{
    public class AutoMappingProfile : Profile
    {        
        public AutoMappingProfile()
        {
            CreateMap<ProdutoViewModel, Produto>().ReverseMap();

            CreateMap<Loja, LojaViewModel>().ReverseMap();

            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();

            CreateMap<Estoque, EstoqueViewModel>().ReverseMap();            

            CreateMap<Entrada, EntradaViewModel>().ReverseMap();            

            CreateMap<ItemEntrada, ItemEntradaViewModel>().ReverseMap();
            
        }
    }
}
