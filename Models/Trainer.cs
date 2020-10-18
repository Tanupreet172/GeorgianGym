using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Trainer
    {
        public int TrainerId{ get; set; } // PK
        public string trainerName { get; set; }
        public string gender { get; set; }
        public string trainerType { get; set; }      
        public List<Users> Userss { get; set; }
    }
}
