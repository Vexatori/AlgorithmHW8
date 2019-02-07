using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmHW8.UtilityClasses;

namespace AlgorithmHW8.SortClasses
{
    public static class QuickSortClass
    {
        public static void DoSort( ref ArrayClass arr, int first, int last )
        {
            int i = first;
            int j = last;
            int x = arr.Array[ ( first + last ) / 2 ];

            do
            {
                while ( arr.Array[ i ] < x )
                    i++;
                while ( arr.Array[ j ] > x )
                    j--;

                if ( i <= j )
                {
                    if ( arr.Array[ i ] > arr.Array[ j ] )
                        SwapClass.DoSwap( ref arr.Array[ i ], ref arr.Array[ j ] );
                    i++;
                    j--;
                }
            } while ( i <= j );

            if ( i < last )
                DoSort( ref arr, i, last );
            if ( first < j )
                DoSort( ref arr, first, j );
        }
    }
}