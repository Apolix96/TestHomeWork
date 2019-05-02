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
    public class ExtractSet
    {

        ContextMicro contextMicro = new ContextMicro();
        public IEnumerable<MicroController> DataUse()
        {
            IEnumerable<MicroController> microControllers = contextMicro.MicCon;
            return microControllers;
        }
        
    }
}