using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Chapter1
{
    public class MyCollection2<T> : IEnumerable<T>
    {
        private IList<T> list;

        public MyCollection2()
        {
            this.list = new List<T>();
        }

        public void Add(T obj)
        {
            this.list.Add(obj);
        }

        public void Remove(T obj)
        {
            this.list.Remove(obj);
        }

        public void RemoveAt(int index)
        {
            this.list.RemoveAt(index);
        }

        public void Clear()
        {
            this.list.Clear();
        }

        public bool Contains(T obj)
        {
            return this.list.Contains<T>(obj);
        }

        public T this[int i]
        {
            get
            {
                return this.list[i];
            }

            set
            {
                this.list[i] = value;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
