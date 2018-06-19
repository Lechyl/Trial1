using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]

   public class Weapon : Items
    {
        public Weapon(int id, string name, string description) : base( id,  name,  description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
