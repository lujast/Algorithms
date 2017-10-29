using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AccordingToBook.Chapter1
{
    public class MyCollection3<T> : IEnumerable<T>
    {
        private T[] array;
        private int lastIndexToUse = 0;

        public MyCollection3()
        {

            this.array = new T[32];
        }

        public MyCollection3(int capacity)
        {
            this.array = new T[capacity];
        }

        T this[int i]
        {
            get
            {        
                return i < array.Length && i>=0 ?   this.array[i] :  throw  new IndexOutOfRangeException() ;
            }
            set
            {
                if (i < array.Length && i >= 0)
                {
                    this.array[i] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
                    
            }
        }

        public void Add(T obj)
        {
            if ( lastIndexToUse >= this.array.Length)
            {
                this.ResizeArray();
            }

            this.array[lastIndexToUse] = obj;
        }

        public void Remove(T obj)
        {
            if (this.array.Contains<T>(obj))
            {
                
            }
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

 

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


        private  void ResizeArray()
        {

        }

        private void RebuildArray()
        {
            
        }
        
        private int? FindElementPosition(T obj)
        {
            int i = 0;
            while (i < this.array.Length && !this.array[i].Equals( obj))
            {
                i++;
            }
            return  i < this.array.Length ? (Nullable<int>)i : null;
        }
    }
}
