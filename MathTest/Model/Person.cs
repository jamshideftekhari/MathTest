using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTest.Model
{
    public class Person
    {
        public int ID { get; set; } //between 1000 and 9999
        public string Name { get; set; } // 4 character
        public int Phone { get; set; }  // 8 digits
        
        public Person() { }

        public Person(int id, string name, int phone)
        {
            if ((9999<id || id<1000)||(name.Length<4)||(phone.ToString().Length==8))
                throw  new ArgumentOutOfRangeException();
        }
    }
}
