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
    public class SkillService : ISkillRepository
    {
        private string _connectionString;

        private readonly IConfiguration _config;

        public SkillService(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("default");
        }

        internal TechSkill Converter(SqlDataReader reader)
        {
            return new TechSkill
            {
                Id = (int)reader["Id"],
                Skill = (string?)reader["Skill"],
                CVId = (int)reader["CVId"]
            };
        }

        public IEnumerable<TechSkill> GetByCV(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM [Technical Skills] WHERE CVId = @id");
            cmd.AddParameter("id", Id);

            return cnx.ExecuteReader(cmd, Converter);
        }

        public bool Create(TechSkill skill)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("AddSkill", true);

            cmd.AddParameter("skill", skill.Skill);
            cmd.AddParameter("cvId", skill.CVId);
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

            Command cmd = new Command("DeleteSkill", true);

            cmd.AddParameter("id", Id);

            return cnx.ExecuteNonQuery(cmd) == 1;
        }
    }
}