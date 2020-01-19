using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aracyonetim.database;
using aracyonetim.entities.Tables;
using aracyonetim.services.Interfaces;
using aracyonetim.services.Repositories;
using aracyonetim.services.Services;
using aracyonetim.web.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace aracyonetim.web
{
    public class Startup
    {
        public IWebHostEnvironment Env { get; set; }
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Env = env;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AracYonetimContext>(options =>
                options.UseSqlServer(Configuration.GetSection("AracYonetimDbConnString").Value));

            var builder = services.AddRazorPages();

#if DEBUG
            if (Env.IsDevelopment())
            {
                builder.AddRazorRuntimeCompilation();
            }
#endif

            services.AddDistributedMemoryCache();

            services.AddSession();
            
            services.AddControllersWithViews();

            services.AddScoped<IKullaniciRepository, KullaniciRepository>();
            services.AddScoped<IKullaniciService, KullaniciService>();
            
            services.AddScoped<IAracRepository, AracRepository>();
            services.AddScoped<IAracService, AracService>();
            
            services.AddScoped<ILookupListRepository, LookupListRepository>();
            services.AddScoped<ILookupListService, LookupListService>();
            
            services.AddScoped<IMusteriRepository, MusteriRepository>();
            services.AddScoped<IMusteriService, MusteriService>();
            
            services.AddScoped<IBakimTalebiRepository, BakimTalebiRepository>();
            services.AddScoped<IBakimTalebiService, BakimTalebiService>();

            services.AddScoped<IMailService, MailService>();
            
            services.AddScoped<IFirmaRepository, FirmaRepository>();
            services.AddScoped<IFirmaService, FirmaService>();

            services.AddScoped<IChartDtoRepository, ChartDtoRepository>();
            
            services.AddScoped<IRaporService, RaporService>();
            
            services.AddScoped<IRolRepository, RolRepository>();
            services.AddScoped<IRolService, RolService>();
            
            services.AddScoped<IRolMenuRepository, RolMenuRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
