using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ploomesTest.Application.Interfaces;
using ploomesTest.Application.Services;
using ploomesTest.Domain.Interfaces.Command;
using ploomesTest.Domain.Interfaces.Repository;
using ploomesTest.Domain.Services;
using ploomesTest.Infra.Data.DbConfig;
using ploomesTest.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ploomesTest
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ploomesTest", Version = "v1" });
            });

            #region dependency injection
            services.AddSingleton<IGenreRepository, GenreRepository>();
            services.AddSingleton<IListGenreByAnimeIdDomain, ListGenreByAnimeIdDomain>();
            services.AddSingleton<IGenreApplication, GenreApplication>();
            services.AddSingleton<IListAllGenreDomain, ListAllGenreDomain>();
            services.AddSingleton<IUpdateGenreDomain, UpdateGenreDomain>();
            services.AddSingleton<IInsertGenreDomain, InsertGenreDomain>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ploomesTest v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
