using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmHW8.UtilityClasses;

namespace AlgorithmHW8.SortClasses
{
    public static class InsertionSortClass
    {
        private static Stopwatch _timer;

        public static Stopwatch GetTime
        {
            get => _timer;
        }

        public static void DoSort( ref ArrayClass arr )
        {
            _timer = Stopwatch.StartNew();

            for ( int i = 1; i < arr.Size; i++ )
            {
                for ( int j = i; j > 0 && arr.Array[ j - 1 ] > arr.Array[ j ]; j-- )
                {
                    SwapClass.DoSwap( ref arr.Array[ j - 1 ], ref arr.Array[ j ] );
                }
            }

            _timer.Stop();
        }
    }
}