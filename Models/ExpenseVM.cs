using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GencCelik.Models
{
    public class ExpenseVM
    {
        public List<DieselClass> Diesels { get; set; }
        public List<IndustryClass> Industries { get; set; }
        public ShippingClass Shippings { get; set; }
    }
}
