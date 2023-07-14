using ExamplesDotNetCore.Interfaces;
using ExamplesDotNetCore.Repositories;
using ExamplesDotNetCore.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesDotNetCore.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IPerson, PersonRepository>();
            services.AddScoped<PersonServices>();            
            return services;
        }
    }
}
