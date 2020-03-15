using Aplicacao;
using Dominio.Interface;
using Dominio.Interface.Aplicacao;
using Dominio.Interface.Infra;
using Infra.Comum;
using Infra.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace Characters
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

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });

            services.AddMvc().AddNewtonsoftJson();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(
                    "v1",
                    new OpenApiInfo
                    {
                        Title = "Marvel",
                        Version = "v1",
                        Description = "APIs - Marvel",
                        Contact = new OpenApiContact
                        {
                            Name = "Welington",
                            Url = new Uri("https://github.com/welingtonfx")
                        }
                    });
            });

            services.AddSwaggerGenNewtonsoftSupport();

            services.AddSingleton<IConfiguration>(Configuration);
            services.AddScoped<IRepositorioMarvelAPI, RepositorioMarvelAPI>();
            services.AddScoped<IServicoAplicacaoMarvelAPI, ServicoAplicacaoMarvelAPI>();
            services.AddScoped<IRepositorioMarvelDB, RepositorioMarvelDB>();
            services.AddScoped<IServicoAplicacaoMarvelDB, ServicoAplicacaoMarvelDB>();
            services.AddScoped<IMarvelHasher, MarvelHasher>();
            services.AddScoped<IMarvelAPIConnector, MarvelAPIConnector>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("AllowAllOrigins");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c => 
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "apis");
            });
        }
    }
}
