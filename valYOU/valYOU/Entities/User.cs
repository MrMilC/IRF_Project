﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valYOU.Entities
{
    public class User
    {
        public string Vezeteknev { get; set; }
        public string KozepsoNev { get; set; }
        public string Keresztnev { get; set; }
        public string Nem { get; set; }
        public string Email { get; set; }
        public decimal Telefonszam { get; set; }
        public DateTime RegisztracioDatuma { get; set; }
    }
}
