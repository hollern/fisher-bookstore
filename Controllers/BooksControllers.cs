using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

	public class BooksController : Controller
	{

		public IActionResult Index()
		{
			return Content("this is the Books Controller's Index action!");
		}

		public IActionResult New()
		{
			return Content("this is the Books Controller's New action!");
		}
	}
}