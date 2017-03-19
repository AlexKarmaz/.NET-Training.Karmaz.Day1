using System;
using NUnit.Framework;
using System.Diagnostics;

namespace Task1.Tests
{
    [TestFixture]
    public class SortTests
    {
        [TestCase(new int[] { 1, 100, 50, 51, 1, 1 }, ExpectedResult = new int[] {1, 1, 1, 50, 51, 100})]
        [TestCase(new int[] { 6, 5, -10, 3, 2, 1 }, ExpectedResult = new int[] { -10, 1, 2, 3, 5, 6})]
        [TestCase(new int[] { 0, 0, 0, 0, 0}, ExpectedResult = new int[] { 0, 0, 0, 0, 0})]
        [Test]
        public int[] MergeSort_PositiveTest(int[] arr)
        {
            Sort.MergeSort(arr);
            return arr;
        }

        [TestCase(null)]
        [Test]
        public void MergeSort_ThrowsArgumentNullException(int[] arr)
        {
            Assert.Throws<ArgumentNullException>(() => Sort.MergeSort(arr));
        }

        [TestCase(new int[] { })]
        [Test]
        public void MergeSort_IfArrayLengthIsZero_ThrowsException(int[] arr)
        {
            Assert.Throws<Exception>(() => Sort.MergeSort(arr));
        }

    }
}
