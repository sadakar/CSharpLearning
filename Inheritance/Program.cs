using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object for derived class
            Car myCar = new Car();

            // Call Base class method
            myCar.honk();

            // Access Base class field
            Console.WriteLine("Brand:="+myCar.brand);

            // Access Derived class field
            Console.WriteLine("Mode:="+myCar.modelName);

            Console.ReadLine();
        }
    }
}
