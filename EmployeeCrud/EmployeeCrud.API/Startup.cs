using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeCrud.API.Attributes;
using EmployeeCrud.Core.AppInterfaces;
using EmployeeCrud.Core.AppServices;
using EmployeeCrud.Core.DataInterfaces;
using EmployeeCrud.Data.EF;
using EmployeeCrud.Data.EF.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace EmployeeCrud.API
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
            services.AddMvc(options =>
            {
                options.Filters.Add(new ExceptionHandlerFilterAttribute());
            });
            //.SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors();
            InjectDependencies(services);

            services.AddDbContext<EmployeeCrudDBContext>(options =>
            options.UseSqlServer(this.Configuration.GetConnectionString("LocalDB"))
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder =>
            builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
            app.UseMvc();
        }

        public void InjectDependencies(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(this.Configuration);

            services.AddScoped<IUnitOfWork, UnitOfWork<EmployeeCrudDBContext>>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeService>();

        }
    }
}
