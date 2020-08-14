﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QL_Vat_Lieu_Xay_Dung_Data.Entities;
using QL_Vat_Lieu_Xay_Dung_Utilities.Dtos;
using QL_Vat_Lieu_Xay_Dung_WebApp.Models.AccountViewModels;
using System.Threading.Tasks;

namespace QL_Vat_Lieu_Xay_Dung_WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly SignInManager<AppUser> _signInManager;

        private readonly ILogger _logger;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager
            , ILogger<LoginController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            await _signInManager.SignOutAsync();
            return View();
        }

        #region Get Data API

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AuthenTask(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles.Count > 0)
                    {
                        // This doesn't count login failures towards account lockout
                        // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                        var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, lockoutOnFailure: true);
                        if (result.Succeeded)
                        {
                            _logger.LogInformation("User logged in.");
                            return new OkObjectResult(new GenericResult(true));
                        }
                        else if (result.IsLockedOut)
                        {
                            _logger.LogWarning("User account locked out.");
                            return new ObjectResult(new GenericResult(false, "Tài khoản đã bị khoá"));
                        }
                        else
                        {
                            _logger.LogWarning("Password is incorrect.");
                            return new ObjectResult(new GenericResult(false, "Mật khẩu không đúng"));
                        }
                    }
                    _logger.LogInformation("User is Customer.");
                    return new OkObjectResult(new GenericResult(false, "Bạn không có quyền truy cập vào trang admin"));
                }

                _logger.LogInformation("Username does not exist.");
                return new OkObjectResult(new GenericResult(false, "Username không tồn tại"));
            }

            // If we got this far, something failed, redisplay form
            return new ObjectResult(new GenericResult(false, model));
        }

        #endregion Get Data API
    }
}