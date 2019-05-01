using System;

namespace Algorithm
{
    public class BFM
    {
        // ALGORITHM BruteForceMedian(A[0..n− 1])    
        // Returns the median value in a given array A of n numbers.
        public static int BruteForceMedian(int[] array)
        {
            // This is the kth element, where k=n2 , if the array was sorted.  
            int k = (int)Math.Ceiling(array.Length / 2.0);

            // Checking the A[i] wheither median or not
            // Looping through the array
            for (int i = 0; i < array.Length; i++)
            {
                int numsmaller = 0; // How many elements are smaller than A[i] 
                int numequal = 0;   // How many elements are equal to A[i]

                // Looping through the array for comparing A[i] with other elements to check 
                // A[i] wheither median match the median condition or not
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] < array[i])    // Basic Operation, Comparision
                    {
                        numsmaller++;
                    }
                    else if (array[j] == array[i]) // Basic Operation, Comparision
                    {
                        numequal++; 
                    }
                }

                // If numsmaller is smaller than k meanwhile 
                // numsmaller + numequal is equal or larger than k
                // The array element selected by indexer i is median
                if (numsmaller < k && k <= (numsmaller + numequal))
                {
                    return array[i];    // Return the median to the user
                }
            }

            // No Result Found
            return -1;    // Return Error code -1
        }

        // ALGORITHM BruteForceMedian(A[0..n− 1])    
        // Returns the Basic Operation the Brute Force Median takes
        public static int BruteForceMedian_BO(int[] array)
        {
            int basicOperation = 0;
            // This is the kth element, where k=n2 , if the array was sorted.  
            int k = (int)Math.Ceiling(array.Length / 2.0);

            // Checking the A[i] wheither median or not
            // Looping through the array
            for (int i = 0; i < array.Length; i++)
            {
                int numsmaller = 0; // How many elements are smaller than A[i] 
                int numequal = 0;   // How many elements are equal to A[i]

                // Looping through the array for comparing A[i] with other elements to check 
                // A[i] wheither median match the median condition or not
                for (int j = 0; j < array.Length; j++)
                {
                    basicOperation++;
                    if (array[j] < array[i])    // Basic Operation, Comparision
                    {
                        numsmaller++;
                    }
                    basicOperation++;
                    else if (array[j] == array[i]) // Basic Operation, Comparision
                    {
                        numequal++; 
                    }
                }

                // If numsmaller is smaller than k meanwhile 
                // numsmaller + numequal is equal or larger than k
                // The array element selected by indexer i is median
                if (numsmaller < k && k <= (numsmaller + numequal))
                {
                    return basicOperation;    // Return the basic Operation
                }
            }

            // No Result Found
            return basicOperation;   
        }
    }
}
