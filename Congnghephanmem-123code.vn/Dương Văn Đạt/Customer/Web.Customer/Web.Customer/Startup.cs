using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Web.Customer.Data;
using Web.Customer.Services;
using Web.Customer.Stores;

namespace Web.Customer
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
            var connectionString = "Data Source=DESKTOP-J0S9OLN;Initial Catalog=CNPM_QLNGK;Integrated Security=True";
            services.AddDbContext<WebDbContext>(options => options.UseSqlServer(connectionString));
          //  services.AddScoped<ITableStore, TableStore>();

            services.AddScoped<ITableStore, TableSqlServerStore>();
            services.AddScoped<ITableManager, DefaultTableManager>();
            services.AddScoped<IFoodStore, FoodSqlServerStore>();
            services.AddScoped<IFoodManager, DefaultFoodManager>();
            services.AddScoped<IFoodCategoryManager, DefaultFoodCategoryManager>();
            services.AddScoped<IFoodCategoryStore, FoodCategorySqlServerStore>();
            services.AddScoped<IDrinkStore, DrinkSqlServerStore>();
            services.AddScoped<IDrinkManager, DefaultDrinkManager>();
            services.AddScoped<IDrinkCategoryStore, DrinkCategorySqlServerStore>();
            services.AddScoped<IDrinkCategoryManager, DefaultDrinkCategoryManager>();
            services.AddScoped<IBookedTableStore, BookedTableSqlServerStore>();
            services.AddScoped<IBookedTableManager, DefaultBookedTableManager>();




            services.AddMvc(options =>
            {
                options.MaxModelValidationErrors = 50;
                options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(
                    (_) => "The field is required.");
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
