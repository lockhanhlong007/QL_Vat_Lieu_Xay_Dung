﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QL_Vat_Lieu_Xay_Dung_Data.Entities;
using QL_Vat_Lieu_Xay_Dung_Infrastructure.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.Interfaces;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.System;
using QL_Vat_Lieu_Xay_Dung_Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL_Vat_Lieu_Xay_Dung_Services.Implementation
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;

        private readonly IRepository<Function, string> _functionRepository;

        private readonly IRepository<Permission, int> _permissionRepository;

        private readonly IRepository<Announcement, string> _announceRepository;

        private readonly IRepository<AnnouncementUser, int> _announceUserRepository;

        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;

        public RoleService(RoleManager<AppRole> roleManager, IUnitOfWork unitOfWork, IRepository<Function, string> functionRepository, IRepository<Permission, int> permissionRepository, IMapper mapper, IRepository<Announcement, string> announceRepository, IRepository<AnnouncementUser, int> announceUserRepository)
        {
            _unitOfWork = unitOfWork;
            _roleManager = roleManager;
            _functionRepository = functionRepository;
            _permissionRepository = permissionRepository;
            _mapper = mapper;
            _announceRepository = announceRepository;
            _announceUserRepository = announceUserRepository;
        }

        public async Task<bool> AddAsync(AnnouncementViewModel announcementViewModel,
            List<AnnouncementUserViewModel> announcementUsers, AppRoleViewModel roleViewModel)
        {
            var role = new AppRole()
            {
                Name = roleViewModel.Name,
                Description = roleViewModel.Description
            };
            var result = await _roleManager.CreateAsync(role);
            // Real Time
            var announcement = _mapper.Map<AnnouncementViewModel, Announcement>(announcementViewModel);
            _announceRepository.Add(announcement);
            foreach (var announcementUserViewModel in announcementUsers)
            {
                _announceUserRepository.Add(_mapper.Map<AnnouncementUserViewModel, AnnouncementUser>(announcementUserViewModel));
            }
            _unitOfWork.Commit();
            return result.Succeeded;
        }

        public async Task<bool> UpdateAsync(AnnouncementViewModel announcementViewModel, List<AnnouncementUserViewModel> announcementUsers, AppRoleViewModel roleViewModel)
        {
            var role = await _roleManager.FindByIdAsync(roleViewModel.Id.ToString());
            role.Description = roleViewModel.Description;
            role.Name = roleViewModel.Name;
            var result = await _roleManager.UpdateAsync(role);
            // Real Time
            var announcement = _mapper.Map<AnnouncementViewModel, Announcement>(announcementViewModel);
            _announceRepository.Add(announcement);
            foreach (var announcementUserViewModel in announcementUsers)
            {
                _announceUserRepository.Add(_mapper.Map<AnnouncementUserViewModel, AnnouncementUser>(announcementUserViewModel));
            }
            _unitOfWork.Commit();
            return result.Succeeded;
        }

        public async Task<bool> DeleteAsync(AnnouncementViewModel announcementViewModel, List<AnnouncementUserViewModel> announcementUsers, Guid id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            var result = await _roleManager.DeleteAsync(role);
            // Real Time
            var announcement = _mapper.Map<AnnouncementViewModel, Announcement>(announcementViewModel);
            _announceRepository.Add(announcement);
            foreach (var announcementUserViewModel in announcementUsers)
            {
                _announceUserRepository.Add(_mapper.Map<AnnouncementUserViewModel, AnnouncementUser>(announcementUserViewModel));
            }
            _unitOfWork.Commit();
            return result.Succeeded;
        }

        public Task<bool> CheckPermission(string functionId, string action, string[] roles)
        {
            var querySyntaxMethod = _functionRepository
                .FindAll()
                .Join(_permissionRepository.FindAll(), f => f.Id, p => p.FunctionId, (f, p) => new { f, p })
                .Join(_roleManager.Roles, k => k.p.RoleId, r => r.Id, (k, r) => new { k, r })
                .Where(x => roles.Contains(x.r.Name) && x.k.f.Id == functionId &&
                            ((x.k.p.CanRead && action == "Read") || (x.k.p.CanUpdate && action == "Update") ||
                             (x.k.p.CanCreate && action == "Create") || (x.k.p.CanDelete && action == "Delete")))
                .Select(x => new { x });
            return querySyntaxMethod.AnyAsync();
        }

        public async Task<bool> AddAsync(AppRoleViewModel roleViewModel)
        {
            var role = new AppRole()
            {
                Name = roleViewModel.Name,
                Description = roleViewModel.Description
            };
            var result = await _roleManager.CreateAsync(role);
            return result.Succeeded;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            var result = await _roleManager.DeleteAsync(role);
            return result.Succeeded;
        }

        public async Task<List<AppRoleViewModel>> GetAllAsync()
        {
            return await _mapper.ProjectTo<AppRoleViewModel>(_roleManager.Roles).ToListAsync();
        }

        public PagedResult<AppRoleViewModel> GetAllPagingAsync(string keyword, int page, int pageSize)
        {
            var query = _roleManager.Roles;
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword)
                || x.Description.Contains(keyword));

            var totalRow = query.Count();
            query = query.Skip((page - 1) * pageSize)
               .Take(pageSize);

            var data = _mapper.ProjectTo<AppRoleViewModel>(query).ToList();
            var paginationSet = new PagedResult<AppRoleViewModel>()
            {
                ResultList = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public async Task<AppRoleViewModel> GetById(Guid id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            return _mapper.Map<AppRole, AppRoleViewModel>(role);
        }

        public async Task<AppRoleViewModel> GetByName(string name)
        {
            var role = await _roleManager.FindByNameAsync(name);
            return _mapper.Map<AppRole, AppRoleViewModel>(role);
        }

        public List<PermissionViewModel> GetListFunctionWithRole(Guid roleId)
        {
            var queryable = _functionRepository.FindAll()
                .GroupJoin(_permissionRepository.FindAll(), f => f.Id,
                p => p.FunctionId, (f, p) => new
                {
                    f = f,
                    p = p
                })
                .SelectMany(kq => kq.p.DefaultIfEmpty(), (kq, p) => new
                {
                    p = p,
                    kq = kq
                })
                .Where(x => x.p != null && x.p.RoleId == roleId)
                .Select(x => new PermissionViewModel()
                {
                    RoleId = roleId,
                    FunctionId = x.kq.f.Id,
                    CanCreate = x.p != null && x.p.CanCreate,
                    CanDelete = x.p != null && x.p.CanDelete,
                    CanRead = x.p != null && x.p.CanRead,
                    CanUpdate = x.p != null && x.p.CanUpdate
                });
            return queryable.ToList();
        }

        public IQueryable<FunctionViewModel> GetListFunctionWithRole_Function(Guid roleId)
        {
            var queryable = _functionRepository.FindAll()
                .GroupJoin(_permissionRepository.FindAll(), f => f.Id,
                p => p.FunctionId, (f, p) => new
                {
                    f = f,
                    p = p
                })
                .SelectMany(kq => kq.p.DefaultIfEmpty(), (kq, p) => new
                {
                    p = p,
                    kq = kq
                })
                .Where(x => x.p != null && x.p.RoleId == roleId && x.p.CanRead)
                .Select(x => new FunctionViewModel()
                {
                    Id = x.kq.f.Id,
                    IconCss = x.kq.f.IconCss,
                    Name = x.kq.f.Name,
                    ParentId = x.kq.f.ParentId,
                    SortOrder = x.kq.f.SortOrder,
                    Status = x.kq.f.Status,
                    URL = x.kq.f.URL
                });
            return queryable;
        }

        public void SavePermission(List<PermissionViewModel> permissionViewModels, Guid roleId)
        {
            var permissions = _mapper.Map<List<PermissionViewModel>, List<Permission>>(permissionViewModels);
            var oldPermission = _permissionRepository.FindAll().Where(x => x.RoleId == roleId).ToList();
            if (oldPermission.Count > 0)
            {
                _permissionRepository.RemoveMultiple(oldPermission);
            }
            foreach (var permission in permissions)
            {
                _permissionRepository.Add(permission);
            }
            _unitOfWork.Commit();
        }

        public async Task<bool> UpdateAsync(AppRoleViewModel roleViewModel)
        {
            var role = await _roleManager.FindByIdAsync(roleViewModel.Id.ToString());
            role.Description = roleViewModel.Description;
            role.Name = roleViewModel.Name;
            var result = await _roleManager.UpdateAsync(role);
            return result.Succeeded;
        }
    }
}