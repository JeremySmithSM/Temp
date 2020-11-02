using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RJSProject8.Models;

namespace RJSProject8.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}


		// A C C O U N T   P A G E S

		public IActionResult AccountChangePassword()
		{
			return View();
		}

		public IActionResult AccountCreate(Recipe WIP)
		{
			if (ModelState.IsValid)
			{
				//if (WIP.Password == WIP.ConfirmPassword)
				//{
				//
				//	return View(post);
				//}
				//return View("YumRecipeSaved", post);
			}
			else
			{
				//return View(post);
			}
			return View();
		}

		public IActionResult AccountForgotPassword()
		{
			return View();
		}

		public IActionResult AccountLogin()
		{
			return View();
		}
		public IActionResult AccountMustChangePassword()
		{
			return View();
		}


		// Y U M M Y   P A G E S

		[HttpGet]
		public IActionResult YumCookieCreate()
		{
			return View();
		}
		[HttpPost]
		public IActionResult YumCookieCreate(Cookie post)
		{
			return View();
		}

		[HttpGet]
		public IActionResult YumCookieEdit()
		{
			return View();
		}
		[HttpPost]
		public IActionResult YumCookieEdit(Cookie post)
		{
			return View();
		}

		public IActionResult YumCookieMain()
		{
			return View();
		}


		[HttpGet]
		public IActionResult YumRecipeCreate()
		{
			return View();
		}
		[HttpPost]
		public IActionResult YumRecipeCreate(Recipe post)
		{
			if (ModelState.IsValid)
			{
				return View("YumRecipeSaved", post);
			}
			else
			{
				return View(post);
			}
		}

		[HttpGet]
		public IActionResult YumRecipeEdit(int id)
		{
			//retrieve the recipe from the database with the given id
			Recipe rex = new Recipe();
			rex.TimeNeeded = "2:30";
			rex.ToolsNeeded = "brains and hands";
			rex.Ingredients = "chocolate goodness";
			rex.Directions = "eat the cookie";
			return View(rex);
		}
		[HttpPost]
		public IActionResult YumRecipeEdit(Recipe post)
		{
			if (ModelState.IsValid)
			{
				return View("YumRecipeSaved", post);
			}
			else
			{
				return View(post);
			}
		}

		public IActionResult YumRecipeMain()
		{
			return View();
		}


		// T R A C K E R   P A G E S

		public IActionResult FoodTracker()
		{
			return View();
		}

		public IActionResult PurchasesMain()
		{
			return View();
		}

		public IActionResult PurchasesEdit()
		{
			return View();
		}

		public IActionResult PurchasesCreate()
		{
			return View();
		}

		public IActionResult WagesMain()
		{
			return View();
		}

		public IActionResult WagesEdit()
		{
			return View();
		}

		public IActionResult WagesCreate()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
