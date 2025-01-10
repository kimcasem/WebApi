using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using WebApi.Client.Models;

namespace WebApi.Client.IoC
{
    public static class ServiceCollectionExtension
    {
        public static void AddWebApiClientService(this IServiceCollection services, Action<ApiClientOptions> options)
        {
            services.Configure(options);
            services.AddSingleton(provider =>
            {
                var options = provider.GetRequiredService<IOptions<ApiClientOptions>>().Value;
                return new WebApiClientService(options);
            });
        }
    }
}
