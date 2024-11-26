using BlazorWasm.Data.Services;
using BlazorWasm.Data.WrapperRepository;
using BlazorWasm.Data.WrapperRepository.Contracts;
using BlazorWasm.Entities.Contaters.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWasm.Data.Configurations;

public static class DependencyInjection
{

    public static IServiceCollection AddDataLayer(this IServiceCollection services, string domain)
    {

        #region Add Services 
        services.AddTransient<IContactersService, ContactersService>();

        #endregion
        services.AddHttpClient<IHttpClientWrapper, HttpClientWrapper>(client =>
        {
            client.BaseAddress = new Uri(domain);
            client.Timeout = TimeSpan.FromSeconds(30);
        });

        return services;
    }

}
