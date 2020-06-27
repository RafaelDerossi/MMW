using Autofac;
using MMW.Infra.Persistencia.Repositorio;
using MMW.Dominio.Interfaces.Servicos;
using MMW.Dominio.Interfaces.Repositorios;

namespace MMW.Infra.Transversal.IoC
{
    public class IoCConfig
    {
        public static void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<ProdutoServicoAplicacao>().As<IProdutoServicoAplicacao>();

            builder.RegisterType<ProdutoServicoDominio>().As<IProdutoServicoDominio>();

            builder.RegisterType<ProdutoRepositorio>().As<IProdutoRepositorio>();

            //builder.RegisterType<MapperAluno>().As<IMapperAluno>();
        }
    }
}
