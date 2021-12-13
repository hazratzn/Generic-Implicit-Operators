using System;
using System.Collections.Generic;
using System.Text;

namespace SortByAge
{
    class DataList<T> where T: Person
    {
        private T[] arr;
        public DataList()
        {
            arr = new T[0];
        }
        public void Add(T data)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = data;
        }
        public void GetAll()
        {
            foreach(var item in arr)
            {
                Console.WriteLine(item.Age);
            }
        }

    }
}
