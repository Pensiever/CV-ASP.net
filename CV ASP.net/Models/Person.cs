namespace CV_ASP.net.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public int Gsm { get; set; }
        public string Email { get; set; }
        public string? Misc { get; set; }
        public string FirstQuality { get; set; }
        public string SecondQuality { get; set; }
        public string ThirdQuality { get; set; }
        public string FirstFault { get; set; }
        public string SecondFault { get; set; }
        public string ThirdFault { get; set; }
        public string? LastDegree { get; set; }
    }
}
