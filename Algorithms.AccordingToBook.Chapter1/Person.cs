using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Chapter1
{
    public class Person : IComparable<Person>, IEquatable<Person>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(Person other)
        {
            return this.Id.CompareTo(other.Id);
        }


        public string Display()
        {
            return $"{this.Id}\t{this.FirstName}\t{this.LastName}";
        }

        public bool Equals(Person other)
        {
            return this.GetHashCode() == other.GetHashCode();
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode() + this.FirstName.GetHashCode() + this.LastName.GetHashCode();
        }

    }
}
