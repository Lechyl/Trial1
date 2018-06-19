using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]

   public class Inventory
    {  
       public Items Details { get; set; }
   


        public Inventory(Items details)
        {
            Details = details;

           
        }
    }
}
