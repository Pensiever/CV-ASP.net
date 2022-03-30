using AdoToolbox;
using Microsoft.Extensions.Configuration;
using ModelGlobal_DataAccessLayer.Models;
using ModelGlobal_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DataAccessLayer.Services
{
    public class PersonService : IPersonRepository
    {
        public Guid InstanceID { get; set; } = Guid.NewGuid();

        private string _connectionString;

        private readonly IConfiguration _config;

        public PersonService(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("default");
        }

        internal Person Converter(SqlDataReader reader)
        {
            return new Person
            {
                Id = (int)reader["Id"],
                Name = reader["Name"].ToString(),
                Surname = reader["Surname"].ToString(),
                Adress = reader["Adress"].ToString(),
                Gsm = (int)reader["Gsm"],
                Email = reader["Email"].ToString(),
                Misc = reader["Misc"].ToString(),
                FirstQuality = reader["FirstQuality"].ToString(),
                SecondQuality = reader["SecondQuality"].ToString(),
                ThirdQuality = reader["ThirdQuality"].ToString(),
                FirstFault = reader["FirstFault"].ToString(),
                SecondFault = reader["SecondFault"].ToString(),
                ThirdFault = reader["ThirdFault"].ToString(),
                LastDegree = reader["LastDegree"].ToString()
            };
        }

        public IEnumerable<Person> GetAll()
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM [Personal Info]");

            return cnx.ExecuteReader(cmd, Converter);
        }

        public Person GetById(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM [Personal Info] WHERE Id = @id");
            cmd.AddParameter("id", Id);

            return cnx.ExecuteReader(cmd, Converter).FirstOrDefault();
        }

        public bool Create(Person person)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("AddPerson", true);

            cmd.AddParameter("name", person.Name);
            cmd.AddParameter("surname", person.Surname);
            cmd.AddParameter("adress", person.Adress);
            cmd.AddParameter("gsm", person.Gsm);
            cmd.AddParameter("email", person.Email);
            cmd.AddParameter("misc", person.Misc);
            cmd.AddParameter("firstQuality", person.FirstQuality);
            cmd.AddParameter("secondQuality", person.SecondQuality);
            cmd.AddParameter("thirdQuality", person.ThirdQuality);
            cmd.AddParameter("firstFault", person.FirstFault);
            cmd.AddParameter("secondFault", person.SecondFault);
            cmd.AddParameter("thirdFault", person.ThirdFault);
            cmd.AddParameter("lastDegree", person.LastDegree);
            try
            {
                return cnx.ExecuteNonQuery(cmd) == 1;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(Person person)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("UpdatePerson", true);

            cmd.AddParameter("id", person.Id);
            cmd.AddParameter("name", person.Name);
            cmd.AddParameter("surname", person.Surname);
            cmd.AddParameter("adress", person.Adress);
            cmd.AddParameter("gsm", person.Gsm);
            cmd.AddParameter("email", person.Email);
            cmd.AddParameter("misc", person.Misc);
            cmd.AddParameter("firstQuality", person.FirstQuality);
            cmd.AddParameter("secondQuality", person.SecondQuality);
            cmd.AddParameter("thirdQuality", person.ThirdQuality);
            cmd.AddParameter("firstFault", person.FirstFault);
            cmd.AddParameter("secondFault", person.SecondFault);
            cmd.AddParameter("thirdFault", person.ThirdFault);
            cmd.AddParameter("lastDegree", person.LastDegree);

            return cnx.ExecuteNonQuery(cmd) == 1;
        }

        public bool Delete(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("DeletePerson", true);

            cmd.AddParameter("id", Id);

            return cnx.ExecuteNonQuery(cmd) == 1;
        }
    }
}