using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.Functions.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.Functions.Controllers
{
    public class ContactController : BaseFunctionController
    {
        public IActionResult Index()
        {
            var officeType = officeTypeList;
            ViewBag.contactList = contactList;
            return View(officeType);
        }

        public static List<ContactDto> contactList = new List<ContactDto>()
        {
            new ContactDto
            {
                ContactId = 1,
                Address = "Tầng 8, Tòa tháp A, Tòa nhà Sky City\r\n88 Láng Hạ, Phường Láng Hạ, Quận Đống Đa",
                Province = "Hà Nội",
                MapLink = "https://maps.app.goo.gl/69GtB6aaFiiqMDL27",
                OfficeTypeId = 2,
            },
            new ContactDto
            {
                ContactId = 2,
                Address = "Tầng Trệt, Tòa Nhà Yoco Office\r\n41 Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1",
                Province = "TP. Hồ Chí Minh",
                MapLink = "https://maps.app.goo.gl/nfmgvJvgQZCYhCA96",
                OfficeTypeId = 2,
            },
            new ContactDto
            {
                ContactId = 3,
                Address = "Tầng 7, Tòa nhà Lapen Asset, 99 Nguyễn Thị Minh Khai, Phường Bến Thành, Quận 1, TP. HCM",
                Province = "Quận 1, TP. Hồ Chí Minh",
                MapLink = "https://maps.app.goo.gl/1kYiMiUnXPVJj7Pp7",
                OfficeTypeId = 3,
            },
            new ContactDto
            {
                ContactId = 4,
                Address = "Tầng 5, 123 Tân Thắng, phường Sơn Kỳ,\r\nquận Tân Phú, Tp. Hồ Chí Minh",
                Province = "Quận Tân Phú, TP. Hồ Chí Minh",
                MapLink = "https://maps.app.goo.gl/WdC5HNzgkzT5QWgg8",
                OfficeTypeId = 3,
            },
            new ContactDto
            {
                ContactId = 5,
                Address = "Tầng Trệt, Tòa Nhà Yoco Office\r\n41 Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1",
                Province = "TP. Hồ Chí Minh",
                MapLink = "https://maps.app.goo.gl/nfmgvJvgQZCYhCA96",
                OfficeTypeId = 2,
            },


        };

        public static List<OfficeType> officeTypeList = new List<OfficeType>()
        {
            new OfficeType
            {
                OfficeTypeId = 1,
                OfficeTypeName = ""
            },
            new OfficeType
            {
                OfficeTypeId = 2,
                OfficeTypeName = "TRUNG TÂM DỊCH VỤ KHÁCH HÀNG"
            },
            new OfficeType
            {
                OfficeTypeId = 3,
                OfficeTypeName = "VĂN PHÒNG KINH DOANH"
            }
        };

        public class OfficeType
        {
            public long OfficeTypeId { get; set; }
            public string? OfficeTypeName { get; set; }
        }
    }
}
