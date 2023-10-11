using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.Functions.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace AgencyWeb.Areas.Functions.Controllers
{
    public class BonusController : BaseFunctionController
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object GetBonusList(DataSourceLoadOptions loadOptions)
        {
            var _response = listBonus;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        
        public static List<BonusDto> listBonus = new List<BonusDto>()
        {
            
            new BonusDto
            {
                BonusId = 1,
                BonusDate = DateTime.ParseExact("01/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 1740,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
            {
                BonusId = 2,
                BonusDate = DateTime.ParseExact("02/13/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 850,
                BonusName = "Hoa hồng dự án LimePro"
            },
            new BonusDto
            {
                BonusId = 3,
                BonusDate = DateTime.ParseExact("03/07/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 2235,
                BonusName = "Hoa hồng dự án LimePro"
            },
            new BonusDto
            {
                BonusId = 4,
                BonusDate = DateTime.ParseExact("04/10/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 880,
                BonusName = "Thi đua top 1 KPI"
            },
            new BonusDto
            {
                BonusId = 5,
                BonusDate = DateTime.ParseExact("05/17/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 5260,
                BonusName = "Dẫn đầu phòng ban"
            },
            new BonusDto
            {
                BonusId = 6,
                BonusDate = DateTime.ParseExact("05/17/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 930,
                BonusName = "Thi đua top 1 KPI"
            },
            new BonusDto
            {
                BonusId = 7,
                BonusDate = DateTime.ParseExact("06/13/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 850,
                BonusName = "Hoa hồng dự án LimePro"
            },
            new BonusDto
            {
                BonusId = 8,
                BonusDate = DateTime.ParseExact("07/13/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 850,
                BonusName = "Hoa hồng dự án LimePro"
            },
            new BonusDto
            {
                BonusId = 9,
                BonusDate = DateTime.ParseExact("08/13/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 850,
                BonusName = "Hoa hồng dự án LimePro"
            },
            new BonusDto
            {
                BonusId = 10,
                BonusDate = DateTime.ParseExact("09/13/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 850,
                BonusName = "Hoa hồng dự án LimePro"
            },
            new BonusDto
            {
                BonusId = 11,
                BonusDate = DateTime.ParseExact("06/17/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 930,
                BonusName = "Thi đua top 1 KPI"
            },
            new BonusDto
            {
                BonusId = 12,
                BonusDate = DateTime.ParseExact("07/17/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 930,
                BonusName = "Thi đua top 1 KPI"
            },
            new BonusDto
            {
                BonusId = 13,
                BonusDate = DateTime.ParseExact("08/17/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 930,
                BonusName = "Thi đua top 1 KPI"
            },
            new BonusDto
            {
                BonusId = 14,
                BonusDate = DateTime.ParseExact("09/17/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 930,
                BonusName = "Thi đua top 1 KPI"
            },
            new BonusDto
            {
                BonusId = 15,
                BonusDate = DateTime.ParseExact("10/17/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 930,
                BonusName = "Thi đua top 1 KPI"
            },
            new BonusDto
            {
                BonusId = 16,
                BonusDate = DateTime.ParseExact("11/17/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 930,
                BonusName = "Thi đua top 1 KPI"
            },
            new BonusDto
            {
                BonusId = 17,
                BonusDate = DateTime.ParseExact("12/17/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 930,
                BonusName = "Thi đua top 1 KPI"
            },
            new BonusDto
            {
                BonusId = 18,
                BonusDate = DateTime.ParseExact("02/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 120,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
            {
                BonusId = 19,
                BonusDate = DateTime.ParseExact("03/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 120,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
            {
                BonusId = 20,
                BonusDate = DateTime.ParseExact("04/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 120,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
            {
                BonusId = 21,
                BonusDate = DateTime.ParseExact("05/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 120,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
            {
                BonusId = 22,
                BonusDate = DateTime.ParseExact("06/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 120,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
            {
                BonusId = 23,
                BonusDate = DateTime.ParseExact("07/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 120,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
            {
                BonusId = 24,
                BonusDate = DateTime.ParseExact("08/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 120,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
            {
                BonusId = 25,
                BonusDate = DateTime.ParseExact("09/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 120,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
            {
                BonusId = 26,
                BonusDate = DateTime.ParseExact("10/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 120,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
            {
                BonusId = 27,
                BonusDate = DateTime.ParseExact("11/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 120,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
            {
                BonusId = 28,
                BonusDate = DateTime.ParseExact("12/06/2013","MM/dd/yyyy", new CultureInfo("en-US")),
                Amount = 120,
                BonusName = "Hoa hồng dự án ShinhanLife"
            },
            new BonusDto
{
    BonusId = 29,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("02/06/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // Change the year to 2014
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 30,
    BonusDate = DateTime.ParseExact("03/06/2014","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 31,
    BonusDate = DateTime.ParseExact("04/06/2014","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 32,
    BonusDate = DateTime.ParseExact("05/06/2014","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 33,
    BonusDate = DateTime.ParseExact("06/06/2014","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 34,
    BonusDate = DateTime.ParseExact("07/06/2014","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 35,
    BonusDate = DateTime.ParseExact("08/06/2014","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 36,
    BonusDate = DateTime.ParseExact("09/06/2014","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 37,
    BonusDate = DateTime.ParseExact("10/06/2014","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 38,
    BonusDate = DateTime.ParseExact("11/06/2014","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 39,
    BonusDate = DateTime.ParseExact("12/06/2014","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 40,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("02/06/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // Change the year to 2015
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 41,
    BonusDate = DateTime.ParseExact("03/06/2015","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 42,
    BonusDate = DateTime.ParseExact("04/06/2015","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 43,
    BonusDate = DateTime.ParseExact("05/06/2015","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 44,
    BonusDate = DateTime.ParseExact("06/06/2015","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 45,
    BonusDate = DateTime.ParseExact("07/06/2015","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 46,
    BonusDate = DateTime.ParseExact("08/06/2015","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 47,
    BonusDate = DateTime.ParseExact("09/06/2015","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 48,
    BonusDate = DateTime.ParseExact("10/06/2015","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 49,
    BonusDate = DateTime.ParseExact("11/06/2015","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 50,
    BonusDate = DateTime.ParseExact("12/06/2015","MM/dd/yyyy", new CultureInfo("en-US")),
    Amount = 120,
    BonusName = "Hoa hồng dự án ShinhanLife"
},
new BonusDto
{
    BonusId = 52,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("01/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // January 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 53,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("02/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // February 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 54,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("03/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // March 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 55,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("04/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // April 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 56,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("05/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // May 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 57,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("06/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // June 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 58,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("07/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // July 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 59,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("08/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // August 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 60,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("09/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // September 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 61,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("10/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // October 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 62,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("11/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // November 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 63,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("12/01/2015","MM/dd/yyyy", new CultureInfo("en-US")),  // December 2015
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 64,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("01/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // January 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 65,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("02/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // February 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 66,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("03/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // March 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 67,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("04/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // April 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 68,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("05/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // May 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 69,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("06/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // June 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 70,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("07/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // July 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 71,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("08/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // August 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 72,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("09/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // September 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 73,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("10/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // October 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 74,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("11/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // November 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
},
new BonusDto
{
    BonusId = 75,  // Increase the BonusId
    BonusDate = DateTime.ParseExact("12/01/2014","MM/dd/yyyy", new CultureInfo("en-US")),  // December 2014
    Amount = 850,
    BonusName = "Hoa hồng dự án LimePro"
}
        };
    }
}
