using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayExtension.NUnitTests
{
    public class ArrayExtensionTests
    {
        [TestCase(new int[] { 1, 9, 3, 4, 5, 6, 7, 8, 2 })]
        [TestCase(new int[] { -49, 15, 7, 6666, -99, 32 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(new int[] { int.MaxValue, int.MinValue, int.MinValue + 1, int.MaxValue - 1 })]
        [TestCase(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, -1, -2, -3 })]
        public void SortTests(int[] array)
        {
            int[] arraySystem = new int[array.Length];
            Array.Copy(array, arraySystem, array.Length);
            Array.Sort(arraySystem);
            ArrayExtension.Sort(array);

            IStructuralEquatable iArray = arraySystem;
            Assert.IsTrue(iArray.Equals(array, StructuralComparisons.StructuralEqualityComparer));
        }
        [TestCase(new int[] { })]
        public void SortTests_EmptyArray_ArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => ArrayExtension.Sort(array));
        }
        [TestCase(null)]
        public void SortTests_Null_ArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => ArrayExtension.Sort(array));
        }
    }
}
