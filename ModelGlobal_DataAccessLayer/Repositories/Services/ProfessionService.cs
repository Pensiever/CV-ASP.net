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
    public class ProfessionService : IProfessionRepository
    {
        private string _connectionString;

        private readonly IConfiguration _config;

        public ProfessionService(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("default");
        }

        internal Profession Converter(SqlDataReader reader)
        {
            return new Profession
            {
                Id = (int)reader["Id"],
                PeriodBegin = (DateTime?)reader["PeriodBegin"],
                PeriodEnd = (DateTime?)reader["PeriodEnd"],
                Employer = (string?)reader["Employer"],
                Position = (string?)reader["Position"],
                CVId = (int?)reader["CV Id"]
            };
        }

        public IEnumerable<Profession> GetAll()
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM [Professional Experience]");

            return cnx.ExecuteReader(cmd, Converter);
        }

        public IEnumerable<Profession> GetByCV(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM [Professional Experience] WHERE [CV Id] = @id");
            cmd.AddParameter("id", Id);

            return cnx.ExecuteReader(cmd, Converter);
        }

        public bool Create(Profession profession)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("AddProfession", true);

            cmd.AddParameter("periodBegin", profession.PeriodBegin);
            cmd.AddParameter("periodEnd", profession.PeriodEnd);
            cmd.AddParameter("employer", profession.Employer);
            cmd.AddParameter("position", profession.Position);
            cmd.AddParameter("cvId", profession.CVId);
            try
            {
                return cnx.ExecuteNonQuery(cmd) == 1;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public bool Delete(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("DeleteProfession", true);

            cmd.AddParameter("id", Id);

            return cnx.ExecuteNonQuery(cmd) == 1;
        }
    }
}