using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.Models
{
    public enum PropertyType { Apartment , House , Land , SingelFamily, Bungalow, Villa}
    public enum PropertyStatus { ForSale, ForRent, Saled, Rented }

    public class Property
    {
        [Key]
        public int PropertyID { get; set; }

        [Required(ErrorMessage = "Title Type field is required")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Property Type field is required")]
        [Display(Name = "Property Type")]
        public PropertyType Type { get; set; }

        [Required(ErrorMessage = "Property Status field is required")]
        [Display (Name = "Property Status")]
        public PropertyStatus Status { get; set; }

        [Required(ErrorMessage = "Price field is required")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "Rooms field is required")]
        [Range(1, 10)]
        public int Rooms { get; set; }

        [Required(ErrorMessage = "Location field is required")]
        public Location Location { get; set; }

        [Required(ErrorMessage = "Bathrooms field is required")]
        [Range(1, 5)]
        public int Bathrooms { get; set; }

        [Required(ErrorMessage = "Area Size field is required")]
        public double AreaSize { get; set; }

        [DataType(DataType.DateTime,ErrorMessage = "YearBuilt must be in correct Format")]
        [Required (ErrorMessage = "YearBuilt field is required")]
        public DateTime YearBuilt { get; set; }

        public Image[] images { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
