using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Licenta2.Models;

namespace Licenta2.ViewModels
{
    public class EquipmentFormViewModel
    {
        public IEnumerable<Category> Category { get; set; }
        public Equipment Equipment { get; set; }
        
        public string Nume
        {
            get
            {
                if (Equipment != null && Equipment.Id != 0)
                    return "Edit Equipment";
                return "New Equipment";
            }
        }
    }
}