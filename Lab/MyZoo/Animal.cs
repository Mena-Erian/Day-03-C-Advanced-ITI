using Assignment;
using Lab.MyZoo.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MyZoo
{
    internal abstract class Animal : IMoveable
    {
        public int Name { get; set; }
        public int Age { get; set; }
        protected Animal()
        {
            Age = Helper.GetIntFromUser($"Age of {this}", false);
        }
        public abstract void Move();
    }
}
