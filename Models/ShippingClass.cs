using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GencCelik.Models
{
    public class ShippingClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int Navlun { get; set; }
        public string Kind { get; set; }

        [Column(TypeName = "nvarchar(17)")]
        public string Invoice { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int VehicleID { get; set; }

        public string BookingNo { get; set; }
        public string Container { get; set; }
        public string Description { get; set; }
        public String Date { get; set; }
        public string LogUser { get; set; }

        public virtual PersonClass Person { get; set; }
        public virtual VehicleClass Vehicle { get; set; }
    }
}
