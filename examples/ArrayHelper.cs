using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;
using System.Threading;

namespace Sorting_SampleProject.examples
{
    class ArrayHelper
    {
        private long[] arr;
        private int noi; //number of items

        public ArrayHelper(int max)
        {
            arr = new long[max];
            noi = 0;
        }

        public void Insert(long value)
        {
            arr[noi] = value;
            noi++;
        }

        public void Display()
        {
            for (int i = 0; i < noi; i++)
            {
                Console.Write("{0} ", arr[i]);
                //
            }
            Console.WriteLine();
        }

        public void swap(int i, int j)
        {
            long local;
            local = arr[i];
            arr[i] = arr[j];
            arr[j] = local;
        }
        public void BubbleSort()
        {
            int i = 0;
            int j = 0;
            int numofswaps = 0;
            int numofcomps = 0;
            int numofpasses = 0;

            for (j = noi - 1; j > 0; j--)
            {
                Console.WriteLine("************ Pass - " + (noi - j) + " *******************");

                for (i = 0; i < j; i++)
                {

                    if (arr[i] > arr[i + 1])
                    {
                        numofswaps++;
                        //swap
                        long temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }

                    numofcomps++;
                }
                Display();

                Console.WriteLine("Number of swaps: " + numofswaps);
                Console.WriteLine("Number of Comparisons: " + numofcomps);

                numofswaps = 0;
                numofcomps = 0;
                numofpasses++;
            }
            Console.WriteLine("############################################################");
            Console.WriteLine("Total Number of Passes: " + numofpasses);

        }

        public void SelectionSort()
        {
            int i = 0;
            int j = 0;
            int numofswaps = 0;
            int numofcomps = 0;
            int lowervalueindex = 0;
            int numofpasses = 0;

            for (i = 0; i < noi - 1; i++)
            {
                Console.WriteLine("************ Pass - " + (i + 1) + " *******************");
                lowervalueindex = i;

                for (j = i + 1; j < noi; j++)
                {
                    numofcomps++;
                    if (arr[j] < arr[lowervalueindex])
                    {
                        lowervalueindex = j;
                    }
                }
                swap(i, lowervalueindex);
                numofswaps++;

                Display();

                Console.WriteLine("Number of swaps: " + numofswaps);
                Console.WriteLine("Number of Comparisons: " + numofcomps);

                numofswaps = 0;
                numofcomps = 0;
                numofpasses++;
            }
            Console.WriteLine("############################################################");
            Console.WriteLine("Total Number of Passes: " + numofpasses);

        }

        public void InsertionSort()
        {
            int i = 0;
            int j = 0;
            int numofswaps = 0;
            int numofcomps = 0;
            int numofpasses = 0;
            long local = 0;

            for (i = 1; i < noi; i++)
            {
                Console.WriteLine("************ Pass - " + (i) + " *******************");
                local = arr[i];
                
                for (j = i; j > 0; j--)
                {
                    numofcomps++;
                    if (arr[j - 1] >= local)
                        arr[j] = arr[j - 1];
                    else
                        break;
                }

                arr[j] = local;

                Display();

                Console.WriteLine("Number of swaps: " + numofswaps);
                Console.WriteLine("Number of Comparisons: " + numofcomps);

                numofswaps = 0;
                numofcomps = 0;
                numofpasses++;
            }

            Console.WriteLine("############################################################");
            Console.WriteLine("Total Number of Passes: " + numofpasses);

        }
    }
}
