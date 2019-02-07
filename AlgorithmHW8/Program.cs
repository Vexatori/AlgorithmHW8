using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmHW8.SortClasses;
using AlgorithmHW8.UtilityClasses;

namespace AlgorithmHW8
{
    class Program
    {
        static void Main( string[] args )
        {
            ArrayClass array = new ArrayClass( 100000 );
            array.SetRandomArray( 0, 100 );
            //array.ShowArray();

            #region Сортировка пузырьком

            BubbleSortClass.DoSort(ref array);
            //array.ShowArray();
            array.ResetArray();

            Console.WriteLine(
                    $"Сортировка пузырьком: {BubbleSortClass.GetTime.ElapsedMilliseconds,5} миллисекунд");

            #endregion

            #region Шейкерная сортировка

            ShakerSortClass.DoSort(ref array);
            //array.ShowArray();
            array.ResetArray();

            Console.WriteLine($"Шейкерная сортировка: {ShakerSortClass.GetTime.ElapsedMilliseconds,5} миллисекунд");

            #endregion

            #region Сортировка вставками

            InsertionSortClass.DoSort(ref array);
            //array.ShowArray();
            array.ResetArray();

            Console.WriteLine($"Сортировка вставками: {InsertionSortClass.GetTime.ElapsedMilliseconds,5} миллисекунд");

            #endregion

            #region Быстрая сортировка

            Stopwatch timer = new Stopwatch();
            timer.Start();
            QuickSortClass.DoSort(ref array, 0, array.Size - 1);
            timer.Stop();
            //array.ShowArray();
            array.ResetArray();

            Console.WriteLine($"Быстрая сортировка: {timer.ElapsedMilliseconds,5} миллисекунд");

            #endregion

            #region Пирамидальная сортировка

            HeapSortClass.DoSort(ref array);
            //array.ShowArray();
            array.ResetArray();

            Console.WriteLine($"Пирамидальная сортировка: {HeapSortClass.GetTime.ElapsedMilliseconds,5} миллисекунд");

            #endregion

            Console.ReadLine();
        }
    }
}