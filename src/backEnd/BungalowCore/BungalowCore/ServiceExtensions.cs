using Bungalow.DataLayer.Interface;
using Bungalow.DataLayer.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bungalow.Web.Host
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(
            this IServiceCollection services)
        {
            services.AddTransient<IApartmentService, ApartmentService>();
            // Add all other services here.
            return services;
        }
    }
}
