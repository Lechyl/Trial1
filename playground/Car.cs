using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground
{
   public class Car
    {
        private int _year;
        private string _make;

        public Car(string make, int year)
        {
            _make = make;
            _year = year;
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

    }
}


