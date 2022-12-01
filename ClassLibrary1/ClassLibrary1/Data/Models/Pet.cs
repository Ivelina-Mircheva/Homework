using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data.Models
{
    class Pet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PetId { get; set; }
        public string PetName { get; set; }
        public PetType Type { get; set; }
        public int Age { get; set; }

    }
}
