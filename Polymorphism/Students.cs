using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Students : Teacher
    {
        public override void StudentsTalk()
        {
            Console.WriteLine("Good Morning Mr.Cezar");
        }
    }
}
