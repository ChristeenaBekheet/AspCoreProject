using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RealEstate.Models
{
    public enum Country { Egypt, Greece, UK, Turkey, Iraq, Spain, Iran, UAE }
   
    public class Location
    {   
        [Key]
        public int LocationID { get; set; }

        [Required (ErrorMessage = "Address field is required")]
        public string Address { get; set; }

        public string State { get; set; }

        [Required(ErrorMessage = "City field is required")]
        public string City { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Country field is required")]
        public Country Country  { get; set; }
    }
}
