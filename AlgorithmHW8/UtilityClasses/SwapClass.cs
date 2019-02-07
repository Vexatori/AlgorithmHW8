using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW8.UtilityClasses
{
    public static class SwapClass
    {
        public static void DoSwap<T>( ref T a, ref T b )
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
