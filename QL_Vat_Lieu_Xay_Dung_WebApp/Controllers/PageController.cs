using Microsoft.AspNetCore.Mvc;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;

namespace QL_Vat_Lieu_Xay_Dung_WebApp.Controllers
{
    public class PageController : Controller
    {
        private IPageService _pageService;

        public PageController(IPageService pageService)
        {
            _pageService = pageService;
        }

        [Route("page/{alias}.html", Name = "Page")]
        public IActionResult Index(string alias)
        {
            var page = _pageService.GetByAlias(alias);
            return View(page);
        }
    }
}