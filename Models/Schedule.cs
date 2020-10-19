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
       
        public int ScheduleId { get; set; }//PK

        public int UsersId { get; set; }//FK

        public string exercise { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public Users Users { get; set; }
    }
}
