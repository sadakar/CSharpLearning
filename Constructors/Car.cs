using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Car
    {
        public string model;
        public Car() // constructor to initialize the fields. 
        {
            model = "Mustang";
        }
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
            Console.ReadLine();
        }
    }
}
