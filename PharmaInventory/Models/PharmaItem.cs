using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PharmaInventory.Models
{
    public class PharmaItem
    {
        [Key]
        public int Id { get; set; }
        public string MedName { get; set; }
        public string MedDescription { get; set; }
        public DateTime MedManufactureDate { get; set; }
        public DateTime MedExpireDate { get; set; }
       
    }
}
