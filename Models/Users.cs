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
        [Display(Name = "User ")]
        public int UserId { get; set; } //PK
        [Display(Name ="Trainer Id")]
        public int TrainerId { get; set; } // FK
        [Display(Name = "Membership Id")]
        public int MembershipId { get; set; } //FK
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Age")]
        public int age { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Phone number")]
        public string phoneNumber { get; set; }
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name = "Gender")]
        public string gender { get; set; }

        public Trainer Trainer { get; set; }
        public Membership Membership { get; set; }
       



    }
}
