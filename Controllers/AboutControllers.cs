using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

	public class AboutController : Controller
	{

		public IActionResult Index()
		{
			return Content("this is the About Controller's Index action!");
		}

		public IActionResult History()
		{
			return Content("this is the About Controller's History action!");
		}

		public IActionResult Location()
		{
			return Content("this is the About Controller's Location action!");
		}
	}
}