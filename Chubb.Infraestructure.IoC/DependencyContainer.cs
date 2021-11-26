﻿using Chubb.Domain.Entities;
using Chubb.Domain.Interfaces;
using Chubb.Domain.Validators.ProductValidator;
using Chubb.Repository;
using Chubb.Repository.Repositories;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Chubb.Infraestructure.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IValidator<Product>, ProductValidator>();
            services.AddSingleton<ISchoolContext, SchoolContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<ICategoryRepository, CategoryRepository>();            

            return services;
        }
    }
}