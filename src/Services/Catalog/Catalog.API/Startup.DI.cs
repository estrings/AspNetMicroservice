using Catalog.API.DataAccess;
using Catalog.API.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.API
{
    public partial class Startup
    {
        public IServiceCollection ConfigureDIServices(IServiceCollection services)
        {
            services.AddScoped<ICatalogContext, CatalogContext>();
            services.AddScoped<IProductRepository, ProductRepository>();            
            return services;
        }
    }
}
