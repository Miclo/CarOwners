using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ProvincePlaatsen
{
	/// <summary>
	/// Start Class
	/// </summary>
	public class Program
	{

		/// <summary>
		/// The program starts 
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			var host = new WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseIISIntegration()
				.UseStartup<Startup>()
				.Build();

			host.Run();
		}
	}
}
