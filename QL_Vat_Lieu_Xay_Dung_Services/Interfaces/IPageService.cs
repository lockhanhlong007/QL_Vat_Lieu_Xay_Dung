using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Common;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.System;
using QL_Vat_Lieu_Xay_Dung_Utilities.Dtos;
using System;
using System.Collections.Generic;

namespace QL_Vat_Lieu_Xay_Dung_Services.Interfaces
{
    public interface IPageService : IDisposable
    {
        void Add(PageViewModel pageViewModel);

        void Update(PageViewModel pageViewModel);

        void Delete(int id);

        #region RealTime

        void Add(AnnouncementViewModel announcementViewModel,
            List<AnnouncementUserViewModel> announcementUsers, PageViewModel pageViewModel);

        void Update(AnnouncementViewModel announcementViewModel,
            List<AnnouncementUserViewModel> announcementUsers, PageViewModel pageViewModel);

        void Delete(AnnouncementViewModel announcementViewModel,
            List<AnnouncementUserViewModel> announcementUsers, int id);

        #endregion RealTime

        List<PageViewModel> GetAll();

        PagedResult<PageViewModel> GetAllPaging(string keyword, int page, int pageSize);

        PageViewModel GetByAlias(string alias);

        PageViewModel GetById(int id);

        void SaveChanges();
    }
}