using AgencyWeb.Areas.BaseController;
using AgencyWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.Account.Controllers
{
    public class PersonalInfoController : BaseAccountController
    {
        //Uri baseAddress = new Uri("http://localhost:49557/api");
        //private readonly HttpClient _client;

        private readonly IApiService _apiService;

        public PersonalInfoController(IApiService apiService)
        {
            //_client = new HttpClient();
            //_client.BaseAddress = baseAddress;
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }  
    }
}
