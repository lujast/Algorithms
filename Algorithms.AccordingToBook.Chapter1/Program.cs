using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Chapter1
{
    public  class Program
    {
        public static void Main()
        {
            Console.WriteLine("Chapter2, test started: ");

            TestCollection();
            TestCollection2();
            TestCollection3();
            

        }

        public static void TestCollection()
        {
            Console.WriteLine("Collection test started:");
            var collection = new MyCollection();

            for (int i = 0; i < 10; i++)
            {
                collection.Add(i + 1);
            }

            Console.WriteLine(collection.IndexOf(5));

            Console.WriteLine(collection.Contains(7));
            collection.RemoveAt(6);
            Console.WriteLine(collection.Contains(7));

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Collection test ended.");
        }

        public static void TestCollection2()
        {
            Console.WriteLine("Collection2 test started:");

            var collection2 = new MyCollection2<Person>();
            collection2.Add(new Person { Id = 1, FirstName = "John", LastName = "Doe" });
            collection2.Add(new Person { Id = 2, FirstName = "John", LastName = "Doe2" });
            collection2.Add(new Person { Id = 4, FirstName = "John", LastName = "Doe4" });
            collection2.Add(new Person { Id = 3, FirstName = "John", LastName = "Doe3" });


            Console.WriteLine("using foreach");
            foreach (var person in collection2)
            {
                Console.WriteLine(person.Display());
            }

            Console.WriteLine("using for");
            for (int i = 0; i < collection2.Count(); i++)
            {
                Console.WriteLine(  collection2[i].Display());
            }

            Console.WriteLine("sorted:");
            collection2.OrderBy(x => x.Id);
            for (int i = 0; i < collection2.Count(); i++)
            {
                Console.WriteLine(collection2[i].Display());
            }

            Console.WriteLine("sorted:");
            var collection22 = collection2.OrderBy(x => x.Id).ToList();
            for (int i = 0; i < collection22.Count(); i++)
            {
                Console.WriteLine(collection22[i].Display());
            }

            Console.WriteLine("sorted element by Person:");
            var collection222 = collection2.OrderBy(x => x).ToList();
            for (int i = 0; i < collection222.Count(); i++)
            {
                Console.WriteLine(collection22[i].Display());
            }

            var person1 = new Person() { Id = 1, FirstName = "John", LastName = "Doe" };
            var result=collection2.Contains(person1);
            Console.WriteLine(result);

            Console.WriteLine("Check hash code:");
            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person1.Id.GetHashCode());
            Console.WriteLine(person1.FirstName.GetHashCode());
            Console.WriteLine(person1.LastName.GetHashCode());

            Console.WriteLine(-100.GetHashCode());
            Console.WriteLine(-1.GetHashCode());
            Console.WriteLine(0.GetHashCode());
            Console.WriteLine((12 + 13).GetHashCode());
            Console.WriteLine('a'.GetHashCode());
            Console.WriteLine('A'.GetHashCode());

            Console.WriteLine("Collection2 test ended.");
        }


        public static void TestCollection3()
        {
            Console.WriteLine("Collection3 test started:");

 


            Console.WriteLine("Collection3 test ended.");
        }

    }
}
