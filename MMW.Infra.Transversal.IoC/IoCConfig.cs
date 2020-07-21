using Autofac;
using MMW.Infra.Persistencia.Repositorio;
using MMW.Dominio.Interfaces.Servicos;
using MMW.Dominio.Interfaces.Repositorios;
using MMW.Dominio.Servicos;
using MMW.Aplicacao.Servicos;
using MMW.Aplicacao.Interfaces;
using AutoMapper;

namespace MMW.Infra.Transversal.IoC
{
    public class IoCConfig
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProdutoServicoAplicacao>().As<IProdutoServicoAplicacao>();

            builder.RegisterType<ProdutoServicoDominio>().As<IProdutoServicoDominio>();

            builder.RegisterType<ProdutoRepositorio>().As<IProdutoRepositorio>();


            builder.RegisterType<LojaServicoAplicacao>().As<ILojaServicoAplicacao>();

            builder.RegisterType<LojaServicoDominio>().As<ILojaServicoDominio>();

            builder.RegisterType<LojaRepositorio>().As<ILojaRepositorio>();


            builder.RegisterType<FornecedorServicoAplicacao>().As<IFornecedorServicoAplicacao>();

            builder.RegisterType<FornecedorServicoDominio>().As<IFornecedorServicoDominio>();

            builder.RegisterType<FornecedorRepositorio>().As<IFornecedorRepositorio>();


            builder.RegisterType<EntradaServicoAplicacao>().As<IEntradaServicoAplicacao>();

            builder.RegisterType<EntradaServicoDominio>().As<IEntradaServicoDominio>();

            builder.RegisterType<EntradaRepositorio>().As<IEntradaRepositorio>();


            builder.RegisterType<ItemEntradaServicoAplicacao>().As<IItemEntradaServicoAplicacao>();

            builder.RegisterType<ItemEntradaServicoDominio>().As<IItemEntradaServicoDominio>();

            builder.RegisterType<ItemEntradaRepositorio>().As<IItemEntradaRepositorio>();


            builder.RegisterType<EstoqueServicoAplicacao>().As<IEstoqueServicoAplicacao>();

            builder.RegisterType<EstoqueServicoDominio>().As<IEstoqueServicoDominio>();

            builder.RegisterType<EstoqueRepositorio>().As<IEstoqueRepositorio>();

        }
    }
}
