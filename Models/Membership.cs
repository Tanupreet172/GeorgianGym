using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Membership
    {
        public int MembershipId { get; set; } //PK
        public string type { get; set; }
        [DisplayFormat(DataFormatString ="{0:c}")]
        public float price { get; set; }
        public string description { get; set; }
        

        public List<Users> Userss { get; set; }

    }
}
