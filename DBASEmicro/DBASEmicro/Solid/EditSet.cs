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
    public class EditSet
    {
        ContextMicro ContextMicro = new ContextMicro();
        FindSet findSet = new FindSet();

        public void Edit(MicroController microController)
        {
            ContextMicro.Entry(microController).State = EntityState.Modified;
            ContextMicro.SaveChanges();
        }

       
    }
}