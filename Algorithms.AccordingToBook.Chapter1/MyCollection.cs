using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Chapter1
{
    public class MyCollection : CollectionBase
    {
        public new int Count()
        {
            return InnerList.Count;
        }

        public void Add(object obj)
        {
            InnerList.Add(obj);
        }

        public void Remove(object obj)
        {
            InnerList.Remove(obj);

        }

        public new  void Clear()
        {
            InnerList.Clear();
        }

        public bool Contains(object obj)
        {
            return this.InnerList.Contains(obj);
        }

        public int IndexOf(object obj)
        {
            return this.InnerList.IndexOf(obj);
        }

        public new void RemoveAt(int index)
        {
            this.InnerList.RemoveAt(index);
        }

    }
}
