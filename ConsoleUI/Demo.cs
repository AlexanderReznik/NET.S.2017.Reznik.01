using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Demo
    {
        static void Main(string[] args)
        {
            QSortDemo();
            return;
        }
        public static void QSortDemo()
        {
            Random r = new Random();
            int n = 20;
            int[] arrayToSort = new int[n];
            Console.WriteLine("Qsort demonstration.");
            Console.WriteLine("Array:");
            for (int i = 0; i < n; i++)
            {
                arrayToSort[i] = r.Next() % 1000;
                Console.Write("{0} ", arrayToSort[i]);
            }
            Console.WriteLine();
            ArrayExtension.ArrayExtension.Sort(arrayToSort);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arrayToSort[i]);
            }
            Console.WriteLine();
            Console.Write("Press any key");
            Console.ReadKey();
        }
    }
}
