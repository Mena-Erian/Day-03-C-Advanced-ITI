using Day3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class MyCollection<T> : IEnumerable
    {
        #region Fields
        private T[] arr;
        private int currentIndex = -1;
        #endregion

        public T this[int index]
        {
            get
            {
                return index <= currentIndex ? arr[index] : throw (new ArgumentOutOfRangeException());
            }
            set
            {
                if (index == arr.Length) Extend();
                arr[index] = value;
            }
        }
        public T this[string name]
        {
            get
            {
                if (name == null) return default(T);
                for (int i = 0; i <= currentIndex; i++)
                {
                    if (arr[i].ToString().Contains(name))
                        return arr[i];
                }
                return default(T);
            }
        }
        #region Constructors
        public MyCollection()
        {
            arr = new T[5];
            currentIndex = -1;
        }
        #endregion

        #region Methods
        public void Add(T value)
        {
            //T t = new T();
            if (currentIndex == arr.Length - 1) Extend();
            currentIndex++;
            arr[currentIndex] = value;
        }
        private void Extend()
        {
            T[] newArr = new T[arr.Length * 2];
            for (int i = 0; i < arr.Length; i++)
                newArr[i] = this.arr[i];
            this.arr = newArr;
        }
        public T GetByIndex(int index)
        {
            if (index < 0 || index > currentIndex) throw new IndexOutOfRangeException();
            return arr[index];
        }
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }
        #endregion
        class Iterator : IEnumerator
        {
            MyCollection<T> myCollection;
            int index = -1;
            public Iterator(MyCollection<T> myCollection)
            {
                this.myCollection = myCollection;
            }
            public object Current { get { return this.myCollection.arr[index]; } }

            public bool MoveNext()
            {
                index++;
                return index <= this.myCollection.currentIndex;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
#region My Implmentation
/// class Iterator : IEnumerator
/// {
///     MyCollection<T> myCollection;
///     int currentIndex = 0;
///     public Iterator(MyCollection<T> myCollection)
///     {
///         this.myCollection = myCollection;
///         Current = this.myCollection.arr[0];
///         //this.myCollection.arr.Length;
///     }
///     public object Current { get; set; }
/// 
///     public bool MoveNext()
///     {
///         if (currentIndex >= 0 && currentIndex < this.myCollection.arr.Length)
///         {
///             Current = this.myCollection.arr[currentIndex];
///             currentIndex++;
///             return true;
///         }
///         else
///             return false;
///     }
/// 
///     public void Reset()
///     {
///         throw new NotImplementedException();
///     }
/// }
#endregion