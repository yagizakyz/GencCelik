using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GencCelik.Models
{
    public class VehicleClass
    {
        [Key]
        public int Id { get; set; }

        public string Plate { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string VehicleBrand { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string VehicleModel { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public DateTime VizeDate { get; set; }

        [Column(TypeName = "nvarchar(14)")]
        public string Rent { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string RentInvoice { get; set; }

        public bool Deletes { get; set; }
        public string LogUser { get; set; }

        public List<ShippingClass> ShippingC { get; set; }
        public List<DieselClass> DieselC { get; set; }
        public List<IndustryClass> IndustryC { get; set; }
    }
}
