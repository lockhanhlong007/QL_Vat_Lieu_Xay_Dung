using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.SignalR;
using QL_Vat_Lieu_Xay_Dung_Data.Enums;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Common;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.System;
using QL_Vat_Lieu_Xay_Dung_WebApp.Authorization;
using QL_Vat_Lieu_Xay_Dung_WebApp.Extensions;
using QL_Vat_Lieu_Xay_Dung_WebApp.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL_Vat_Lieu_Xay_Dung_WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class PageController : Controller
    {
        private readonly IPageService _pageService;

        private readonly IAuthorizationService _authorizationService;

        private readonly IHubContext<QLVLXD_Hub> _hubContext;

        public PageController(IPageService pageService, IAuthorizationService authorizationService, IHubContext<QLVLXD_Hub> hubContext)
        {
            _pageService = pageService;
            _authorizationService = authorizationService;
            _hubContext = hubContext;
        }

        #region Get Data Api

        public async Task<IActionResult> Index()
        {
            var result = await _authorizationService.AuthorizeAsync(User, "PAGE", Operation.Read);
            if (!result.Succeeded)
            {
                return new RedirectResult("/Admin/Error");
            }
            return View();
        }

        public IActionResult GetAll()
        {
            var model = _pageService.GetAll();

            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _pageService.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int page, int pageSize)
        {
            var model = _pageService.GetAllPaging(keyword, page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpPost]
        public async Task<IActionResult> SaveEntity(PageViewModel pageViewModel)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            if (pageViewModel.Id == 0)
            {
                var notificationId = Guid.NewGuid().ToString();
                var announcement = new AnnouncementViewModel
                {
                    Title = User.GetSpecificClaim("FullName"),
                    DateCreated = DateTime.Now,
                    Content = $"Page {pageViewModel.Name} has been created",
                    Id = notificationId,
                    UserId = User.GetUserId(),
                    Image = User.GetSpecificClaim("Avatar"),
                    Status = Status.Active
                };
                var announcementUsers = new List<AnnouncementUserViewModel>()
                {
                    new AnnouncementUserViewModel(){AnnouncementId = notificationId,HasRead = false,UserId = User.GetUserId()}
                };
                _pageService.Add(announcement, announcementUsers, pageViewModel);
                await _hubContext.Clients.All.SendAsync("ReceiveMessage", announcement);
            }
            else
            {
                var notificationId = Guid.NewGuid().ToString();
                var announcement = new AnnouncementViewModel
                {
                    Title = User.GetSpecificClaim("FullName"),
                    DateCreated = DateTime.Now,
                    Content = $"Page {pageViewModel.Name} has been updated",
                    Id = notificationId,
                    UserId = User.GetUserId(),
                    Image = User.GetSpecificClaim("Avatar"),
                    Status = Status.Active
                };
                var announcementUsers = new List<AnnouncementUserViewModel>()
                {
                    new AnnouncementUserViewModel(){AnnouncementId = notificationId,HasRead = false,UserId = User.GetUserId()}
                };
                _pageService.Update(announcement, announcementUsers, pageViewModel);
                await _hubContext.Clients.All.SendAsync("ReceiveMessage", announcement);
            }
            _pageService.SaveChanges();
            return new OkObjectResult(pageViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }
            var notificationId = Guid.NewGuid().ToString();
            var announcement = new AnnouncementViewModel
            {
                Title = User.GetSpecificClaim("FullName"),
                DateCreated = DateTime.Now,
                Content = $"Page {_pageService.GetById(id).Name} has been deleted",
                Id = notificationId,
                UserId = User.GetUserId(),
                Image = User.GetSpecificClaim("Avatar"),
                Status = Status.Active
            };
            var announcementUsers = new List<AnnouncementUserViewModel>()
            {
                new AnnouncementUserViewModel(){AnnouncementId = notificationId,HasRead = false,UserId = User.GetUserId()}
            };
            _pageService.Delete(announcement, announcementUsers, id);
            _pageService.SaveChanges();
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", announcement);
            return new OkObjectResult(id);
        }

        #endregion Get Data Api
    }
}