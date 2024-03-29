﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlugaSe.DomainModel.Interfaces.Repositories;
using AlugaSe.DomainService;
using AlugaSe.DomainService.Interfaces;
using AlugaSe.DomainService.Services;
using AlugaSe.Infrastructure.DataAccess.Contexts;
using AlugaSe.Infrastructure.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AlugaSe.WebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped<IVendorRepository, VendorEntityFrameworkRepository>();
            services.AddScoped<IVendorService, VendorService>();

            services.AddScoped<ICustomerRepository, CustomerEntityFrameworkRepository>();
            services.AddScoped<ICustomerService, CustomerService>();

            services.AddScoped<IRentRepository, RentEntityFrameworkRepository>();
            services.AddScoped<IRentService, RentService>();

            services.AddScoped<IProductRepository, ProductEntityFrameworkRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IRentItemRepository, RentItemEntityFrameworkRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
