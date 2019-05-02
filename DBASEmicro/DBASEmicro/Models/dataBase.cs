using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace DBASEmicro.Models
{
    public class dataBase : DropCreateDatabaseAlways<ContextMicro>
    {
        protected override void Seed(ContextMicro context)
        {

            context.MicCon.Add(new MicroController { IDmicro = 1,nameMicro = "AT32UC3L064-AUT", manufacture = "Atmel", price = 480, Core ="avr", Pamyat ="flash", Serial ="avr32uc3i", taktovayaChastota="50mgz" });
            context.MicCon.Add(new MicroController { IDmicro = 1,nameMicro = "AT32UC3L064-AUT", manufacture = "Atmel", price = 480, Core ="avr", Pamyat ="flash", Serial ="avr32uc3i", taktovayaChastota="50mgz" });
            context.MicCon.Add(new MicroController { IDmicro = 1,nameMicro = "AT32UC3L064-AUT", manufacture = "Atmel", price = 480, Core ="avr", Pamyat ="flash", Serial ="avr32uc3i", taktovayaChastota="50mgz" });
           
            
            base.Seed(context); 
        }

    }
}