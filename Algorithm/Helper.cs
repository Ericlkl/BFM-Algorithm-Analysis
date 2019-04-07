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

        public static long BFM_ExecutionTimeTest(int size)
        {
            var watch = new System.Diagnostics.Stopwatch();

            int[] array = GenerateRandomArray(size);

            watch.Start();

            BFM.BruteForceMedian(array);

            watch.Stop();

            return watch.ElapsedMilliseconds;
        }

        public static int BFM_BasicOperationTest(int size)
        {
            int[] array = GenerateRandomArray(size);
            return BFM.BruteForceMedian_BO(array);
        }

        public static void GenerateBasicOperationCSV()
        {

            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "basicOperation.csv");

            var records = new List<CSVRow>();

            for(int i = 1000; i <= 20000; i+= 1000)
            {
                Console.WriteLine($"Testing on Element {i} ...");
                records.Add( new CSVRow
                {
                    Elements = i,
                    Test1 = BFM_BasicOperationTest(i),
                    Test2 = BFM_BasicOperationTest(i),
                    Test3 = BFM_BasicOperationTest(i),
                    Test4 = BFM_BasicOperationTest(i),
                    Test5 = BFM_BasicOperationTest(i),
                    Test6 = BFM_BasicOperationTest(i),
                    Test7 = BFM_BasicOperationTest(i),
                    Test8 = BFM_BasicOperationTest(i),
                    Test9 = BFM_BasicOperationTest(i),
                    Test10 = BFM_BasicOperationTest(i),
                    Test11 = BFM_BasicOperationTest(i),
                    Test12 = BFM_BasicOperationTest(i),
                    Test13 = BFM_BasicOperationTest(i),
                    Test14 = BFM_BasicOperationTest(i),
                    Test15 = BFM_BasicOperationTest(i),
                    Test16 = BFM_BasicOperationTest(i),
                    Test17 = BFM_BasicOperationTest(i),
                    Test18 = BFM_BasicOperationTest(i),
                    Test19 = BFM_BasicOperationTest(i),
                    Test20 = BFM_BasicOperationTest(i),
                    Test21 = BFM_BasicOperationTest(i),
                    Test22 = BFM_BasicOperationTest(i),
                    Test23 = BFM_BasicOperationTest(i),
                    Test24 = BFM_BasicOperationTest(i),
                    Test25 = BFM_BasicOperationTest(i),
                    Test26 = BFM_BasicOperationTest(i),
                    Test27 = BFM_BasicOperationTest(i),
                    Test28 = BFM_BasicOperationTest(i),
                    Test29 = BFM_BasicOperationTest(i),
                    Test30 = BFM_BasicOperationTest(i)
                    });
            }

            Console.WriteLine("Generate Operation Data Complete !");
            Console.WriteLine("Generate CSV File !");
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(records);
            }

            Console.WriteLine("Success");
        }

        public static void GenerateExecutionTimeCSV()
        {

            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "executionTime.csv");

            var records = new List<CSVRow>();

            for (int i = 1000; i <= 20000; i += 1000)
            {
                Console.WriteLine($"Testing on Element {i} ...");
                records.Add(new CSVRow
                {
                    Elements = i,
                    Test1 = BFM_ExecutionTimeTest(i),
                    Test2 = BFM_ExecutionTimeTest(i),
                    Test3 = BFM_ExecutionTimeTest(i),
                    Test4 = BFM_ExecutionTimeTest(i),
                    Test5 = BFM_ExecutionTimeTest(i),
                    Test6 = BFM_ExecutionTimeTest(i),
                    Test7 = BFM_ExecutionTimeTest(i),
                    Test8 = BFM_ExecutionTimeTest(i),
                    Test9 = BFM_ExecutionTimeTest(i),
                    Test10 = BFM_ExecutionTimeTest(i),
                    Test11 = BFM_ExecutionTimeTest(i),
                    Test12 = BFM_ExecutionTimeTest(i),
                    Test13 = BFM_ExecutionTimeTest(i),
                    Test14 = BFM_ExecutionTimeTest(i),
                    Test15 = BFM_ExecutionTimeTest(i),
                    Test16 = BFM_ExecutionTimeTest(i),
                    Test17 = BFM_ExecutionTimeTest(i),
                    Test18 = BFM_ExecutionTimeTest(i),
                    Test19 = BFM_ExecutionTimeTest(i),
                    Test20 = BFM_ExecutionTimeTest(i),
                    Test21 = BFM_ExecutionTimeTest(i),
                    Test22 = BFM_ExecutionTimeTest(i),
                    Test23 = BFM_ExecutionTimeTest(i),
                    Test24 = BFM_ExecutionTimeTest(i),
                    Test25 = BFM_ExecutionTimeTest(i),
                    Test26 = BFM_ExecutionTimeTest(i),
                    Test27 = BFM_ExecutionTimeTest(i),
                    Test28 = BFM_ExecutionTimeTest(i),
                    Test29 = BFM_ExecutionTimeTest(i),
                    Test30 = BFM_ExecutionTimeTest(i)
                });
            }

            Console.WriteLine("Generate Execution Time Data Complete !");
            Console.WriteLine("Generate CSV File !");
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(records);
            }

            Console.WriteLine("Success");
        }
    }
}
