namespace CV_ASP.net.Models
{
    public class Profession
    {
        public int Id { get; set; }
        public DateTime? PeriodBegin { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public string? Employer { get; set; }
        public string? Position { get; set; }
        public int? CVId { get; set; }
    }
}