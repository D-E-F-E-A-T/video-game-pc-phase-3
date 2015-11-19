using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalData
{
    public sealed class Employee
    {
        public Company Employer { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public int OID { get; set; }
    }
}
