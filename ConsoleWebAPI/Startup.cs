using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWebAPI
{
    public class Startup
    {

        //public void Configure(IApplicationBuilder app)
        //{
        //    app.Run(context =>
        //    {
        //        return context.Response.WriteAsync("Hello world");
        //    });
        //}
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(s =>
            {
                s.MapRoute("default", "{controller}/{action}/{id?}", "test/index");
            });
            app.Run(context =>
            {
                return context.Response.WriteAsync("Hello world");
            });
        }
    }
}
