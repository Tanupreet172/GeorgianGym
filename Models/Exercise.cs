using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Exercise
    {
        public int exerciseId{ get; set; } // PK
        public string exercise { get; set; }

        public Schedule Schedule { get; set; }
    }
}
