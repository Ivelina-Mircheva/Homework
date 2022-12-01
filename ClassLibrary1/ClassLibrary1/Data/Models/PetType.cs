﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data.Models
{
    class PetType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
