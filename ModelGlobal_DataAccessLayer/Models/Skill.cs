using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DataAccessLayer.Models
{
    public class TechSkill
    {
        public int Id { get; set; }
        public string? Skill { get; set; }
        public int CVId { get; set; }
    }
}
