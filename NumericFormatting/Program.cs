using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 1234D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0.0}",value));
        }
    }
}
