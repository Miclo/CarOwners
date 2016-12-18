using CarOwners.Models;
using Microsoft.AspNetCore.Mvc;


namespace CarOwners.Controllers
{
	/// <summary>
	/// Class HomeController
	/// </summary>
	/// <summary>
	/// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860
	/// </summary>
	/// ///	<remarks>
	///		<remark>
	///			<ID>LM-04</ID>
	///			<date>2016-12-17</date>
	///			<texts>
	///				<text>How to add your first controller</text>
	///				<text>Add Controllers folder to project (right click project and choose Add...</text>
	///				<text>Then right click Controllers folder and choose Add... choose MVC controller</text>
	///			</texts>
	///			<link>
	///				<title>8. (ASP.NET Core 1.0 &amp; MVC) Creating Your First MVC Application</title>
	///				<url>https://www.youtube.com/watch?v=P7LL3OKFmDU&amp;feature=youtu.be&amp;t=42s</url>
	///			</link>
	///		</remark>
	///		<remark>
	///			<ID>LM-06</ID>
	///			<date>2017-12-17</date>
	///			<texts>
	///				<text>Instantiate model Make and add data --> dataobject</text>
	///			</texts>
	///			<link>
	///				<title>8. (ASP.NET Core 1.0 &amp; MVC) Creating Your First MVC Application</title>
	///				<url>https://www.youtube.com/watch?v=P7LL3OKFmDU&amp;feature=youtu.be&amp;t=4m9s</url>
	///			</link>
	///			<code>Make make =...</code>
	///		</remark>
	///		<remark>
	///			<ID>LM-07</ID>
	///			<date>2017-12-17</date>
	///			<texts>
	///				<text>Add the dataobject as a parameter to the view</text>
	///			</texts>
	///			<link>
	///				<title>8. (ASP.NET Core 1.0 &amp; MVC) Creating Your First MVC Application</title>
	///				<url>https://www.youtube.com/watch?v=P7LL3OKFmDU&amp;feature=youtu.be&amp;t=5m18s</url>
	///			</link>
	///			<code>return View(make)</code>
	///		</remark>
	///	</remarks>
	public class HomeController : Controller
	{

		/// <summary>
		/// Get controller
		/// </summary>
		/// <returns></returns>
		public IActionResult Index()
		{

			Make make = new Make()
			{
				ID = 1,
				Name = "Ford"
			};
			return View(make);
		}
	}
}

