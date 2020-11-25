using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Trainer
    {
        [Display(Name = "Trainer")]
        public int TrainerId{ get; set; } // PK
        [Display(Name = "Trainer Name")]
        public string trainerName { get; set; }
        [Display(Name = "Gender")]
        public string gender { get; set; }
        [Display(Name = "Trainer Type")]
        public string trainerType { get; set; }      
        public List<Users> Userss { get; set; }
    }
}
