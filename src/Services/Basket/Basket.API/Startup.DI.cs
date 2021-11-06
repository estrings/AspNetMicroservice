using Basket.API.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Basket.API
{
    public partial class Startup
    {
        public IServiceCollection ConfigureDIServices(IServiceCollection services)
        {
            services.AddScoped<IBasketRepository, BasketRepository>();
            return services;
        }
    }
}
