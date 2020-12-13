using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valYOU.Entities
{
    public class User
    {
        public string Nev { get; set; }
        public string Nem { get; set; }
        public decimal PIN_kod { get; set; }
        public string Email { get; set; }
        public decimal Telefonszam { get; set; }
        public DateTime RegisztracioDatuma { get; set; }
    }
}
