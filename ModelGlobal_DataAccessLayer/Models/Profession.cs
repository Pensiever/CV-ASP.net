using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DataAccessLayer.Models
{
    public class Profession
    {
        public int Id { get; set; }
        public DateOnly? PeriodBegin { get; set; }
        public DateOnly? PeriodEnd { get; set; }
        public string? Employer { get; set; }
        public string? Position { get; set; }
        public int? CVId { get; set; }
    }
}
