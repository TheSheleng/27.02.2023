using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._2023
{
    internal class MyStack<T>
    {
        List<T> values = new List<T>();
        public void Push(T value) => values.Add(value);
        public T Pop() 
        {
            T res = values.Last();
            values.Remove(res);
            return res;
        }
        public T Peek() => values.Last();
        public int Count => values.Count;
    }
}
