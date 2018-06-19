using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            Console.WriteLine("\nInternal Collection (Unsorted - IEnumerable,Enumerator)\n");
            foreach (Car car in cars)
                Console.WriteLine(car.Make + "\t\t" + car.Year);

            Console.ReadLine();
        }
    }
}
