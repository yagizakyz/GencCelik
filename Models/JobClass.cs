using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GencCelik.Models
{
    public class JobClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string JName { get; set; }

        public List<PersonClass> PersonC { get; set; }
    }
}
