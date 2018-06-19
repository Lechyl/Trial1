using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]

   public class Player
    {
        public List<Inventory> inventoryitems { get; set; }
        public List<HiddenObjectInventory> hiddenObjectInventories { get; set; }
        
        public Player()
        {
            
            inventoryitems = new List<Inventory>();
            hiddenObjectInventories = new List<HiddenObjectInventory>();
        }

    }
}
