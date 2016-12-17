using Microsoft.AspNetCore.Mvc;

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
///	</remarks>
namespace CarOwners.Controllers
{
	/// <summary>
	/// Class HomeController
	/// </summary>
	public class HomeController : Controller
    {
		
		/// <summary>
		/// GET controller
		/// </summary>
		/// <returns></returns>
		public IActionResult Index()
        {
            return View();
        }
    }
}
