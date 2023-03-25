using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ploomesTest.Application.Interfaces;
using ploomesTest.Application.Services;
using ploomesTest.Domain.Interfaces.Command;
using ploomesTest.Domain.Interfaces.Command.Anime;
using ploomesTest.Domain.Interfaces.Command.Episode;
using ploomesTest.Domain.Interfaces.Command.Season;
using ploomesTest.Domain.Interfaces.Command.Studio;
using ploomesTest.Domain.Interfaces.Repository;
using ploomesTest.Domain.Interfaces.Repository.Anime;
using ploomesTest.Domain.Interfaces.Repository.Episode;
using ploomesTest.Domain.Interfaces.Repository.Season;
using ploomesTest.Domain.Interfaces.Repository.Studio;
using ploomesTest.Domain.Services;
using ploomesTest.Domain.Services.Anime;
using ploomesTest.Domain.Services.Episode;
using ploomesTest.Domain.Services.Season;
using ploomesTest.Domain.Services.Studio;
using ploomesTest.Infra.Data.Repository;
using ploomesTest.Infra.Data.Repository.Episode;
using ploomesTest.Infra.Data.Repository.Season;
using ploomesTest.Infra.Data.Repository.Studio;

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
            services.AddSingleton<IAnimeRepository, AnimeRepository>();
            services.AddSingleton<IListAllAnimesDomain, ListAllAnimesDomain>();
            services.AddSingleton<IAnimeApplication, AnimeApplication>();
            services.AddSingleton<IListAllAnimesByIdDomain, ListAllAnimesByIdDomain>();
            services.AddSingleton<IInsertAnimeDomain, InsertAnimeDomain>();
            services.AddSingleton<IUpdateAnimeDomain, UpdateAnimeDomain>();
            services.AddSingleton<IEpisodeRepository, EpisodeRepository>();
            services.AddSingleton<IListEpisodeByAnimeIdDomain, ListEpisodeByAnimeIdDomain>();
            services.AddSingleton<IEpisodeApplication, EpisodeApplication>();
            services.AddSingleton<IInsertEpisodeDomain, InsertEpisodeDomain>();
            services.AddSingleton<IUpdateEpisodeDomain, UpdateEpisodeDomain>();
            services.AddSingleton<IStudioRepository, StudioRepository>();
            services.AddSingleton<IListAllStudioDomain, ListAllStudioDomain>();
            services.AddSingleton<IStudioApplication, StudioApplication>();
            services.AddSingleton<IInsertStudioDomain, InsertStudioDomain>();
            services.AddSingleton<IUpdateStudioDomain, UpdateStudioDomain>();
            services.AddSingleton<ISeasonRepository, SeasonRepository>();
            services.AddSingleton<IListSeasonByAnimeIdDomain, ListSeasonByAnimeIdDomain>();
            services.AddSingleton<ISeasonApplication, SeasonApplication>();
            services.AddSingleton<IInsertSeasonDomain, InsertSeasonDomain>();
            services.AddSingleton<IUpdateSeasonDomain, UpdateSeasonDomain>();
            services.AddSingleton<IListAllSeasonDomain, ListAllSeasonDomain>();
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
