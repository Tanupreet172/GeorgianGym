using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Users
    {   public int userId { get; set; } //PK
        public int trainerId { get; set; } // FK
        public int membershipId { get; set; } //FK
        public string name{ get; set; }
        public int age { get; set; }
        public int email { get; set; }
        public string phoneNumber { get; set; }
        public int address { get; set; }
        public int gender { get; set; }

        public Trainer Trainer { get; set; }
        public Membership Membership { get; set; }
        public Schedule Schedule { get; set; }

    }
}
