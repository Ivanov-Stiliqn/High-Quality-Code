using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DynamicListTests
    {
        private DynamicList<int> dynamicList;

        [TestInitialize]
        public void TestInitialize()
        {
            this.dynamicList = new DynamicList<int>();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            
        }

        [TestMethod]
        public void Count_ReturnedValue_ShouldBeCorrect()
        {
            const int ExpectedCount = 4;

            this.dynamicList.Add(10);
            this.dynamicList.Add(11);
            this.dynamicList.Add(12);
            this.dynamicList.Add(13);

            int actualCount = this.dynamicList.Count;
            Assert.AreEqual(ExpectedCount, actualCount, "Count does not return correct number of elements.");
        }

        [TestMethod]
        public void Indexator_ReturnedElement_ShouldBeCorrect()
        {
            const int ExpectedItem = 15;

            for (int item = 10; item < 20; item++)
            {
                this.dynamicList.Add(item);
            }

            var actualItem = this.dynamicList[5];

            Assert.AreEqual(ExpectedItem, actualItem, "Indexator does not return the correct item.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexator_IncorrectInputIndex_ShouldThrow()
        {
            this.dynamicList.Add(3);
            var item = this.dynamicList[2];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexator_SetItemToIncorectIndex_ShouldThrow()
        {
            this.dynamicList.Add(3);
            this.dynamicList.Add(2);

            this.dynamicList[2] = 10;
        }

        [TestMethod]
        public void Remove_DeletedItem_ShouldStopExist()
        {
            this.dynamicList.Add(10);
            this.dynamicList.Add(8);
            this.dynamicList.Add(3);
            this.dynamicList.Add(5);

            int itemToRemove = 8;
            int removedItemExpectedIndex = 1;
            int removedItemActualIndex = this.dynamicList.Remove(itemToRemove);

            Assert.AreEqual(
                removedItemExpectedIndex,
                removedItemActualIndex,
                "Remove method deleted incorrect item.");
        }

        [TestMethod]
        public void Remove_Item_ShouldDecreaseCount()
        {
            const int ExpectedCount = 2;

            this.dynamicList.Add(5);
            this.dynamicList.Add(9);
            this.dynamicList.Add(3);

            this.dynamicList.Remove(9);
            int actualCount = this.dynamicList.Count;

            Assert.AreEqual(ExpectedCount , actualCount, "Remove method does not decrease Count.");
        }

        [TestMethod]
        public void Remove_NoneExistingItem_ShouldReturnMinusOne()
        {
            this.dynamicList.Add(3);
            this.dynamicList.Add(10);

            int expectedReturn = -1;
            int actualReturn = this.dynamicList.Remove(20);

            Assert.AreEqual(
                expectedReturn, 
                actualReturn,
                "Removing non-existing item didnt return -1");
        }

        [TestMethod]
        public void IndexOf_ReturnItemIndex_ShouldBeCorrect()
        {
            this.dynamicList.Add(5);
            this.dynamicList.Add(9);
            this.dynamicList.Add(10);

            int expectedIndex = 1;
            int actualIndex = this.dynamicList.IndexOf(9);

            Assert.AreEqual(
                expectedIndex,
                actualIndex,
                "IndexOf does not return correct item index.");
        }

        [TestMethod]
        public void IndexOf_IncorectIndex_ShouldReturnMinusOne()
        {
            this.dynamicList.Add(5);

            int expectedReturn = -1;
            int actualReturn = this.dynamicList.IndexOf(10);

            Assert.AreEqual(
                expectedReturn,
                actualReturn,               
                "IndexOf does not return -1 to non-existing item.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_IncorectIndex_ShouldThrow()
        {
            this.dynamicList.Add(1);
            this.dynamicList.RemoveAt(5);
        }

        [TestMethod]
        public void RemoveAt_ShouldDecreaseCount()
        {
            const int ExpectedCount = 2;

            this.dynamicList.Add(5);
            this.dynamicList.Add(9);
            this.dynamicList.Add(3);

            this.dynamicList.RemoveAt(1);
            int actualCount = this.dynamicList.Count;

            Assert.AreEqual(ExpectedCount, actualCount, "RemoveAt method does not decrease Count.");
        }

        [TestMethod]
        public void RemoveAt_RemainingItemsIndexes_ShouldBeRemanaged()
        {
            this.dynamicList.Add(10);
            this.dynamicList.Add(8);
            this.dynamicList.Add(3);
            this.dynamicList.Add(5);

            int indexToRemove = 2;
            this.dynamicList.RemoveAt(indexToRemove);
            int itemAtRemovedIndexExpected = 5;
            int itemAtRemovedIndexActual = this.dynamicList[indexToRemove];
            

            Assert.AreEqual(
                itemAtRemovedIndexExpected,
                itemAtRemovedIndexActual,
                "After RemoveAt method performed, the dynamic list does not remanaged remaining items");
        }

        [TestMethod]
        public void Contains_ExistingItem_ShouldReturnTrue()
        {
            this.dynamicList.Add(6);
            this.dynamicList.Add(3);
            this.dynamicList.Add(4);

            bool expectedReturn = true;
            bool actualReturn = this.dynamicList.Contains(6);

            Assert.AreEqual(expectedReturn, actualReturn, "Contains does not work correctly");
        }

        public void Contains_NonExistingItem_ShouldReturnFalse()
        {
            this.dynamicList.Add(6);
            this.dynamicList.Add(3);
            this.dynamicList.Add(4);

            bool expectedReturn = false;
            bool actualReturn = this.dynamicList.Contains(10);

            Assert.AreEqual(expectedReturn, actualReturn, "Contains does not work correctly");
        }
    }
}
