using Microsoft.AspNetCore.Mvc;
using ModelGlobal_DataAccessLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace CV_ASP.net.Models
{
    public class ProfessionForm
    {
        [HiddenInput]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PeriodBegin { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PeriodEnd { get; set; }
        public string? Employer { get; set; }
        public string? Position { get; set; }
        public int? CVId { get; set; }
        public IEnumerable<Person>? CVList { get; set; }
    }
}
