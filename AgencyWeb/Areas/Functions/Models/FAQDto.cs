namespace AgencyWeb.Areas.Functions.Models
{
    public class FAQDto
    {
        public long FAQId { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public long? QuestionTypeId { get; set; }

    }
}
