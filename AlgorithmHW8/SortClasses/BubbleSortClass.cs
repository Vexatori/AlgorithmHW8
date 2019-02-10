using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmHW8.UtilityClasses;

namespace AlgorithmHW8.SortClasses
{
    public static class BubbleSortClass
    {
        private static Stopwatch _timer;

        public static Stopwatch GetTime
        {
            get => _timer;
        }

        public static void DoSort( ref ArrayClass arr )
        {
            _timer = Stopwatch.StartNew();

            for(int i = 0; i < arr.Size; i++)
            {
                for(int j = 0; j < arr.Size - 1; j++)
                {
                    if(arr.Array[ j ] > arr.Array[ j + 1 ])
                    {
                        SwapClass.DoSwap(ref arr.Array[ j ], ref arr.Array[ j + 1 ]);
                    }
                }
            }

            _timer.Stop();
        }
    }
}
