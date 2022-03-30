using Microsoft.AspNetCore.Mvc;
using ModelGlobal_DataAccessLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace CV_ASP.net.Models
{
    public class SkillForm
    {
        [HiddenInput]
        public int Id { get; set; }
        public string? Skill { get; set; }
        [Required]
        public int CVId { get; set; }
        public IEnumerable<Person>? CVList { get; set; }
    }
}
