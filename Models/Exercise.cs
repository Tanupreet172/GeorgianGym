using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Exercise
    {

        public int ExerciseId{ get; set; } // PK
        public string exercise { get; set; }

        public List<Schedule> Schedules { get; set; }
    }
}
