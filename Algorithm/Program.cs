using System;
using System.Linq;

namespace Algorithm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("CAB 301 Assignment1 - Semester 1 2019");
            Console.WriteLine("Student ID : n9845097");

            CSV.GenerateExecutionTimeCSV();
            CSV.GenerateBasicOperationCSV();
            Console.WriteLine("Success! Please Check bin/debug folder to get the csv file");
        }


    }
}
