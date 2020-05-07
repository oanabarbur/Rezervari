using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Licenta2.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInWeek { get; set; }
        public byte DiscountRate { get; set; }
        [Required]
        public string Name { get; set; }
    
    }
}