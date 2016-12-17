using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ProvincePlaatsen
{
    /// <summary>
    /// The web part starts here
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            /// <summary>
            /// LM-02:   Add MVC services to project
            ///          6. (ASP.NET Core 1.0 and MVC) Adding MVC To Our Project
            ///          https://www.youtube.com/watch?v=3xgjB2dzUng&amp;feature=youtu.be&amp;t=6m16s
            /// </summary>
            services.AddMvcCore();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <remarks>
        /// LM-01:   This method is/handles the middelware pipeline 
        ///          5. (ASP.NET Core 1.0 &amp; MVC) Understanding Middleware 
        ///          https://youtu.be/mLbHhCppCH0?t=5s)    
        /// </remarks>
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="loggerFactory"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            


            // LM-03:   Add MVC to Middleware Pipeline
            //          6. (ASP.NET Core 1.0 and MVC) Adding MVC To Our Project
            //          https://www.youtube.com/watch?v=3xgjB2dzUng&feature=youtu.be&t=7m16s
            //          In the above video an older version is used. The code below is copied from a new ASP.NET core project
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"); 
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
