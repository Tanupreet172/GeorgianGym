using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Schedule
    {
        public int exerciseId { get; set; } //FK
        public int userId { get; set; } //FK
        public string day { get; set; }
        public List<Users> Users { get; set; }
        public List<Exercise> Exercise { get; set; }
    }
}
