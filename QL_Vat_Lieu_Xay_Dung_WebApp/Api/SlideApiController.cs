﻿using Microsoft.AspNetCore.Mvc;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;

namespace QL_Vat_Lieu_Xay_Dung_WebApp.Api
{
    public class SlideApiController : ApiController
    {
        private readonly ISlideService _slideService;

        public SlideApiController(ISlideService slideService)
        {
            _slideService = slideService;
        }

        [HttpGet("{groupAlias}")]
        public IActionResult GetSlides(string groupAlias)
        {
            return new OkObjectResult(_slideService.GetSlides(groupAlias));
        }
    }
}