using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MyZoo
{
    internal class Zoo : IEnumerable
    {
        #region Fields and Properties
        private Animal[] animals;
        private int currentIndex = -1;
        private int CurrentIndex
        {
            set
            {
                if (value == this.animals.Length)
                {
                    Extend();
                    CurrentIndex = currentIndex;
                }
                currentIndex = value;
            }
        }
        #endregion

        #region Constructors
        public Zoo()
        {
            animals = new Animal[5];
        }
        #endregion

        #region Methods
        private void Extend()
        {
            Animal[] newAnimals = new Animal[animals.Length * 2];
            for (int i = 0; i < animals.Length; i++)
            {
                newAnimals[i] = animals[i];
            }
            this.animals = newAnimals;
        }
        public void Add(Animal animal)
        {
            if (animals == null)
            {
                Console.WriteLine("Animal is NULL");
                return;
            }
            if (animal.Age < 10)
            {
                Console.WriteLine("Animal is NOT Accept in Zoo should");
                Console.WriteLine("Animal Age should bigger or Equal 10");
                return;
            }
            CurrentIndex = ++currentIndex;
            this.animals[currentIndex] = animal;
            Console.WriteLine($"{animal} is Added");
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        class Iterator : IEnumerator
        {
            private Zoo zoo;
            private int index = -1;
            public Iterator(Zoo zoo)
            {
                this.zoo = zoo;
            }
            public object Current
            {
                get => zoo.animals[index];
            }

            public bool MoveNext()
            {
                index++;
                return index < zoo.animals.Length ? true : false;
            }

            public void Reset()
            {
                index = -1;
            }
        }
        #endregion


    }
}
