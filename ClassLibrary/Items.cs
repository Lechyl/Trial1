using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]

    public class Items : IEnumerable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Items(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
