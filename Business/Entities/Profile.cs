using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Profile : EntityBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string ImageProfile { get; set; }
    }
}


//public List<Speciality> Specialties { get; set; }
//public List<Preferences> Preferences { get; set; }
//public ICollection Follows { get; set; }
//public Posts Post { get; set; }