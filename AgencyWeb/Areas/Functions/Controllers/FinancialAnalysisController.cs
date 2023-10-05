using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using AgencyWeb.Services;
using Microsoft.AspNetCore.Mvc;
using AgencyWeb.Areas.BaseController;

namespace AgencyWeb.Areas.Functions.Controllers
{
    public class FinancialAnalysisController : BaseFunctionController
    {
        //Uri baseAddress = new Uri("http://localhost:49557/api");
        //private readonly HttpClient _client;

        private readonly IApiService _apiService;

        public FinancialAnalysisController(IApiService apiService)
        {
            //_client = new HttpClient();
            //_client.BaseAddress = baseAddress;
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult FinancialAnalysisDetail()
        {
            return View();
        }

        [HttpGet]
        public object GetFinancialPlanList(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetFinancialPlanListApi();

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetFinancialAnalysisList(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetFinancialAnalysisListApi();

            return DataSourceLoader.Load(_response, loadOptions);
        }
    }
}
