using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public  class Person
    {
        public long NationalIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirtYear { get; set; }
    }
}
