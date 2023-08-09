using MediatR;
using Sistem.Application.Interfaces;
using Sistem.Application.Services;

namespace Bank_JG.Configurations
{
    public static class ApplicationConfig
    {
        /// <summary>
        /// classe para configuração de injeção de dependencia dos componentes 
        /// da camada de aplicação do sistema
        /// </summary>
        /// <param name="builder"></param>
        public static void AddApplicationConfig(WebApplicationBuilder builder)  
        { 
            builder.Services.AddTransient<IClientAppService, ClientAppServices>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
