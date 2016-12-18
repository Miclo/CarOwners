using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CarOwners
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
		///	<remarks>
		///		<remark>
		///			<ID>LM-02</ID>
		///			<date>2016-12-17</date>
		///			<texts>
		///				<text>Add MVC services to project</text>
		///				<text>Do NOT use AspMvcCore!!!</text>
		///			</texts>
		///			<link>
		///				<title>6. (ASP.NET Core 1.0 and MVC) Adding MVC To Our Project</title>
		///				<url>https://www.youtube.com/watch?v=3xgjB2dzUng&amp;feature=youtu.be&amp;t=6m16s</url>
		///			</link>
		///			<code>services.AddMvc</code>
		///		</remark>
		///	</remarks>
		public void ConfigureServices(IServiceCollection services)
		{
			//
			services.AddMvc();
		}


		/// <summary>
		/// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		/// </summary>
		/// <param name="app"></param>
		/// <param name="env"></param>
		/// <param name="loggerFactory"></param>
		///	<remarks>
		///		<remark>
		///			<ID>LM-01</ID>
		///			<date>2016-12-17</date>
		///			<texts>
		///				<text>This method is/handles the middelware pipeline</text>
		///			</texts>
		///			<link>
		///				<title>5. (ASP.NET Core 1.0 &amp; MVC) Understanding Middleware</title>
		///				<url>https://youtu.be/mLbHhCppCH0?t=5s)</url>
		///			</link>
		///			<code></code>
		///		</remark>
		///		<remark>
		///			<ID>LM-03</ID>
		///			<date>2017-12-17</date>
		///			<texts>
		///				<text>Add MVC to Middleware Pipeline</text>
		///			</texts>
		///			<link>
		///				<title>6. (ASP.NET Core 1.0 and MVC) Adding MVC To Our Project</title>
		///				<url>https://www.youtube.com/watch?v=3xgjB2dzUng&amp;feature=youtu.be&amp;t=7m16s</url>
		///			</link>
		///			<code>app.UseMvc(routes =>...</code>
		///		</remark>
		///	</remarks>
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

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
