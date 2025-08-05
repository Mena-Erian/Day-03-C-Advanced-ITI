using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MyZoo.Animals
{
    internal class Sparrow : Birds
    {
        public override void Move()
        {
            throw new NotImplementedException();
        }
        public override string ToString() => "Sparrow";
    }
}
