using AutoMapper;
using QL_Vat_Lieu_Xay_Dung_Data.Entities;
using QL_Vat_Lieu_Xay_Dung_Infrastructure.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Common;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.System;
using QL_Vat_Lieu_Xay_Dung_Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QL_Vat_Lieu_Xay_Dung_Services.Implementation
{
    public class PageService : IPageService
    {
        private readonly IRepository<Page, int> _pageRepository;

        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        private readonly IRepository<Announcement, string> _announceRepository;

        private readonly IRepository<AnnouncementUser, int> _announceUserRepository;

        public PageService(IRepository<Page, int> pageRepository,
            IUnitOfWork unitOfWork, IMapper mapper, IRepository<Announcement, string> announceRepository, IRepository<AnnouncementUser, int> announceUserRepository)
        {
            this._pageRepository = pageRepository;
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
            _announceRepository = announceRepository;
            _announceUserRepository = announceUserRepository;
        }

        public void Add(PageViewModel pageViewModel)
        {
            var page = _mapper.Map<PageViewModel, Page>(pageViewModel);
            _pageRepository.Add(page);
        }

        public void Delete(int id)
        {
            _pageRepository.Remove(id);
        }

        #region RealTime

        public void Add(AnnouncementViewModel announcementViewModel, List<AnnouncementUserViewModel> announcementUsers, PageViewModel pageViewModel)
        {
            var page = _mapper.Map<PageViewModel, Page>(pageViewModel);
            _pageRepository.Add(page);
            // Real Time
            var announcement = _mapper.Map<AnnouncementViewModel, Announcement>(announcementViewModel);
            _announceRepository.Add(announcement);
            foreach (var announcementUserViewModel in announcementUsers)
            {
                _announceUserRepository.Add(_mapper.Map<AnnouncementUserViewModel, AnnouncementUser>(announcementUserViewModel));
            }
        }

        public void Update(AnnouncementViewModel announcementViewModel, List<AnnouncementUserViewModel> announcementUsers, PageViewModel pageViewModel)
        {
            var page = _mapper.Map<PageViewModel, Page>(pageViewModel);
            _pageRepository.Update(page);
            // Real Time
            var announcement = _mapper.Map<AnnouncementViewModel, Announcement>(announcementViewModel);
            _announceRepository.Add(announcement);
            foreach (var announcementUserViewModel in announcementUsers)
            {
                _announceUserRepository.Add(_mapper.Map<AnnouncementUserViewModel, AnnouncementUser>(announcementUserViewModel));
            }
        }

        public void Delete(AnnouncementViewModel announcementViewModel, List<AnnouncementUserViewModel> announcementUsers, int id)
        {
            _pageRepository.Remove(id);
            // Real Time
            var announcement = _mapper.Map<AnnouncementViewModel, Announcement>(announcementViewModel);
            _announceRepository.Add(announcement);
            foreach (var announcementUserViewModel in announcementUsers)
            {
                _announceUserRepository.Add(_mapper.Map<AnnouncementUserViewModel, AnnouncementUser>(announcementUserViewModel));
            }
        }

        #endregion RealTime

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<PageViewModel> GetAll()
        {
            return _mapper.ProjectTo<PageViewModel>(_pageRepository.FindAll()).ToList();
        }

        public PagedResult<PageViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _pageRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderByDescending(x => x.Alias)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            var paginationSet = new PagedResult<PageViewModel>()
            {
                ResultList = _mapper.ProjectTo<PageViewModel>(data).ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public PageViewModel GetByAlias(string alias)
        {
            return _mapper.Map<Page, PageViewModel>(_pageRepository.FindSingle(x => x.Alias == alias));
        }

        public PageViewModel GetById(int id)
        {
            return _mapper.Map<Page, PageViewModel>(_pageRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(PageViewModel pageViewModel)
        {
            var page = _mapper.Map<PageViewModel, Page>(pageViewModel);
            _pageRepository.Update(page);
        }
    }
}