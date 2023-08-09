using Sistem.Domain.Impl.Interfaces;
using Sistem.Domain.Impl.Services;

namespace Bank_JG.Configurations
{
    public class DomainConfg
    {

        /// <summary>
        /// classe para configuração de injeção de dependencia dos componentes 
        /// da camada de aplicação do sistema
        /// </summary>
        /// <param name="builder"></param>
        public static void AddDomainConfig(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IClientDomainService, ClientDomainService>();

        }

    }
}
