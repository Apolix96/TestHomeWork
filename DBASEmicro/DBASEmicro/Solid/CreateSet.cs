using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.Entity;
using DBASEmicro.Models;

namespace DBASEmicro.Solid
{
    public class CreateSet
    {
        ContextMicro ContextMicro = new ContextMicro();
        public void CSete (MicroController microController)
        {
            ContextMicro.MicCon.Add(microController);
            ContextMicro.SaveChanges();
        }
        
    }
}