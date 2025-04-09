using System.Security.Claims;
using GoEdu.Models;
using GoEdu.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GoEdu.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(VMRegister userFromREquest)
        {
            if (ModelState.IsValid)
            {
                //add db
                ApplicationUser userApp = new ApplicationUser();
                userApp.UserName = userFromREquest.UserName;
                userApp.PasswordHash = userFromREquest.Password;
                //userApp.Address = userFromREquest.Address;
                IdentityResult result = await userManager.CreateAsync(userApp, userFromREquest.Password);
                if (result.Succeeded)
                {
                    //add user to role
                  //  await userManager.AddToRoleAsync(userApp, "Admin");//add User To Role
                    await signInManager.SignInAsync(userApp, false);
                    //cookkie
                    return RedirectToAction("Index", "Home");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View("Register", userFromREquest);
        }
        #region Login
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(VMLogin userFRomREquest)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser appFromDb =
                    await userManager.FindByNameAsync(userFRomREquest.UserName);
                if (appFromDb != null)
                {
                    bool found = await userManager.CheckPasswordAsync(appFromDb, userFRomREquest.Password);
                    if (found)
                    {
                        List<Claim> claims = new List<Claim>();
                        //claims.Add(new Claim("Address", appFromDb.Address));

                        await signInManager.SignInWithClaimsAsync(appFromDb, userFRomREquest.RememberMe, claims);
                        //await signInManager.SignInAsync(appFromDb, userFRomREquest.RememberMe);
                        return RedirectToAction("Index", "Department");
                    }
                }
                ModelState.AddModelError("", "Invalid Account");
            }
            return View("Login", userFRomREquest);
        }


        #endregion

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}
