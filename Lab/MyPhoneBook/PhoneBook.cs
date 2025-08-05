using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MyPhoneBook
{


    internal class PhoneBook : IEnumerable
    {
        internal class Person
        {
            public int Number { get; set; }
            public string? Name { get; set; }
            public override string ToString()
            {
                return $"Name: {Name}, Number: {Number}";
            }
        }

        #region Fields
        private Person[] persons;
        private int currentIndex = -1;
        #endregion

        #region Indexer
        private Person this[int index]
        {
            get
            {
                return index <= currentIndex ? persons[index] : new Person();
            }
            set
            {
                if (index == persons.Length) Extend();
                persons[index] = value;
            }
        }
        //public Person this[string name]
        //{
        //    get
        //    {
        //        if (name == null) return new Person();
        //        for (int i = 0; i <= currentIndex; i++)
        //        {
        //            if (persons[i].ToString().Contains(name))
        //                return persons[i];
        //        }
        //        return new Person();
        //    }
        //}
        public int this[string userName]
        {
            get
            {
                for (int i = 0; i <= currentIndex; i++)
                {
                    if (persons[i].ToString().Contains(userName))
                        return persons[i].Number;
                }
                return -1;
            }
            set
            {
                //Person person;
                int userIndex = -1;
                for (int i = 0; i <= currentIndex; i++)
                {
                    if ((persons[i]?.Name ?? "NOTFOUND").ToString()==(userName)) 
                        userIndex = i;
                    //person = persons[i];
                }
                if (userIndex > -1)
                    this.persons[userIndex].Number = value;
                else Console.WriteLine($"{userName} IS NOT FOUNDED");
            }
        }

        public string this[long userNumber]
        {
            get
            {
                for (int i = 0; i <= currentIndex; i++)
                {
                    if (persons[i].ToString().Contains(userNumber.ToString()))
                        return persons[i]?.Name ?? "";
                }
                return "NOT FUOND";
            }
            set
            {
                //Person person;
                int userIndex = -1;
                for (int i = 0; i <= currentIndex; i++)
                {
                    if (persons[i].ToString().Contains(userNumber.ToString()))
                        userIndex = i;
                    //person = persons[i];
                }
                if (userIndex > -1)
                    this.persons[userIndex].Name = value;
                else Console.WriteLine("USER NOT FOUNDED");
            }
        }
        #endregion

        #region Constructors
        public PhoneBook()
        {
            persons = new Person[5];
            currentIndex = -1;
        }
        #endregion

        #region Methods
        public void Add(Person value)
        {
            if (currentIndex == persons.Length - 1) Extend();
            currentIndex++;
            persons[currentIndex] = value;
        }
        private void Extend()
        {
            Person[] newArr = new Person[persons.Length * 2];
            for (int i = 0; i < persons.Length; i++)
                newArr[i] = this.persons[i];
            this.persons = newArr;
        }
        public Person GetByIndex(int index)
        {
            if (index < 0 || index > currentIndex) return new Person();
            return persons[index];
        }
        public void Print()
        {
            for (int i = 0; i < persons.Length; i++)
                Console.WriteLine(persons[i]);
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }
        #endregion
        class Iterator : IEnumerator
        {
            PhoneBook myPhoneBook;
            int index = -1;
            public Iterator(PhoneBook myCollection)
            {
                this.myPhoneBook = myCollection;
            }
            public object Current { get { return this.myPhoneBook.persons[index]; } }

            public bool MoveNext()
            {
                index++;
                return index <= this.myPhoneBook.currentIndex;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
