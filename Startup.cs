using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ConsoleToWeb
{
    public class Startup
    {

        public void ConfigureServices()
        {
        }

        public void Configure(IApplicationBuilder app)
        {

            app.UseRouting();

            app.UseEndpoints(endpoints =>
           {
               endpoints.MapGet("/", async context =>
               {
                   await context.Response.WriteAsync("Hello Fomr Web Application");

               });
           });


        }

    }
}