using Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Entities;

namespace Data.Context
{
    public class SocialNetworkContext : DbContext
    {
        private DbSet<Profile> profiles { get; set; }

        public SocialNetworkContext()
            : base (Data.Properties.Settings.Default.DbConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
