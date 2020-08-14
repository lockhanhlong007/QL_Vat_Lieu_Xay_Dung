﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QL_Vat_Lieu_Xay_Dung_Utilities.Constants;
using QL_Vat_Lieu_Xay_Dung_WebApp.Extensions;
using QL_Vat_Lieu_Xay_Dung_WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QL_Vat_Lieu_Xay_Dung_WebApp.Controllers.Components
{
    public class HeaderCartViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(HttpContext.Session.Get<List<ShopCartViewModel>>(CommonConstants.CartSession) ?? new List<ShopCartViewModel>());
        }
    }
}