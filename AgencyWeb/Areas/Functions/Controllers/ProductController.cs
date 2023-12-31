﻿using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using AgencyWeb.Services;
using Microsoft.AspNetCore.Mvc;
using AgencyWeb.Areas.BaseController;

namespace AgencyWeb.Areas.Functions.Controllers
{
    public class ProductController : BaseFunctionController
    {
        //Uri baseAddress = new Uri("http://localhost:49557/api");
        //private readonly HttpClient _client;

        private readonly IApiService _apiService;

        public ProductController(IApiService apiService)
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
        public object GetProductList(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetProductListApi();

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetRiderList(DataSourceLoadOptions loadOptions, int id)
        {
            var _response = _apiService.GetRiderListApi(id);

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetPayModeList(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetPayModeListApi();

            return DataSourceLoader.Load(_response, loadOptions);
        }

    }
}
