using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Murad.WebApi.Data;
using Murad.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Murad.WebApi
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
            services.AddCors(cors => {
                cors.AddPolicy("UdemyPolicy",opt => {
                    opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                    //Origin(saytin gelen isteyi, menbe- www.murad.com)
                    //AllowAnyHeader - JSON, XML her curunu qebul edecek
                    //With allow yazsaq ozumuz mehdudiyyet qoyacaqyiq filan yerden gir WithAllow("www.murad.aliyev")

                });
            });


            services.AddDbContext<ProductContext>(opt => 
            {
                opt.UseSqlServer(Configuration.GetConnectionString("LocalDB"));
            });


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Murad.WebApi", Version = "v1" });
            });
            services.AddScoped<IProductRepository, ProductRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Murad.WebApi v1"));
            }

            app.UseRouting();
            app.UseCors("UdemyPolicy");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
