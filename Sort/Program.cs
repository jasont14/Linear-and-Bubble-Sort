using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {            
            string dash = "*******************\n";
            int[]SortList = { 1000, 900, 1, 100, 400, 10000, 20000, 5000, 200, 60, 600, 500, 80, 30, 300, 20, 90, 40, 700, 800, 50, 1 };

            CustomSort mySort = new CustomSort();

            Console.WriteLine("INSERTION SORT");
            Console.WriteLine(dash);
            int[] InsetionSortList = new int[SortList.Length];
            SortList.CopyTo(InsetionSortList, 0);
            mySort.InsertionSort(InsetionSortList);
            
            Console.WriteLine("\nSELECTION SORT");
            Console.WriteLine(dash);
            int[] SelectionSortList = new int[SortList.Length];
            SortList.CopyTo(SelectionSortList, 0);
            mySort.SelectionSort(SelectionSortList);
            
            Console.WriteLine("\nLINEAR SORT");
            Console.WriteLine(dash);
            int[] LinearSort = new int[SortList.Length];
            SortList.CopyTo(LinearSort, 0);            
            mySort.LinearSort(LinearSort);
            
            Console.WriteLine("\nBUBBLE SORT");
            Console.WriteLine(dash);
            int[] BubbleSort = new int[SortList.Length];
            SortList.CopyTo(BubbleSort, 0);
            mySort.BubbleSort(BubbleSort);
            
            Console.WriteLine("\nBUBBLE SORT WITH BREAK");
            Console.WriteLine(dash);
            int[] BubbleSortBreak = new int[SortList.Length];
            SortList.CopyTo(BubbleSortBreak, 0);
            mySort.BubbleSortWithBreak(BubbleSortBreak);
            Console.ReadLine();
        }
    }
}

