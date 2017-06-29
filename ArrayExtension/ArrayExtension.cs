using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtension
{
    public static class ArrayExtension
    {
        /// <summary>
        /// A class which provides a method for sorting an integer array using QuickSort
        /// </summary>
        public static void Sort(int[] array)
        {
            /// <summary>
            /// Sorts an array of integer
            /// </summary>
            /// <param name="array">
            /// Integer array to sort
            /// </param>
            CheckArray(array);
            SortPart(array, 0, array.Length - 1);
        }
        private static void SortPart(int[] array, int l, int r)
        {
            int x = array[l + (r - l) / 2];
            int i = l;
            int j = r;

            int temp;
            while (i <= j)
            {
                while (array[i] < x)
                    i++;
                while (array[j] > x)
                    j--;

                if (i <= j)
                {
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                    i++;
                    j--;
                }

                if (i < r)
                    SortPart(array, i, r);
                if (l < j)
                    SortPart(array, l, j);
            }
        }
        private static void CheckArray(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException("Array is empty");
        }
    }
}
