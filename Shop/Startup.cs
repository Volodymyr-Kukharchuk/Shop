using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shop.Data;
using Shop.Data.Interfaces;
using Shop.Data.Mocks;
using Shop.Data.Repository;

namespace Shop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // receive conString from config
            var connection = Configuration.GetConnectionString("DefaultConnection");
            // add context AppContextDataBase such as service
            services.AddDbContext<AppContextDataBase>(options =>
                options.UseSqlServer(connection));

            services.AddControllersWithViews();
            services.AddTransient<IAllCars, CarRepository>();
            services.AddTransient<ICarsCategory, CategoryRepository>();
            services.AddMvc(mvcOptions =>
            {
                mvcOptions.EnableEndpointRouting = false;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            // 
            //}

            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseMvcWithDefaultRoute();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
            
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppContextDataBase context = scope.ServiceProvider.GetRequiredService<AppContextDataBase>();
                DBObjects.Initial(context);
            }
            //
        }
    }
}
