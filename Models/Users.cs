using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; } //PK
        public int TrainerId { get; set; } // FK
        public int MembershipId { get; set; } //FK
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string gender { get; set; }

        public Trainer Trainer { get; set; }
        public Membership Membership { get; set; }
        public List<Schedule> Schedule { get; set; }



    }
}
