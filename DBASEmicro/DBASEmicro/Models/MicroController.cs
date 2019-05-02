using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DBASEmicro.Models
{
    public class MicroController
    {
        [Key]
        public int IDmicro { get; set; }
        public string nameMicro { get; set; }
        public string manufacture { get; set; }
        public int price { get; set; }
        
        public string Serial { get; set; }
        public string Core { get; set; }
        public string Pamyat { get; set; }
        public string taktovayaChastota { get; set; }

    }
}