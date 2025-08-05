using Day3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            //Employee e1 = new Employee() { Id = 1, Name = "Mena" };
            //Employee e2 = new Employee() { Id = 2, Name = "test" };

            //MyCollection<Employee> employees = new MyCollection<Employee>();

            //employees.Add(new Employee() { Id = 1, Name = "Mena" });
            //employees.Add(new Employee() { Id = 2, Name = "Hosam" });
            //employees.Add(new Employee() { Id = 3, Name = "Ali" });

            //for (int i = 0; i < 3; i++)
            //    Console.WriteLine(employees.GetByIndex(i)); 
            #endregion

            #region IEnumerable & IEnumerator
            //A a = new A();

            //IEnumerator enumerator = employees.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    Employee employee = (Employee)enumerator.Current;
            //    Console.WriteLine(employee);
            //}
            //enumerator.Reset();

            //while (enumerator.MoveNext())
            //{
            //    Employee employee = (Employee)enumerator.Current;
            //    Console.WriteLine(employee);
            //}

            //foreach (Employee e in employees)
            //{
            //    Console.WriteLine(e);
            //} 
            #endregion

            #region Indexer
            //Employee e1 = new Employee() { Id = 1, Name = "Mena" };
            //Employee e2 = new Employee() { Id = 2, Name = "test" };

            //MyCollection<Employee> employees = new MyCollection<Employee>();

            //employees.Add(new Employee() { Id = 1, Name = "Mena" });
            //employees.Add(new Employee() { Id = 2, Name = "Hosam" });
            //employees.Add(new Employee() { Id = 3, Name = "Ali" });
            //Console.WriteLine(employees[1] = new Employee());
            //Console.WriteLine(employees[1]);
            //Console.WriteLine(employees["Hos"]); 
            #endregion

            #region String
            /// string s1 = "Hello";
            /// //string boll
            /// //string s2 =new string(new char[] { 'H', 'e', 'l', 'l', 'o' });
            ///
            /// //string s2 = "Hello";
            ///
            /// Employee s2 = new Employee() { Name = "Hello" };
            ///
            ///
            /// //Console.WriteLine(s1 == s2);
            /// Console.WriteLine(s1.GetHashCode());
            /// Console.WriteLine(s2.Name.GetHashCode());
            /// Console.WriteLine(object.ReferenceEquals(s1,s2.Name));
            /// Console.WriteLine(object.ReferenceEquals(s1,s2));
            ///
            /// //StringBuilder sb = new StringBuilder(); 
            #endregion

        }
    }
}
