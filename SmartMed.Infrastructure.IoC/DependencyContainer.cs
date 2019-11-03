using Microsoft.Extensions.DependencyInjection;
using SmartMed.Application.Interfaces;
using SmartMed.Application.Services;
using SmartMed.Domain.Interfaces;
using SmartMed.Infrastructure.Data.Context;
using SmartMed.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMed.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //Application layer
            services.AddScoped<IMedicationService, MedicationService>();

            //Infra.Data layer
            services.AddScoped<IMedicationRepository, MedicationRepository>();



            services.AddScoped<MedicationContext>();
        }
    }
}
