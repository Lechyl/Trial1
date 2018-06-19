using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]

   public class Hidden
    {
        
        public int ID { get; set; }
        public string Name { get; set; }

        public Hidden(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
