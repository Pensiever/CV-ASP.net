using ModelGlobal_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DataAccessLayer.Repositories
{
    public interface IProfessionRepository
    {
        IEnumerable<Profession> GetByCV(int Id);
        bool Create(Profession profession);
        bool Delete(int Id);
    }
}
