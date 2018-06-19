using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground
{
    class Cars : IEnumerator, IEnumerable
    {
        private Car[] carlist;
        int position = -1;

        //Create internal array in constructor.
        public Cars()
        {
            carlist = new Car[6]
         {
         new Car("Ford",1992),
         new Car("Fiat",1988),
         new Car("Buick",1932),
         new Car("Ford",1932),
         new Car("Dodge",1999),
         new Car("Honda",1977)
         };
        }

        //IEnumerator and IEnumerable require these methods.
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < carlist.Length);
        }

        //IEnumerable
        public void Reset()
        { position = 0; }

        //IEnumerable
        public object Current
        {
            get { return carlist[position]; }
        }
    }      

 }
