using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _3._3Formulas
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.Map("/index", Index);
            app.Map("/about", About);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Page Not Found");
            });
        }

        private static void Index(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                double x = 15;
                double y = 13;
                double z = 0;
                z = Math.Sin(x) / x + Math.Log(5) / y + y * Math.Cos(y);
                await context.Response.WriteAsync($"sin({x}) / {x} + log(5) / {y} + {y} * cos({y}) = {z}");
            });
        }

        private static void About(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                double x = 15;
                double y = 13;
                double z = 0;
                z = Math.Sqrt(x) + Math.Pow(x, y) / Math.Sin(x) + Math.Tan(y) / y;
                await context.Response.WriteAsync($"sqrt({x}) + pow({x}, {y}) / sin({x} + tg({y}) / y = {z}");
            });
        }
    }
}