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
    public class FindSet
    {
        ContextMicro ContextMicro = new ContextMicro();
        public MicroController MicroController (int? Id)
        {
            MicroController microController = ContextMicro.MicCon.Find(Id);
            return microController;
        }
    }
}