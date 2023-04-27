using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class M3 : BMW
    {
        public M3(string Model, string HP, string Color) : base(HP, Color, Model)
        {
            this.Model = Model;
        }

       public override void Repair()
       {
            base.Repair();
       }
        
    }
}
