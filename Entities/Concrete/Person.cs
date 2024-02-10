using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; } 
        public long NationalIdentity {  get; set; }
        public int DateOfBirthYear { get; set; }

    }
}
