using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Person
    {

        private string name; //field
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
