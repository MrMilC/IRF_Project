using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valYOU.Entities
{
    public class User
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public decimal PhoneNumber { get; set; }
        public DateTime RegistryDate { get; set; }
    }
}
