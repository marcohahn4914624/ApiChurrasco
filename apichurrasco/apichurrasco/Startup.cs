using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apichurrasco.Models;
using apichurrasco.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace apichurrasco
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
            services.AddDbContext<FuncionarioDbContext>(Options =>
            Options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<ConvidadoDbContext>(Options =>
            Options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<GastoDbContext>(Options =>
            Options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddTransient<IFuncionarioRepositorio, FuncionarioRepositario>();
            services.AddTransient<IConvidadoRepositorio, ConvidadoRepositario>();
            services.AddTransient<IGastoRepositorio, GastoRepositorio>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

           // app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
