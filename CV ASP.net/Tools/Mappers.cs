using CV_ASP.net.Models;
using DAL = ModelGlobal_DataAccessLayer.Models;
using ASP = CV_ASP.net.Models;

namespace CV_ASP.net.Tools
{
    public static class Mappers
    {
        public static ASP.Person ToASP(this DAL.Person p)
        {
            return new Person
            {
                Id = p.Id,
                Name = p.Name,
                Surname = p.Surname,
                Adress = p.Adress,
                Gsm = p.Gsm,
                Email = p.Email,
                Misc = p.Misc,
                FirstQuality = p.FirstQuality,
                SecondQuality = p.SecondQuality,
                ThirdQuality = p.ThirdQuality,
                FirstFault = p.FirstFault,
                SecondFault = p.SecondFault,
                ThirdFault = p.ThirdFault,
                LastDegree = p.LastDegree
            };
        }

        public static DAL.Person FormToDAL(this PersonForm f)
        {
            return new DAL.Person
            {
                Id = f.Id,
                Name = f.Name,
                Surname = f.Surname,
                Adress = f.Adress,
                Gsm = f.Gsm,
                Email = f.Email,
                Misc = f.Misc,
                FirstQuality = f.FirstQuality,
                SecondQuality = f.SecondQuality,
                ThirdQuality = f.ThirdQuality,
                FirstFault = f.FirstFault,
                SecondFault = f.SecondFault,
                ThirdFault = f.ThirdFault,
                LastDegree = f.LastDegree
            };
        }

        public static PersonForm ToFormView(this DAL.Person p)
        {
            return new PersonForm
            {
                Id = p.Id,
                Name = p.Name,
                Surname = p.Surname,
                Adress = p.Adress,
                Gsm = p.Gsm,
                Email = p.Email,
                Misc = p.Misc,
                FirstQuality = p.FirstQuality,
                SecondQuality = p.SecondQuality,
                ThirdQuality = p.ThirdQuality,
                FirstFault = p.FirstFault,
                SecondFault = p.SecondFault,
                ThirdFault = p.ThirdFault,
                LastDegree = p.LastDegree
            };
        }

        public static ASP.Profession ToASP(this DAL.Profession p)
        {
            return new Profession
            {
                Id = p.Id,
                PeriodBegin = p.PeriodBegin,
                PeriodEnd = p.PeriodEnd,
                Employer = p.Employer,
                Position = p.Position,
                CVId = p.CVId
            };
        }

        public static DAL.Profession FormToDAL(this ProfessionForm f)
        {
            return new DAL.Profession
            {
                Id = f.Id,
                PeriodBegin = f.PeriodBegin,
                PeriodEnd = f.PeriodEnd,
                Employer = f.Employer,
                Position = f.Position,
                CVId = f.CVId
            };
        }

        public static ProfessionForm ToFormView(this DAL.Profession p)
        {
            return new ProfessionForm
            {
                Id = p.Id,
                PeriodBegin = p.PeriodBegin,
                PeriodEnd = p.PeriodEnd,
                Employer = p.Employer,
                Position = p.Position,
                CVId = p.CVId
            };
        }

        public static ASP.TechSkill ToASP(this DAL.TechSkill s)
        {
            return new TechSkill
            {
                Id = s.Id,
                Skill = s.Skill,
                CVId = s.CVId
            };
        }

        public static DAL.TechSkill FormToDAL(this SkillForm f)
        {
            return new DAL.TechSkill
            {
                Id = f.Id,
                Skill = f.Skill,
                CVId = f.CVId
            };
        }

        public static SkillForm ToFormView(this DAL.TechSkill s)
        {
            return new SkillForm
            {
                Id = s.Id,
                Skill = s.Skill,
                CVId = s.CVId
            };
        }

        public static ASP.AppUser ToASP(this DAL.AppUser user)
        {
            return new ASP.AppUser
            {
                Id = user.Id,
                Email = user.Email,
                ScreenName = user.Email.Split("@")[0]
            };
        }
    }
}
