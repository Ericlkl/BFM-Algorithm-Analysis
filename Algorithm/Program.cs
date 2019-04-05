using System;

namespace Algorithm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Even, random
            int[] inputArray1 = { 1, 6, 4, 9, 0, 12, 56, 3 };
            // Odd, random
            int[] inputArray2 = { 5, 8, 2, 3, 0, 11, 4, 29, 7 };
            // Sorted
            int[] inputArray3 = { 23, 30, 47, 55, 69, 70, 81, 99 };
            // Reverse order
            int[] inputArray4 = { 123, 93, 87, 75, 60, 33, 12, 2, 1 };
            // Contains negative values
            int[] inputArray5 = { -1, 6, 4, 0, 8, -3, 2, 5 };
            // Contains duplicates
            int[] inputArray6 = { 50, 4, 2, 3, 1, 9, 10, 2, 3 };
            //Invalid size input!"
            int[] inputArray7 = { 0 };

            Console.WriteLine("Array 1 : " + BruteForceMedian(inputArray1) );
            Console.WriteLine("Array 2 : " + BruteForceMedian(inputArray2) );
            Console.WriteLine("Array 3 : " + BruteForceMedian(inputArray3) );
            Console.WriteLine("Array 4 : " + BruteForceMedian(inputArray4) );
            Console.WriteLine("Array 5 : " + BruteForceMedian(inputArray5) );
            Console.WriteLine("Array 6 : " + BruteForceMedian(inputArray6) );
            Console.WriteLine("Array 7 : " + BruteForceMedian(inputArray7) );
        }

        // ALGORITHM BruteForceMedian(A[0..n− 1])    
        // Returns the median value in a given array A of n numbers.
        public static int BruteForceMedian(int[] array)
        {
            // This is the kth element, where k=n2 , if the array was sorted.  
            int k = (int)Math.Ceiling(array.Length / 2.0);

            for (int i = 0; i < array.Length; i++)
            {
                int numsmaller = 0; // How many elements are smaller than A[i] 
                int numequal = 0;   // How many elements are equal to A[i]

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        numsmaller++;
                    }
                    else if (array[j] == array[i])
                    {
                        numequal++;
                    }
                }

                if (numsmaller < k && k <= (numsmaller + numequal))
                {
                    return array[i];
                }
            }

            return -1;    // Return Error code -1
        }
    }
}
