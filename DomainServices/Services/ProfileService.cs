using Business;
using Business.Interfaces.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices
{
    public class ProfileService : IProfileRepository
    {
        private IProfileRepository _profileRepository;

        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        public void Add(Profile profile)
        {
            _profileRepository.Add(profile);
        }

        public IEnumerable<Profile> GetAll()
        {
            return _profileRepository.GetAll(); 
        }
    }
}
