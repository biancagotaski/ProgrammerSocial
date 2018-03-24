using Business;
using Business.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ApplicationServices
    {
        private IProfileService _profileServices;

        public ApplicationServices(IProfileService profileServices)
        {
            _profileServices = profileServices;
        }

        public void AddNewProfile (Profile profile)
        {
            _profileServices.CreateProfile(profile);
        }

        public IEnumerable<Profile> GetAllProfiles()
        {
            return _profileServices.GetAllProfiles();
        }

    }
}
