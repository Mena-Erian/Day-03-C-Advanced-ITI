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
            Employee e1 = new Employee() { Id = 1, Name = "Mena" };
            Employee e2 = new Employee() { Id = 2, Name = "test" };

            MyCollection<Employee> employees = new MyCollection<Employee>();

            employees.Add(new Employee() { Id = 1, Name = "Mena" });
            employees.Add(new Employee() { Id = 2, Name = "Hosam" });
            employees.Add(new Employee() { Id = 3, Name = "Ali" });

            //for (int i = 0; i < 3; i++)
            //    Console.WriteLine(employees.GetByIndex(i));

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



        }
    }
}
