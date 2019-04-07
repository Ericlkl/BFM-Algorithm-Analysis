using System;
using System.IO;
using System.Reflection;
using Microsoft.Office.Interop.Excel;

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

        public static void BFM_ExecutionTimeTest(int size)
        {
            var watch = new System.Diagnostics.Stopwatch();

            int[] array = GenerateRandomArray(size);

            watch.Start();

            BFM.BruteForceMedian(array);

            watch.Stop();

            Console.WriteLine($"Array Size : {array.Length}  Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        public static void BFM_BasicOperationTest(int size)
        {
            int[] array = GenerateRandomArray(size);
            int basicOperation = BFM.BruteForceMedian_BO(array);
            Console.WriteLine($"Array Size : {array.Length}  Basic Operation: {basicOperation}");
        }

        public static void GenerateBasicOperationCSV()
        {

            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "file.csv");

            Application xlApp = new Application();

            if (xlApp == null)
            {
                Console.WriteLine("Excel is not properly installed!!");
                return;
            }

            _Worksheet workSheet = (Worksheet)xlApp.ActiveSheet;

            // Establish column headings in cells A1 and B1.
            workSheet.Cells[1, "A"] = "ID Number";
            workSheet.Cells[1, "B"] = "Current Balance";

            workSheet.Cells[2, "A"] = 1;
            workSheet.Cells[2, "B"] = 20000;

            var xlWorkBook = xlApp.Workbooks.Add(workSheet);
            xlApp.Workbooks.Add(xlWorkBook);

            xlApp.Visible = true;
            Console.WriteLine("Success");
        }
    }
}
