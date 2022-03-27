using ModelGlobal_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DataAccessLayer.Repositories
{
    public interface ISkillRepository
    {
        IEnumerable<TechSkill> GetByCV(int Id);
        bool Create(TechSkill skill);
        bool Delete(int Id);
    }
}
