using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using stcore.business;
using stcore.model;
using stcore.repository;
using stcore.repository.Base;
using stcore.repository.Database;

namespace stcore.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDatabase(@"filename=stcore.db;mode=shared");

            services.AddOpenApiDocument();

            services.AddTransient<BaseRepository<IngredientModel>>();
            services.AddTransient<IngredientService>();
            services.AddTransient<IngredientRepository>();

            services.AddTransient<BaseRepository<EquipmentModel>>();
            services.AddTransient<EquipmentService>();
            // services.AddTransient<EquipmentRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseOpenApi(); // serve OpenAPI/Swagger documents
            app.UseSwaggerUi3(); // serve Swagger UI
	        app.UseReDoc( (settings) => {
                settings.Path = "/redoc";
            }); // serve ReDoc UI
        }
    }
}
