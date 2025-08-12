using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    public class SwapFunctions
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine($"You sent the Swap() method a {typeof(T)}");

            T temp = a;

            a = b;

            b =temp;
        }
    }
}
