using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1_JosueGordon
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/tarea1/{name:alpha}/{course:alpha}", async context =>
                {
                    var name = context.Request.RouteValues["name"];
                    var course = context.Request.RouteValues["course"];
                    await context.Response.WriteAsync($"Esta es la primera tarea de {name} para el curso de {course}");
                });
                endpoints.MapGet("/", async context =>
                {
                    var name = context.Request.RouteValues["name"];
                    var course = context.Request.RouteValues["course"];
                    await context.Response.WriteAsync("Este es el endpoint default");
                });
            });
        }
    }
}