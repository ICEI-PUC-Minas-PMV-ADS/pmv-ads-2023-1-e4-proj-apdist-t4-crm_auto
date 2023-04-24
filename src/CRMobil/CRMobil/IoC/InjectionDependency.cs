using CRMobil.Entities;
using CRMobil.Interfaces;
using CRMobil.Services;
using MongoDB.Driver.Core.Configuration;

namespace CRMobil.IoC
{
    public static class InjectionDependency
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IUsuariosService, UsuariosService>();
            services.AddSingleton<IServicosOficinaServices, ServicosOficinaServices>();
            services.AddSingleton<IOficinasServices, OficinasServices>();
            services.AddSingleton<IClientesServices, ClientesService>();
            services.AddSingleton<IFuncionariosServices, FuncionariosServices>();
            services.AddSingleton<IVeiculosServices, VeiculosServices>();
            services.AddSingleton<IOrdemServicoServices, OrdemServicoServices>();
            
            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConnectionString>(configuration.GetSection("ConnectionStrings"));
            services.Configure<CnnStoreDatabaseSettings>(configuration.GetSection("ConnStoreDatabase"));

            return services;
        }
    }
}
