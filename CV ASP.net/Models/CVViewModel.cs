namespace CV_ASP.net.Models
{
    public class CVViewModel
    {
        public Person Personal { get; set; }
        public IEnumerable<TechSkill> Skills { get; set; }
        public IEnumerable<Profession> Professions { get; set; }
    }
}
