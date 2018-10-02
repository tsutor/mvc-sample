using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sutor.Mvc.Sample.Contracts;
using Sutor.Mvc.Sample.Contracts.Services;
using Sutor.Mvc.Sample.Core.Models;
using Sutor.Mvc.Sample.Data;
using Sutor.Mvc.Sample.Data.Repositories;
using Sutor.Mvc.Sample.Domain.Services;
using Sutor.Mvc.Sample.Web.Mappers;
using Sutor.Mvc.Sample.Web.Models;
using System.Collections.Generic;

namespace Sutor.Mvc.Sample
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


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            /* Register injected types so we can call into them from our MVC controllers
             * If this were a legit app, rather than register each repository, we'd want to use reflection
             * to identify any classes that implement IRepository<> or IMapper<> and register them */
            
            services.AddScoped<IRepository<User>, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IMapper<User, UserViewModel>, UserViewModelMapper>();
            services.AddScoped<IMapper<ICollection<User>, UserPageViewModel>, UserPageViewModelMapper>();

            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IUserService, UserService>();
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
