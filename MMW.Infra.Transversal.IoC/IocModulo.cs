using Autofac;

namespace MMW.Infra.Transversal.IoC
{
    public class IoCModulo : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            IoCConfig.Load(builder);
        }
    }
}
