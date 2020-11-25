using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Schedule
    {
        [Display(Name = "Schedule Id")]
        public int ScheduleId { get; set; }//PK

        [Display(Name = "User Id")]
        public int UsersId { get; set; }//FK
        [Display(Name = "Exercise")]
        public string exercise { get; set; }
        [Display(Name = "Start time")]
        public DateTime startTime { get; set; }
        [Display(Name = "End time")]
        public DateTime endTime { get; set; }
        public Users Users { get; set; }
    }
}
