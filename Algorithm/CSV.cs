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

            for (int i = 0; i <= 20000; i += 1000)
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
                    Test30 = Test.BFM_BasicOperationTest(i),
                    Test31 = Test.BFM_BasicOperationTest(i),
                    Test32 = Test.BFM_BasicOperationTest(i),
                    Test33 = Test.BFM_BasicOperationTest(i),
                    Test34 = Test.BFM_BasicOperationTest(i),
                    Test35 = Test.BFM_BasicOperationTest(i),
                    Test36 = Test.BFM_BasicOperationTest(i),
                    Test37 = Test.BFM_BasicOperationTest(i),
                    Test38 = Test.BFM_BasicOperationTest(i),
                    Test39 = Test.BFM_BasicOperationTest(i),
                    Test40 = Test.BFM_BasicOperationTest(i),
                    Test41 = Test.BFM_BasicOperationTest(i),
                    Test42 = Test.BFM_BasicOperationTest(i),
                    Test43 = Test.BFM_BasicOperationTest(i),
                    Test44 = Test.BFM_BasicOperationTest(i),
                    Test45 = Test.BFM_BasicOperationTest(i),
                    Test46 = Test.BFM_BasicOperationTest(i),
                    Test47 = Test.BFM_BasicOperationTest(i),
                    Test48 = Test.BFM_BasicOperationTest(i),
                    Test49 = Test.BFM_BasicOperationTest(i),
                    Test50 = Test.BFM_BasicOperationTest(i),
                    Test51 = Test.BFM_BasicOperationTest(i),
                    Test52 = Test.BFM_BasicOperationTest(i),
                    Test53 = Test.BFM_BasicOperationTest(i),
                    Test54 = Test.BFM_BasicOperationTest(i),
                    Test55 = Test.BFM_BasicOperationTest(i),
                    Test56 = Test.BFM_BasicOperationTest(i),
                    Test57 = Test.BFM_BasicOperationTest(i),
                    Test58 = Test.BFM_BasicOperationTest(i),
                    Test59 = Test.BFM_BasicOperationTest(i),
                    Test60 = Test.BFM_BasicOperationTest(i),
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

            for (int i = 0; i <= 20000; i += 1000)
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
                    Test30 = Test.BFM_ExecutionTimeTest(i),
                    Test31 = Test.BFM_ExecutionTimeTest(i),
                    Test32 = Test.BFM_ExecutionTimeTest(i),
                    Test33 = Test.BFM_ExecutionTimeTest(i),
                    Test34 = Test.BFM_ExecutionTimeTest(i),
                    Test35 = Test.BFM_ExecutionTimeTest(i),
                    Test36 = Test.BFM_ExecutionTimeTest(i),
                    Test37 = Test.BFM_ExecutionTimeTest(i),
                    Test38 = Test.BFM_ExecutionTimeTest(i),
                    Test39 = Test.BFM_ExecutionTimeTest(i),
                    Test40 = Test.BFM_ExecutionTimeTest(i),
                    Test41 = Test.BFM_ExecutionTimeTest(i),
                    Test42 = Test.BFM_ExecutionTimeTest(i),
                    Test43 = Test.BFM_ExecutionTimeTest(i),
                    Test44 = Test.BFM_ExecutionTimeTest(i),
                    Test45 = Test.BFM_ExecutionTimeTest(i),
                    Test46 = Test.BFM_ExecutionTimeTest(i),
                    Test47 = Test.BFM_ExecutionTimeTest(i),
                    Test48 = Test.BFM_ExecutionTimeTest(i),
                    Test49 = Test.BFM_ExecutionTimeTest(i),
                    Test50 = Test.BFM_ExecutionTimeTest(i),
                    Test51 = Test.BFM_ExecutionTimeTest(i),
                    Test52 = Test.BFM_ExecutionTimeTest(i),
                    Test53 = Test.BFM_ExecutionTimeTest(i),
                    Test54 = Test.BFM_ExecutionTimeTest(i),
                    Test55 = Test.BFM_ExecutionTimeTest(i),
                    Test56 = Test.BFM_ExecutionTimeTest(i),
                    Test57 = Test.BFM_ExecutionTimeTest(i),
                    Test58 = Test.BFM_ExecutionTimeTest(i),
                    Test59 = Test.BFM_ExecutionTimeTest(i),
                    Test60 = Test.BFM_ExecutionTimeTest(i),
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
        public long Test31 { get; set; }
        public long Test32 { get; set; }
        public long Test33 { get; set; }
        public long Test34 { get; set; }
        public long Test35 { get; set; }
        public long Test36 { get; set; }
        public long Test37 { get; set; }
        public long Test38 { get; set; }
        public long Test39 { get; set; }
        public long Test40 { get; set; }
        public long Test41 { get; set; }
        public long Test42 { get; set; }
        public long Test43 { get; set; }
        public long Test44 { get; set; }
        public long Test45 { get; set; }
        public long Test46 { get; set; }
        public long Test47 { get; set; }
        public long Test48 { get; set; }
        public long Test49 { get; set; }
        public long Test50 { get; set; }
        public long Test51 { get; set; }
        public long Test52 { get; set; }
        public long Test53 { get; set; }
        public long Test54 { get; set; }
        public long Test55 { get; set; }
        public long Test56 { get; set; }
        public long Test57 { get; set; }
        public long Test58 { get; set; }
        public long Test59 { get; set; }
        public long Test60 { get; set; }
    }
}