using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.BaseController
{
    [Area(AreaName)]
    public class BaseAccountController : Controller
    {
        public const string AreaName = "Account";
    }
}
