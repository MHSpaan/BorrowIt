using BorrowIt.Controllers;
using BorrowIt.Data;
using BorrowIt.Data.Repositories;
using BusinessLogic.Services;
using BusinessLogic.Validators;
using Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BorrowIt
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<ApplicationDbContext>(options =>
                 options.UseSqlServer(
                     Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<ApplicationDbContext>(options =>
                 options.UseSqlServer(
                     Configuration.GetConnectionString("TestConnection")));

            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            
            services.AddScoped<IRepository<Order>, OrderRepository>();
            services.AddScoped<IRepository<Car>, CarRepository>();
            services.AddScoped<IRepository<Branch>, BranchRepository>();
            services.AddScoped<IRepository<User>, UserRepository>();

            services.AddScoped<IValidator<Order>, OrderValidator>();
            services.AddScoped<IValidator<Car>, CarValidator>();
            services.AddScoped<IValidator<Branch>, BranchValidator>();
            services.AddScoped<IValidator<User>, UserValidator>();

            services.AddScoped<IServices<Order>, OrderServices>();
            services.AddScoped<IServices<Car>, CarServices>();
            services.AddScoped<IServices<Branch>, BranchServices>();
            services.AddScoped<IServices<User>, UserServices>();

            services.AddScoped<IController<Order>, OrdersController>();
            services.AddScoped<IController<Car>, CarsController>();
            services.AddScoped<IController<Branch>, BranchesController>();
            services.AddScoped<IController<User>, UsersController>();
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        
    }
}
