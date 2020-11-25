using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Membership
    {
        [Display(Name = "Membership Id")]
        public int MembershipId { get; set; } //PK
        [Display(Name = "Type")]
        public string type { get; set; }
        [DisplayFormat(DataFormatString ="{0:c}")]
        [Display(Name = "Price")]
        public float price { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        

        public List<Users> Userss { get; set; }

    }
}
