using System;
using Microsoft.AspNetCore.Mvc;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;
using QL_Vat_Lieu_Xay_Dung_WebApp.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;

namespace QL_Vat_Lieu_Xay_Dung_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        private readonly IProductCategoryService _productCategoryService;

        private readonly ISlideService _slideService;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IProductService productService, IProductCategoryService productCategoryService, ISlideService slideService, IStringLocalizer<HomeController> localizer)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
            _slideService = slideService;
            _localizer = localizer;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Index()
        {
            ViewData["BodyClass"] = "cms-index-index cms-home-page";
            var title = _localizer["Title"];
            var culture = HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.Name;
            var homeViewModel = new HomeViewModel
            {
                HotProducts = _productService.GetHotProducts(7),
                NewProducts = _productService.GetNewProducts(7),
                HomeSlides = _slideService.GetSlides("top"),
                HomeCategories = _productCategoryService.GetHomeCategories(7),
                MetaKeyWord = "Quảng Lý Vật Liệu Xây Dựng",
                MetaDescription = "Quảng Lý Vật Liệu Xây Dựng",
                Title = "Trang Chủ"
            };
            return View(homeViewModel);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult RefreshCart()
        {
            return ViewComponent("HeaderCart");
        }
    }
}