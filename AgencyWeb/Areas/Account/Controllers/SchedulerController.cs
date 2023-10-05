using AgencyWeb.Areas.BaseController;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.Account.Controllers
{
    public class SchedulerController : BaseAccountController
    {
        //Uri baseAddress = new Uri("http://localhost:49557/api");
        //private readonly HttpClient _client;

        private readonly IApiService _apiService;

        public SchedulerController(IApiService apiService)
        {
            //_client = new HttpClient();
            //_client.BaseAddress = baseAddress;
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object GetSchedulerList(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetSchedulerListApi();

            return DataSourceLoader.Load(_response, loadOptions);
        }
    }
}
