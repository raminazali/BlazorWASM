using System;
using BlazorWasm.Entities.Contaters.Contracts;
using BlazorWasm.Entities.Contaters.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWasm.Data.Configurations;

public static class DependencyInjection
{

    public static IServiceCollection AddDataLayer(this IServiceCollection services)
    {

        #region Add Services 
        services.AddSingleton<IContactersService, ContactersService>();
        #endregion


        return services;
    }

}
