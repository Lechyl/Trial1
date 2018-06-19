using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]

   public class HiddenObjectInventory
    {
        public Hidden HiddenObject { get; set; }

        public HiddenObjectInventory(Hidden hiddenObject)
        {
            HiddenObject = hiddenObject;
        }
    }
}
