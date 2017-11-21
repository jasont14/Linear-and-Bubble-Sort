using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class CustomSort
    {
        public CustomSort()
        {

        }

        public void WriteSortHeader(int[] myArray)
        {
            Console.WriteLine("Starting Array");
            WriteArray(myArray);
            Console.WriteLine("Begin");
        }            

        public void InsertionSort(int[] myArray)
        {
            WriteSortHeader(myArray);

            for (int i = 0; i<myArray.Length; i++)
            {
                int j = i;
                int curMin = myArray[i];

                while(j > 0 && myArray[j-1] > curMin)
                {
                    myArray[j] = myArray[j - 1];
                    j--;
                }

                myArray[j] = curMin;

                WriteArray(myArray);
            }

        }

        

        public void SelectionSort(int[] myArray)
        {

            WriteSortHeader(myArray);

            //Need to index min position and exchange position for new min
            int CurMinIndex;

            //create a for loop to run through the list
            for (int i = 0; i < myArray.Length-1; i++)
            {
                //assume you start a min
                CurMinIndex = i; //Note we are capturing the index position not the value. We will swap if necessary using this position.

                //create a for loop to run through the rest of the list to compare value versus currentMin

                for (int j = i+1; j<myArray.Length; j++)
                {
                    if(myArray[j]<myArray[CurMinIndex])
                    {                      
                        CurMinIndex = j;
                    }
                }

                if (CurMinIndex != i)
                {
                    int NewMinValue = myArray[CurMinIndex];
                    int OldMinValue = myArray[i];
                    myArray[i] = NewMinValue;
                    myArray[CurMinIndex] = OldMinValue;
                }

                WriteArray(myArray);
            }

            
        }


        public void LinearSort(int[] intArray)
        {
            WriteSortHeader(intArray);

            int minValue = 0;
            int temp = 0;

            int[] TempArray = intArray;

            for (int i = 0; i < intArray.Length; i++)
            {
                minValue = intArray[i];

                int jLocation = 0;

                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (TempArray[j] < minValue)
                    {
                        minValue = TempArray[j];
                        jLocation = j;
                    }
                }

                if (jLocation > 0)
                {
                    temp = intArray[i];
                    TempArray[i] = minValue;
                    TempArray[jLocation] = temp;
                }

                WriteArray(TempArray);

            }
        }
        public void BubbleSort(int[] intArray2)
        {
            WriteSortHeader(intArray2);

            int[] TempArray2 = intArray2;

            for (int i = 0; i < intArray2.Length; i++ )
            {
                WriteArray(TempArray2);

                for (int j = i; j < intArray2.Length-1; j++)
                {
                    if (TempArray2[j] > TempArray2[j+1])
                    {
                        int temp21 = TempArray2[j];
                        TempArray2[j] = TempArray2[j+1];
                        TempArray2[j+1] = temp21;
                    }
                }
            }              	       
        }

        public void BubbleSortWithBreak(int[] intArray3)
        {
            WriteSortHeader(intArray3);

            int[] TempArray3 = intArray3;

            bool SortHappen;

            do
            {
                WriteArray(TempArray3);
                SortHappen = false;

                for (int j = 0; j < intArray3.Length - 1; j++)
                {
                    if (TempArray3[j] > TempArray3[j + 1])
                    {
                        int temp = TempArray3[j];
                        TempArray3[j] = TempArray3[j + 1];
                        TempArray3[j + 1] = temp;
                        SortHappen = true;
                    }

                } 
            } while (SortHappen);
              

        }

        public void WriteArray(int[] ArrayToWrite)
        {
            
            for (int i = 0; i < ArrayToWrite.Length; i++)
            {
                if (i == ArrayToWrite.Length - 1)
                {
                    Console.Write(ArrayToWrite[i]+"\n");
                }
                else
                {
                    Console.Write(ArrayToWrite[i] + ",");
                }

            }

        }

    }
}
