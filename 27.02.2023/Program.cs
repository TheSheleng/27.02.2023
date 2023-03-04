using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._2023
{
    internal class Program
    {
        public static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0) return a;
            if (b.CompareTo(c) > 0) return b;
            return c;
        }
        public static T Min<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) < 0 && a.CompareTo(c) < 0) return a;
            if (b.CompareTo(c) < 0) return b;
            return c;
        }
        public static double Sum<T>(T[] array) where T : struct, IConvertible
        {
            double sum = 0.0;
            for (int i = 0; i < array.Length; i++)
                sum += Convert.ToDouble(array[i]);
            return sum;
        }
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
