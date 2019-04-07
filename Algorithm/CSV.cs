using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using CsvHelper;

namespace Algorithm
{
    public class CSV
    {
        public static void GenerateBasicOperationCSV()
        {

            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "basicOperation.csv");

            var records = new List<CSVRow>();

            for (int i = 1000; i <= 20000; i += 1000)
            {
                Console.WriteLine($"Testing on Element {i} ...");
                records.Add(new CSVRow
                {
                    Elements = i,
                    Test1 = Test.BFM_BasicOperationTest(i),
                    Test2 = Test.BFM_BasicOperationTest(i),
                    Test3 = Test.BFM_BasicOperationTest(i),
                    Test4 = Test.BFM_BasicOperationTest(i),
                    Test5 = Test.BFM_BasicOperationTest(i),
                    Test6 = Test.BFM_BasicOperationTest(i),
                    Test7 = Test.BFM_BasicOperationTest(i),
                    Test8 = Test.BFM_BasicOperationTest(i),
                    Test9 = Test.BFM_BasicOperationTest(i),
                    Test10 = Test.BFM_BasicOperationTest(i),
                    Test11 = Test.BFM_BasicOperationTest(i),
                    Test12 = Test.BFM_BasicOperationTest(i),
                    Test13 = Test.BFM_BasicOperationTest(i),
                    Test14 = Test.BFM_BasicOperationTest(i),
                    Test15 = Test.BFM_BasicOperationTest(i),
                    Test16 = Test.BFM_BasicOperationTest(i),
                    Test17 = Test.BFM_BasicOperationTest(i),
                    Test18 = Test.BFM_BasicOperationTest(i),
                    Test19 = Test.BFM_BasicOperationTest(i),
                    Test20 = Test.BFM_BasicOperationTest(i),
                    Test21 = Test.BFM_BasicOperationTest(i),
                    Test22 = Test.BFM_BasicOperationTest(i),
                    Test23 = Test.BFM_BasicOperationTest(i),
                    Test24 = Test.BFM_BasicOperationTest(i),
                    Test25 = Test.BFM_BasicOperationTest(i),
                    Test26 = Test.BFM_BasicOperationTest(i),
                    Test27 = Test.BFM_BasicOperationTest(i),
                    Test28 = Test.BFM_BasicOperationTest(i),
                    Test29 = Test.BFM_BasicOperationTest(i),
                    Test30 = Test.BFM_BasicOperationTest(i)
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
                    Test1 = Test.BFM_ExecutionTimeTest(i),
                    Test2 = Test.BFM_ExecutionTimeTest(i),
                    Test3 = Test.BFM_ExecutionTimeTest(i),
                    Test4 = Test.BFM_ExecutionTimeTest(i),
                    Test5 = Test.BFM_ExecutionTimeTest(i),
                    Test6 = Test.BFM_ExecutionTimeTest(i),
                    Test7 = Test.BFM_ExecutionTimeTest(i),
                    Test8 = Test.BFM_ExecutionTimeTest(i),
                    Test9 = Test.BFM_ExecutionTimeTest(i),
                    Test10 = Test.BFM_ExecutionTimeTest(i),
                    Test11 = Test.BFM_ExecutionTimeTest(i),
                    Test12 = Test.BFM_ExecutionTimeTest(i),
                    Test13 = Test.BFM_ExecutionTimeTest(i),
                    Test14 = Test.BFM_ExecutionTimeTest(i),
                    Test15 = Test.BFM_ExecutionTimeTest(i),
                    Test16 = Test.BFM_ExecutionTimeTest(i),
                    Test17 = Test.BFM_ExecutionTimeTest(i),
                    Test18 = Test.BFM_ExecutionTimeTest(i),
                    Test19 = Test.BFM_ExecutionTimeTest(i),
                    Test20 = Test.BFM_ExecutionTimeTest(i),
                    Test21 = Test.BFM_ExecutionTimeTest(i),
                    Test22 = Test.BFM_ExecutionTimeTest(i),
                    Test23 = Test.BFM_ExecutionTimeTest(i),
                    Test24 = Test.BFM_ExecutionTimeTest(i),
                    Test25 = Test.BFM_ExecutionTimeTest(i),
                    Test26 = Test.BFM_ExecutionTimeTest(i),
                    Test27 = Test.BFM_ExecutionTimeTest(i),
                    Test28 = Test.BFM_ExecutionTimeTest(i),
                    Test29 = Test.BFM_ExecutionTimeTest(i),
                    Test30 = Test.BFM_ExecutionTimeTest(i)
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
    public class CSVRow
    {
        public int Elements { get; set; }
        public long Test1 { get; set; }
        public long Test2 { get; set; }
        public long Test3 { get; set; }
        public long Test4 { get; set; }
        public long Test5 { get; set; }
        public long Test6 { get; set; }
        public long Test7 { get; set; }
        public long Test8 { get; set; }
        public long Test9 { get; set; }
        public long Test10 { get; set; }
        public long Test11 { get; set; }
        public long Test12 { get; set; }
        public long Test13 { get; set; }
        public long Test14 { get; set; }
        public long Test15 { get; set; }
        public long Test16 { get; set; }
        public long Test17 { get; set; }
        public long Test18 { get; set; }
        public long Test19 { get; set; }
        public long Test20 { get; set; }
        public long Test21 { get; set; }
        public long Test22 { get; set; }
        public long Test23 { get; set; }
        public long Test24 { get; set; }
        public long Test25 { get; set; }
        public long Test26 { get; set; }
        public long Test27 { get; set; }
        public long Test28 { get; set; }
        public long Test29 { get; set; }     
        public long Test30 { get; set; }        
    }
}
