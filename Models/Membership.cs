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
        public Boolean status { get; set; }
        public string type { get; set; }

        public List<Users> Userss { get; set; }

    }
}
