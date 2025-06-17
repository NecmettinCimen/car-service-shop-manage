using CarServiceShopManage.Database;
using CarServiceShopManage.Services.Interfaces;
using CarServiceShopManage.Services.Repositories;
using CarServiceShopManage.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CarServiceShopManage.Web
{
    public class Startup(IConfiguration configuration, IWebHostEnvironment env)
    {
        public IWebHostEnvironment Env { get; set; } = env;

        public IConfiguration Configuration { get; } = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AracYonetimContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("AracYonetimDbConnString"), b => b.MigrationsAssembly("CarServiceShopManage.Database")));

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

            services.AddScoped<IAracOrtakRepository, AracOrtakRepository>();
            services.AddScoped<IAracOrtakService, AracOrtakService>();

            services.AddScoped<IAracHasarRepository, AracHasarRepository>();
            services.AddScoped<IAracHasarService, AracHasarService>();

            services.AddScoped<IAracGiderRepository, AracGiderRepository>();
            services.AddScoped<IAracGiderService, AracGiderService>();

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
