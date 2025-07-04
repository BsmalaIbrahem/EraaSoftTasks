using DataLayer.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using NuGet.Common;
using PresentationLayer.ViewModels;
using System.Threading.Tasks;

namespace PresentationLayer.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager, IEmailSender _emailSender, RoleManager<IdentityRole> roleManager)
        {
            this._userManager = _userManager;
            this._signInManager = _signInManager;
            this._emailSender = _emailSender;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if(! ModelState.IsValid)
            {
                return View(model);
            }
            var user = new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email,
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = Url.Action(nameof(ConfirmEmail), "Account", new { userId = user.Id, token = token }, Request.Scheme);
                await _emailSender.SendEmailAsync(model.Email, "Confirm your email", $"Please confirm your account by clicking this link: <a href='{confirmationLink}'>link</a>");
                return RedirectToAction(nameof(ConfirmEmailPage), "Account", new { userId = user.Id, area = "Identity" });
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }

        }

        public async Task<IActionResult> ConfirmEmailPage(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null || user?.EmailConfirmed == true)
            {
                return NotFound();
            }
            return View();
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "Confirmed successfully.";
                return RedirectToAction(nameof(Login));
            }
            else
            {
                TempData["error"] = "Not Confirmed";
                return RedirectToAction(nameof(Register));
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.UserNameOrEmail) ??
                       await _userManager.FindByNameAsync(model.UserNameOrEmail);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "User Name Or Email is InValid");
                return View(model);
            }
            var result = await _userManager.CheckPasswordAsync(user, model.Password);
            if(result)
            {
                if (!user.EmailConfirmed)
                {
                    ModelState.AddModelError(string.Empty, "Email is not confirmed. Please check your email for confirmation link.");
                    return View(model);
                }
                await _signInManager.SignInAsync(user, model.RememberMe);
                var roles = await _userManager.GetRolesAsync(user);
                if(roles.Contains("SuperAdmin") || roles.Contains("Admin"))
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "Customer" });
                }
               
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Password is InValid");
                return View(model);
            }
        }
    
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account", new { area = "Identity" });
        }

    }
}
