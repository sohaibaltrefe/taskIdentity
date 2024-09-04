using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using taskIdentity.Data;
using taskIdentity.Models.Viewmodel;

namespace taskIdentity.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountsController(ApplicationDbContext context,UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model) {
            IdentityUser user = new IdentityUser()
            {
                Email = model.Email,
                PhoneNumber=model.Phone,
                UserName= model.Email
            };
        var resilt=  await userManager.CreateAsync(user,model.Password);
            if (resilt.Succeeded) {                return RedirectToAction("Login");
 }
            return View(model);

           
            
         
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginviewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe,false);
            if (result.Succeeded) {
                return RedirectToAction("Index", "Home");

            }

            return View(model);
        }
        }
    }
