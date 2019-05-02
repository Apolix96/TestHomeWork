using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace DBASEmicro.Models
{
    public class ContextMicro : DbContext
    {
        public DbSet<MicroController> MicCon { get; set; }
        public DbSet<Purchase> PurshSE { get; set; }
        
    }
}