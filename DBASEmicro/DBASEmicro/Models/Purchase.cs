using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DBASEmicro.Models
{
    public class Purchase
    {
        [Key]
        public int IDpurchase { get; set; }
        public string namePurchase { get; set; }
        public int MicroID { get; set; }
        public string Address { get; set; }
        public DateTime date { get; set; }
    }
}