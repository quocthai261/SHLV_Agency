namespace AgencyWeb.Areas.Functions.Models
{
    public class NewsAndEventDto
    {
        public long NewsAndEventId { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string? Image {  get; set; }
    }
}
