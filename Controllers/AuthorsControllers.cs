using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

	public class AuthorsControllers : Controller
	{

		public IActionResult Index()
		{
			return Content("this is the Authors Controller's Index action!");
		}

		public IActionResult History()
		{
			return Content("this is the Authors Controller's Featured action!");
		}
	}
}