namespace AgencyWeb.Areas.Functions.Models
{
    public class ContactDto
    {
        public long ContactId { get; set; }
        public string? Coordinate { get; set; }
        public string? Address { get; set; }
        public string? Province { get; set; }
        public string? MapLink { get; set; }
        public long? OfficeTypeId { get; set; }

    }
}
