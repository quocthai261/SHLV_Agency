using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using AgencyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.Orders, loadOptions);
        }

    }
}
