using System;
using AutoMapper;
using MMW.Aplicacao.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace MMW.MVC.Configuracoes
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
            services.AddAutoMapper(typeof(AutoMappingProfile));
        }
    }
}
