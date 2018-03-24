using Business;
using Business.Interfaces.Respositories;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        SocialNetworkContext _socialNetworkContext;
        
        private DbSet<Profile> _dbSet;

        public ProfileRepository(SocialNetworkContext socialNetworkContext)
        {
            _socialNetworkContext = socialNetworkContext;
            _dbSet = socialNetworkContext.Set<Profile>();
        }

        public void Add(Profile profile)
        {
            _dbSet.Add(profile);
        }

        public void Delete(Profile entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Profile> GetAll()
        {
            return _dbSet;
        }

        public void Update(Profile entity)
        {
            throw new NotImplementedException();
        }
    }
}
