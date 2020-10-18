using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Membership
    {
        public int membershipId { get; set; }
        public Boolean status { get; set; }
        public int type { get; set; }

        public List<Users> Users { get; set; }

    }
}
