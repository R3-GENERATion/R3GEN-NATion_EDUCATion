using CodeFactory.Iterators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFactory.Aggregates
{
    public class R3GEN_List<T> : IAggregate<T> where T : class
    {
        const int MAX = 10;
        private readonly System.Int16 increment = 5;
        T[]? array = null;

        public int Count
        {
            get
            {
                int i = 0;
                while(i < array.Length)
                {
                    if (array[i++] == null)
                        break;
                }
                return i;
            }
        }

        public R3GEN_List() { }

        public R3GEN_List(T[]? values)
        {
            array = values;
        }

        public R3GEN_List(T[]? leftVals, T[]? rightVals) 
        {
            int count = 0;

            if(leftVals != null) {
                count += leftVals.Length;
                
            }
            if(rightVals != null) { count += rightVals.Length; }

            array = new T[count];

            for(int i = 0; i < count; i++)
            {
                if(i < leftVals.Length)
                    array[i] = leftVals[i];
                else
                    array[i] = rightVals[i - leftVals.Length];
            }
        }

        public void Add(T obj)
        {
            if(array == null)
            {
                array= new T[MAX];
            }
            if(array.Length > this.Count + 1)
            {
                array[this.Count] = obj;
            }
            else
            {
                T[] newArray = new T[array.Length + increment];

                for(int i = 0; i<array.Length;i++)
                {
                    newArray[i] = array[i];
                }

                newArray[this.Count] = obj;

                array = newArray;
            }
        }

        public T At(int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public IIterator GetIterator()
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj, int index)
        {
            throw new NotImplementedException();
        }

        public void Remove(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
