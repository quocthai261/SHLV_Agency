using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.BaseController
{
    [Area(AreaName)]
    public class BaseFunctionController : Controller
    {
        public const string AreaName = "Functions";
    }
}
