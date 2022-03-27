using ModelGlobal_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DataAccessLayer.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person GetById(int Id);
        bool Create(Person person);
        bool Update(Person person);
        bool Delete(int Id);
        Guid InstanceID { get; set; }
    }
}
