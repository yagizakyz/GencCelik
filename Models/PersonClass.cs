using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GencCelik.Models
{
    public class PersonClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string PName { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string PSurname { get; set; }

        public string Nickname { get; set; }
        public string Password { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public int JobID { get; set; }

        public bool Safety { get; set; }
        public bool Ozlük { get; set; }
        public DateTime StartDateOfWork { get; set; }
        public DateTime DismissalDate { get; set; }
        public bool AnnualPermit { get; set; }

        public bool Deletes { get; set; }
        public string LogUser { get; set; }
        public string Roles { get; set; }

        public virtual JobClass Job { get; set; }

        public List<ShippingClass> ShippingC { get; set; }
        public List<DieselClass> DieselC { get; set; }
        public List<IndustryClass> IndustryC { get; set; }
    }
}
