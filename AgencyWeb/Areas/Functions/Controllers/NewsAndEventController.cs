using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.Functions.Models;
using AgencyWeb.Services;
using Microsoft.AspNetCore.Mvc;


namespace AgencyWeb.Areas.Functions.Controllers
{
    public class NewsAndEventController : BaseFunctionController
    {
        private readonly IApiService _apiService;

        public IActionResult Index()
        {
            var list = GetNewsAndEventList();
            return View(list);
        }


        public IActionResult NewsAndEventDetail(long id)
        {
            var model = newsAndEventList.Where(m => m.NewsAndEventId == id).First();
            return View(model);
        }
        public NewsAndEventController(IApiService apiService)
        {
            //_client = new HttpClient();
            //_client.BaseAddress = baseAddress;
            _apiService = apiService;
        }

        public List<NewsAndEventDto> GetNewsAndEventList()
        {
            var list = newsAndEventList.ToList();
            return list;
        }

        
        public static List<NewsAndEventDto> newsAndEventList = new List<NewsAndEventDto>()
        {
            new NewsAndEventDto
            {
                NewsAndEventId = 1,
                Title = "SHINHAN LIFE VIỆT NAM TIẾP TỤC ĐỒNG HÀNH CÙNG BỆNH NHI UNG THƯ MÁU TRONG DỊP TẾT ĐOÀN VIÊN",
                PublishedDate = DateTime.Now,
                Summary = "TP. Hồ Chí Minh, ngày 15/9/2023, Shinhan Life Việt Nam tiếp tục đồng hành cùng Bệnh viện Nhi đồng Thành Phố hỗ trợ cho các bệnh nhi ung thư máu có hoàn cảnh khó khăn nhân dịp Tết Trung thu.",
                Description = "",
                Image = "https://shinhanlifevn.com.vn/wp-content/uploads/2023/10/Picture1-1-300x200.png"
            },
            new NewsAndEventDto
            {
                NewsAndEventId = 2,
                Title = "SHINHAN LIFE VIỆT NAM BỔ NHIỆM TÂN CHỦ TỊCH HỘI ĐỒNG THÀNH VIÊN KIÊM TỔNG GIÁM ĐỐC",
                PublishedDate = DateTime.Now,
                Summary = "Được sự chấp thuận của Bộ Tài chính theo Công văn số 8362/BTC-QLBH, ngày 08/08/2023, Công ty TNHH Bảo hiểm Shinhan Life Việt Nam chính thức bổ nhiệm ông Bae Seung Jun làm tân Chủ tịch Hội đồng Thành viên kiêm Tổng Giám đốc Công ty kể từ ngày 08/08/2023, thay cho ông Lee EuiChul.",
                Description = "",
                Image = "https://shinhanlifevn.com.vn/wp-content/uploads/2023/08/LSN1773-1536x1025.jpg"
            },
            new NewsAndEventDto
            {
                NewsAndEventId = 3,
                Title = "SHINHAN LIFE VIỆT NAM HỢP TÁC TỔ CHỨC CHƯƠNG TRÌNH GIÁO DỤC ILEAD DÀNH CHO THANH THIẾU NIÊN LÀNG TRẺ EM SOS VIỆT NAM",
                PublishedDate = DateTime.Now,
                Summary = "Tháng 6/2023, Công ty TNHH Bảo hiểm Shinhan Life Việt Nam (Shinhan Life Việt Nam) hợp tác cùng Công ty TNHH BNJ Việt Nam (BNJ) thực hiện chương trình giáo dục iLead dành cho thanh thiếu niên tại Làng trẻ em SOS Việt Nam.",
                Description = "",
                Image = "https://shinhanlifevn.com.vn/wp-content/uploads/2023/07/KHH_5040-1536x1022.jpg "
            },
            new NewsAndEventDto
            {
                NewsAndEventId = 4,
                Title = "SHINHAN LIFE VIỆT NAM TẶNG 1.300 SUẤT ĂN TRƯA CHO BỆNH NHI BỆNH VIỆN NHI ĐỒNG 2",
                PublishedDate = DateTime.Now,
                Summary = "Thành phố Hồ Chí Minh, ngày 30/5/2023, Nhân dịp Quốc tế Thiếu nhi 1/6, đại diện Ban Giám đốc và nhân viên Shinhan Life Việt Nam " +
                "đã đến thăm và tặng quà cho các bệnh nhi tại Bệnh viện nhi đồng 2 TP.HCM. Cụ thể, Shinhan Life Việt Nam tổ chức hoạt động trao tặng 1.300 suất ăn trưa cho các bệnh nhi và người nhà bệnh nhân. Ngoài ra, đại diện công ty cũng ghé thăm và gửi tặng 200 suất quà cho các em nhỏ đang điều trị tại khoa Ung Bướu của bệnh viện. Đây là một trong những hoạt động tiếp nối nỗ lực chia sẻ vì cộng đồng thường niên của công ty tại Việt Nam.",
                Description = "",
                Image = "https://shinhanlifevn.com.vn/wp-content/uploads/2023/07/LSN_3861-1536x1025.jpg"
            }
        };
    }
}
