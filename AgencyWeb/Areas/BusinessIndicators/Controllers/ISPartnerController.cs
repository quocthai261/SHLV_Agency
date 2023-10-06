using AgencyWeb.Areas.BaseController;
using AgencyWeb.Models;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.BusinessIndicators.Controllers
{
    public class ISPartnerController : BaseBusinessIndicatorController
    {
        private readonly IApiService _apiService;

        public ISPartnerController(IApiService apiService)
        {
            //_client = new HttpClient();
            //_client.BaseAddress = baseAddress;
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*       public IActionResult AgentDetail()
               {
                   return View();
               }*/

        [HttpGet]
        public object GetISPartner(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetUserListApi();

            return DataSourceLoader.Load(_response, loadOptions);
        }
        public IActionResult Detail(long id)
        {
            var _response = SampleData.userList.First(p => p.UserId == id);
            return View(_response);
        }
    }
}
