using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }//PK
        public int ExerciseId { get; set; } //FK
        public int UserId { get; set; } //FK
        public string day { get; set; }


        public Exercise Exercises { get; set; }
        public Users Users { get; set; }
    }
}
