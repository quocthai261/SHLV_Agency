using AgencyWeb.Areas.BaseController;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.Account.Controllers
{
    public class FrequentlyUsedFunctionController : BaseAccountController
    {
        //Uri baseAddress = new Uri("http://localhost:49557/api");
        //private readonly HttpClient _client;

        private readonly IApiService _apiService;

        public FrequentlyUsedFunctionController(IApiService apiService)
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
        public object GetFrequentlyUsedFunctionList(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetFrequentlyUsedFunctionListApi();

            return DataSourceLoader.Load(_response, loadOptions);
        }
    }
}
