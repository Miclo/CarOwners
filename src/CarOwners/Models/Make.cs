using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarOwners.Models
{
	/// <summary>
	/// This contains or gets the data for car makes
	/// </summary>
	///	<remarks>
	///		<remark>
	///			<ID>LM-05</ID>
	///			<date>2016-12-17</date>
	///			<texts>
	///				<text>How to create a model</text>
	///				<text>Right click on Models and choose add...</text>
	///				<text>Choose Class and name it</text>
	///			</texts>
	///			<link>
	///				<title>8. (ASP.NET Core 1.0 &amp; MVC) Creating Your First MVC Application</title>
	///				<url>https://www.youtube.com/watch?v=P7LL3OKFmDU&amp;feature=youtu.be&amp;t=3m15s</url>
	///			</link>
	///			<code></code>
	///		</remark>
	///	</remarks>	
	public class Make
    {
		/// <summary>
		/// Primary Key
		/// </summary>
		///	<remarks>
		///		<remark>
		///			<ID>LM-06</ID>
		///			<date>2017-12-17</date>
		///			<texts>
		///				<text>Adding properties</text>
		///			</texts>
		///			<link>
		///				<title></title>
		///				<url>https://www.youtube.com/watch?v=P7LL3OKFmDU&amp;feature=youtu.be&amp;t=3m38s</url>
		///			</link>
		///		</remark>
		///	</remarks>
		public int ID { get; set; }
		/// <summary>
		/// Name of car make
		/// </summary>
		public string Name { get; set; }
	}
}
