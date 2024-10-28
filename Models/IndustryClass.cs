using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GencCelik.Models
{
    public class IndustryClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int VehicleID { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public float Expense { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
        public string LogUser { get; set; }

        public virtual VehicleClass Vehicle { get; set; }
    }
}
