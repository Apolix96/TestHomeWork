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
    public class DeleteSet
    {
        ContextMicro contextMicro = new ContextMicro();
        FindSet findSet = new FindSet();

        public void Delete(int? Id)
        {
            MicroController microController = contextMicro.MicCon.Find(Id);
            contextMicro.MicCon.Remove(microController);
            contextMicro.SaveChanges();
            
        }
    }
}