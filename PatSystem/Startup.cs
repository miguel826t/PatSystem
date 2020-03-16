using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PatSystem.Data;
using PatSystem.Services;

namespace PatSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Config dos Servicos
        public void ConfigureServices(IServiceCollection services)
        {

            #region DbContex
            services.AddDbContext<PatSystemContext>(options =>
                   options.UseMySql(Configuration.GetConnectionString("DBempregoContext"), builder => builder.MigrationsAssembly("PatSystem")));
            #endregion

            #region Services
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddMvc(options => {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });
            services.AddScoped<ClienteService>();
            services.AddScoped<CursoSuperiorService>();
            services.AddScoped<CursoTecnicoService>();
            services.AddScoped<ExperienciaService>();
            services.AddScoped<IdiomaService>();
            services.AddScoped<CurriculoService>();
            #endregion
        }

        // Config Uses Apps
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            #region ConfigBR
            var ptBr = new CultureInfo("pt-BR");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ptBr),
                SupportedCultures = new List<CultureInfo> { ptBr },
                SupportedUICultures = new List<CultureInfo> { ptBr }
            };
            app.UseRequestLocalization(localizationOptions);
            #endregion

            #region ConfigDeveloper
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            #endregion

            #region AppUse
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            #endregion
        }
    }
}
