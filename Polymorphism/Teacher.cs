using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Teacher
    {
        public virtual void SeniorTalk()
        {
            Console.WriteLine("Hello Mr/Mrs. my name is Cezar.");
        }
        public virtual void StudentsTalk() 
        {
            Console.WriteLine("Hi my name is Cezar");
        }
    }
