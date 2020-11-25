using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianGym.Models
{
    public class Product
    {
        public int ProductId { get; set; } //PK
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0.01, 999999)]
        public double Price { get; set; }
    }
}
