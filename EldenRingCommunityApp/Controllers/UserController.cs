using EldenRingCommunityApp.Models;
using EldenRingCommunityApp.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EldenRingCommunityApp.Controllers
{
    public class UserController : Controller
    {
        UserManager<User> UserManager;
        SignInManager<User> SignInManager;
        private EldenRingAppContext context { get; set; }

        public UserController(EldenRingAppContext ctx, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            context = ctx;
            UserManager= userManager;
            SignInManager= signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await SignInManager.PasswordSignInAsync(
                    model.Username, model.Password, isPersistent: false, lockoutOnFailure: false);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterViewModel model) 
        {
            if (ModelState.IsValid)
            {
                var user = new User();

                user.Email = model.Email;
                user.UserName = model.Username;

                var result = await UserManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    //FIGURE THIS OUT IDK
                //    await SignInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError("", error.Description);
					}
				}
            }
            return View(model);
        }
    }
}
