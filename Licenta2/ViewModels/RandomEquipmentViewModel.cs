using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Licenta2.Models;

namespace Licenta2.ViewModels
{
    public class RandomEquipmentViewModel
    {
        public Equipment Equipment { get; set; }
        public List<Customer> Customers { get; set; }
    }
}