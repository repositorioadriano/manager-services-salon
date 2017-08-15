using ManagerSalon.Models;
using ManagerSalon.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ManagerSalon
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSession();
            services.AddDbContext<ApplicationContext>(options => options.UseNpgsql("Host=localhost;Database=db_manager_salon;Username=postgres;Password=postgres"));
            services.AddTransient<IService<Cliente>, ServiceCliente<Cliente>>();
            services.AddTransient<IService<Servico>, ServiceServico<Servico>>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc(routes => {
                routes.MapRoute(name: "default",
                template: "{controller=Clientes}/{action=Index}/{id?}" );
            });
        }
    }
}
