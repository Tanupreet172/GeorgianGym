using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Trainer
    {
        public int trainerId{ get; set; } // PK
        public string trainerName { get; set; }
        public string gender { get; set; }
        public int trainerType { get; set; }
        
        public List<Users> Users { get; set; }
    }
}
