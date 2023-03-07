using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Senior : Teacher
    {
        public override void SeniorTalk()
        {
            Console.WriteLine("Hi Cezar.");
        }
    }
}
