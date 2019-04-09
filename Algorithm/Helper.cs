using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using CsvHelper;

namespace Algorithm
{
    public class Helper
    {
        public static int[] GenerateRandomArray(int size)
        {
            int[] A = new int[size];

            int seed = (int)DateTime.Now.Ticks;
            Random rnd = new Random(seed);

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(1, 20000);
            }

            return A;
        }

        public static int[] GenerateSortedArray(int size)
        {
            int[] A = new int[size];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = i;
            }

            return A;

        }

    }
}
