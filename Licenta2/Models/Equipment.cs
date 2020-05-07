using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Licenta2.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public Category Category { get; set; }

        [Display(Name = "Category")]
        public byte CategoryId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "NumberInStock")]
        public byte NumberInStock { get; set; }

    }
}