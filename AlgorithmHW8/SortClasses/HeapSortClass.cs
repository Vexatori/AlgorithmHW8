using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmHW8.UtilityClasses;

namespace AlgorithmHW8.SortClasses
{
    public static class HeapSortClass
    {
        private static Stopwatch _timer;

        public static Stopwatch GetTime
        {
            get => _timer;
        }

        public static void DoSort( ref ArrayClass arr )
        {
            _timer = Stopwatch.StartNew();

            int mid = arr.Size / 2;
            int t = arr.Size - 1;
            for(int i = mid; i >= 1; i--)
            {
                if(arr.Array[ i - 1 ] < arr.Array[ 2 * i - 1 ])
                    SwapClass.DoSwap(ref arr.Array[ i - 1 ], ref arr.Array[ 2 * i - 1 ]);
                if(2 * i < arr.Size && arr.Array[ i - 1 ] < arr.Array[ 2 * i ])
                    SwapClass.DoSwap(ref arr.Array[ i - 1 ], ref arr.Array[ 2 * i ]);
            }
            SwapClass.DoSwap(ref arr.Array[ 0 ], ref arr.Array[ t ]);
            t--;
            while(t > 0)
            {
                mid = t / 2;
                for(int i = mid; i >= 1; i--)
                {
                    if(arr.Array[ i - 1 ] < arr.Array[ 2 * i - 1 ])
                        SwapClass.DoSwap(ref arr.Array[ i - 1 ], ref arr.Array[ 2 * i - 1 ]);
                    if(2 * i < arr.Size && arr.Array[ i - 1 ] < arr.Array[ 2 * i ])
                        SwapClass.DoSwap(ref arr.Array[ i - 1 ], ref arr.Array[ 2 * i ]);
                }
                SwapClass.DoSwap(ref arr.Array[ 0 ], ref arr.Array[ t ]);
                t--;
            }
            if(arr.Size > 0 && arr.Array[ 0 ] > arr.Array[ 1 ])
                SwapClass.DoSwap(ref arr.Array[ 0 ], ref arr.Array[ 1 ]);

            _timer.Stop();
        }
    }
}
