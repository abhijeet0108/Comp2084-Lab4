using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            this.Founded = DateTime.Now;
            this.ManufacturerName = "";
            this.URL = "";
            this.PhoneList = new List<Phone>();
        }
        [Key]
        public int ManufacturerID { get; set; }
        public string ManufacturerName { get; set; }
        public DateTime Founded { get; set; }
        public string URL { get; set; }
        public virtual ICollection<Phone> PhoneList { get; set; }
    }
}
