﻿using QL_Vat_Lieu_Xay_Dung_Data.Enums;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Product;
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.System;
using QL_Vat_Lieu_Xay_Dung_Utilities.Dtos;
using System.Collections.Generic;

namespace QL_Vat_Lieu_Xay_Dung_Services.Interfaces
{
    public interface IBillService
    {
        PagedResult<BillViewModel> GetAllPaging(string startDate, string endDate, string keyword,
            int pageIndex, int pageSize);

        List<BillViewModel> GetAllBill();

        BillViewModel GetDetail(int billId);

        GenericResult Create(BillViewModel billViewModel);

        GenericResult Update(BillViewModel billViewModel);

        GenericResult CreateDetail(BillDetailViewModel billDetailViewModel);

        GenericResult DeleteDetail(int productId, int billId, int sizeId);

        GenericResult UpdateStatus(int orderId, BillStatus status);

        #region Realtime

        GenericResult Create(AnnouncementViewModel announcementViewModel, List<AnnouncementUserViewModel> announcementUsers, BillViewModel billViewModel);

        GenericResult Update(AnnouncementViewModel announcementViewModel, List<AnnouncementUserViewModel> announcementUsers, BillViewModel billViewModel);

        #endregion Realtime

        List<BillDetailViewModel> GetBillDetails(int billId);

        List<SizeViewModel> GetSizes();

        SizeViewModel GetSize(int id);

        void Save();
    }
}