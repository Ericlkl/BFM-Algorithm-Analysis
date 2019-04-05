using System;

namespace Algorithm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("CAB 301 Assignment1 - Semester 1 2019");
            Console.WriteLine("Student ID : n9845097");
        }

        // ALGORITHM BruteForceMedian(A[0..n− 1])    
        // Returns the median value in a given array A of n numbers.
        public static int BruteForceMedian(int[] array)
        {
            // This is the kth element, where k=n2 , if the array was sorted.  
            int k = (int)Math.Ceiling(array.Length / 2.0);
            Console.WriteLine(k);

            for (int i = 0; i < array.Length; i++)  // This is how many times the basic operation run
            {
                int numsmaller = 0; // How many elements are smaller than A[i] 
                int numequal = 0;   // How many elements are equal to A[i]

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] < array[i])    // Basic Operation, because it must execute
                    {
                        numsmaller++;
                    }
                    else if (array[j] == array[i]) // Basic Operation, because it must execute
                    {
                        numequal++; //This one might not execute
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
