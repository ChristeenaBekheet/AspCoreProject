using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Required(ErrorMessage = "Title Of The Review Is Required")]
        public string Title { get; set; }

        [Required (ErrorMessage = "Date Of The Review Is Required")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Body Of The Review Is Required")]
        public string Body { get; set; }

        [Required(ErrorMessage = "Rate Of The Review Is Required")]
        public string Rate { get; set; }

        [ForeignKey("Property")]
        public virtual int PropertyID { get; set; }
    }
}
