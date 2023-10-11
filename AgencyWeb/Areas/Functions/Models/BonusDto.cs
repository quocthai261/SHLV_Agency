namespace AgencyWeb.Areas.Functions.Models
{
    public class BonusDto
    {
        public long BonusId { get; set; }
        public string? BonusName { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? BonusDate { get; set; }

    }
}
