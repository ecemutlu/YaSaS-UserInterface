using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace YaSaS_UserInterface.Controllers
{
	public class AuthController : Controller
	{
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		//[HttpPost]
		//public async Task<IActionResult> Login()
		//{
		//	return View();
		//}
		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}
		//[HttpPost]
		//public IActionResult SignIn()
		//{
		//	return View();
		//}
	}
}

