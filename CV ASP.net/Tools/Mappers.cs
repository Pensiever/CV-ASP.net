using CV_ASP.net.Models;
using DAL = ModelGlobal_DataAccessLayer.Models;
using ASP = CV_ASP.net.Models;

namespace CV_ASP.net.Tools
{
    public static class Mappers
    {
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
