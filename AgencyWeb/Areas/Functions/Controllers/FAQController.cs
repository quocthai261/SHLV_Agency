using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.Functions.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.Functions.Controllers
{
    public class FAQController : BaseFunctionController
    {
        public IActionResult Index()
        {
            var list = FAQList;
            return View(list);
        }

        public static List<FAQDto> FAQList = new List<FAQDto>() { 
        new FAQDto
        {
            FAQId = 1,
            Answer = " Quý khách có 21 ngày kể từ ngày nhận được Hợp đồng lần đầu tiên để cân nhắc Hợp đồng này có phù hợp với nhu cầu của mình hay không. Hợp đồng vẫn có hiệu lực trong suốt Thời gian cân nhắc.\r\n\r\nTrong thời gian này, Quý khách cần kiểm tra lại toàn bộ Hợp đồng, bao gồm các thông tin của Quý khách đã kê khai trong Chứng nhận bảo hiểm, Hồ sơ yêu cầu bảo hiểm để đảm bảo các thông tin được ghi nhận đầy đủ và chính xác. Nếu Quý khách thấy bất kỳ thông tin nào chưa được ghi nhận đầy đủ hay chính xác, Quý khách cần thông báo ngay cho Shinhan Life Việt Nam để được xác nhận và điều chỉnh kịp thời.\r\n\r\nTrong thời gian cân nhắc của Hợp đồng, nếu Quý khách quyết định không tiếp tục duy trì hợp đồng, Quý khách có thể gửi yêu cầu hủy Hợp đồng cho Shinhan Life Việt Nam để nhận lại khoản phí bảo hiểm ban đầu đã đóng, không có lãi, sau khi Shinhan Life Việt Nam đã khấu trừ các chi phí kiểm tra sức khỏe, nếu có.\r\n\r\nNgày chấm dứt hiệu lực hợp đồng được Shinhan Life Việt Nam xác nhận trên thư xác nhận chấm dứt Hợp đồng trong thời gian cân nhắc.",
            Question = "Thời hạn cân nhắc là gì?"
            
        },
        new FAQDto
        {
            FAQId = 2,
            Question = "Làm thế nào để hủy bỏ Hợp đồng bảo hiểm trong thời hạn cân nhắc?",
            Answer = "Tải Phiếu yêu cầu điều chỉnh – Mẫu PS3, điền đầy đủ thông tin và gửi về Shinhan Life Việt Nam bằng cách:\r\n\r\n– Thông qua Tư vấn tài chính phục vụ hợp đồng bảo hiểm của Quý khách; hoặc\r\n\r\n– Nộp trực tiếp tại bất kỳ Văn phòng nào của Shinhan Life Việt Nam tại các tỉnh/thành trên cả nước; hoặc\r\n\r\nGửi thư về:\r\n\r\nShinhan Life Việt Nam – Phòng Quản lý Hợp đồng\r\n\r\nTầng 20, Tòa nhà Friendship\r\n\r\n31 Lê Duẩn, Phường Bến Nghé, Quận 1, Tp Hồ Chí Minh.\r\n\r\nQuý khách cũng có thể liên hệ với Shinhan Life Việt Nam theo số điện thoại 1900998800, hoặc email: chamsockhachhang@shinhan.com để được hướng dẫn chi tiết.",
        },
        new FAQDto
        {
            FAQId = 3,
            Question ="Khi nào Hợp đồng bảo hiểm của tôi bị mất hiệu lực?",
            Answer = "Quý khách chưa đóng phí bảo hiểm đến hạn sau khi kết thúc thời gian gia hạn đóng phí 60 ngày\r\n\r\nVui lòng liên hệ Tổng đài Shinhan Life Việt Nam 1900998800 để được hỗ trợ."
        },
        new FAQDto {
                FAQId = 4,
                Question = "Thời gian khôi phục hiệu lực Hợp đồng bảo hiểm là bao lâu sau khi Hợp đồng bị mất hiệu lực?",
                Answer ="Quý khách có thể yêu cầu khôi phục hiệu lực hợp đồng trong vòng 2 năm (24 tháng) kể từ ngày Hợp đồng mất hiệu lực và phải trước Ngày kết thúc thời hạn hợp đồng.\r\n\r\nChúng tôi khuyến khích Quý khách khôi phục hiệu lực hợp đồng sớm để tiếp tục được bảo vệ."
            },
        new FAQDto
        {
            FAQId= 5,
            Question ="Thủ tục khôi phục hiệu lực như thế nào?",
            Answer = "Quý khách vui lòng đóng đầy đủ các khoản phí để khôi phục và có thể chọn một trong những phương thức dưới đây để gửi yêu cầu Khôi phục hiệu lực đến Shinhan Life Việt Nam:\r\n\r\n– Thông qua Tư vấn tài chính phục vụ hợp đồng bảo hiểm của Quý khách; hoặc\r\n\r\n– Nộp trực tiếp tại bất kỳ Văn phòng nào của Shinhan Life Việt Nam tại các tỉnh/thành trên cả nước; hoặc\r\n\r\nGửi thư về:\r\n\r\nShinhan Life Việt Nam – Phòng Quản lý Hợp đồng\r\n\r\nTầng 20, Tòa nhà Friendship\r\n\r\n31 Lê Duẩn, Phường Bến Nghé, Quận 1, Tp Hồ Chí Minh.\r\n\r\nQuý khách cũng có thể liên hệ với Shinhan Life Việt Nam theo số điện thoại 1900998800, hoặc email: chamsockhachhang@shinhan.com để được hướng dẫn chi tiết."
        }
        };
    }
}
