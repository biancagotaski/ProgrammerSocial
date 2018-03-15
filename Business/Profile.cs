using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Profile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BornDay { get; set; }
        public List<Speciality> Specialties { get; set; }
        public List<Preferences> Preferences { get; set; }
    }
}
