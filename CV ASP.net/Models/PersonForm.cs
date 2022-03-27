using Microsoft.AspNetCore.Mvc;
using ModelGlobal_DataAccessLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace CV_ASP.net.Models
{
    public class PersonForm
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        [Phone]
        public int Gsm { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string? Misc { get; set; }
        [Required]
        public string FirstQuality { get; set; }
        [Required]
        public string SecondQuality { get; set; }
        [Required]
        public string ThirdQuality { get; set; }
        [Required]
        public string FirstFault { get; set; }
        [Required]
        public string SecondFault { get; set; }
        [Required]
        public string ThirdFault { get; set; }
        public string? LastDegree { get; set; }
    }
}
