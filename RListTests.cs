using Microsoft.VisualStudio.TestTools.UnitTesting;
using RList;

namespace UnitTestRList
{
    [TestClass]
    public class RListTests
    {
        [TestMethod]
        public void TestCopyConstructor()
        {
            LinkedList original = new LinkedList(1);
            original.Push(2);
            original.Push(3);
            LinkedList subject = new LinkedList(original);
            Assert.AreEqual("1 -> 2 -> 3", subject.Print());
        }

        [TestMethod]
        public void TestFullCopyConstructor()
        {
            LinkedList original = new LinkedList(1);
            original.Push(2);
            original.Push(3);
            LinkedList subject = new LinkedList(original);
            subject.Push(4);
            Assert.AreEqual("1 -> 2 -> 3", original.Print());
        }

        [TestMethod]
        public void TestEmptyCopyConstructor()
        {
            LinkedList original = new LinkedList();
            LinkedList subject = new LinkedList(original);
            Assert.AreEqual(true, subject.IsEmpty());
        }

        [TestMethod]
        public void TestPrintWithNoElements()
        {
            LinkedList subject = new LinkedList();
            Assert.AreEqual("", subject.Print());
        }

        [TestMethod]
        public void TestPrintWithOneElement()
        {
            LinkedList subject = new LinkedList(1);
            Assert.AreEqual("1", subject.Print());
        }

        [TestMethod]
        public void TestPrintWithTwoElements()
        {
            LinkedList subject = new LinkedList(1);
            subject.Push(2);
            Assert.AreEqual("1 -> 2", subject.Print());
        }

        [TestMethod]
        public void TestAddFirst()
        {
            LinkedList subject = new LinkedList(1);
            subject.AddFirst(2);
            Assert.AreEqual("2 -> 1", subject.Print());
        }

        /// DeleteByValue
        [TestMethod]
        public void TestDeleteByValueWithOneElement()
        {
            LinkedList subject = new LinkedList(1);
            subject.DeleteByValue(1);
            Assert.AreEqual(null, subject.Root);
        }

        [TestMethod]
        public void TestDeleteByValueWithSeveralElements()
        {
            LinkedList subject = new LinkedList(1);
            subject.Push(2);
            subject.Push(11);
            subject.Push(4);
            subject.Push(11);
            subject.Push(39);
            subject.Push(0);
            subject.DeleteByValue(11);
            Assert.AreEqual("1 -> 2 -> 4 -> 39 -> 0", subject.Print());
        }

        /// DeleteEvens
        [TestMethod]
        public void TestDeleteEvensWithNoElements()
        {
            LinkedList subject = new LinkedList();
            subject.DeleteEvens();
            Assert.AreEqual("", subject.Print());
        }

        [TestMethod]
        public void TestDeleteEvensWithOneElement()
        {
            LinkedList subject = new LinkedList(1);
            subject.DeleteEvens();
            Assert.AreEqual("1", subject.Print());
        }

        [TestMethod]
        public void TestDeleteEvensWithSeveralElements()
        {
            LinkedList subject = new LinkedList(1);
            subject.Push(2);
            subject.Push(11);
            subject.Push(4);
            subject.Push(11);
            subject.Push(39);
            subject.Push(0);
            subject.DeleteEvens();
            Assert.AreEqual("1 -> 11 -> 11 -> 0", subject.Print());
        }

        /// PrintColumn
        [TestMethod]
        public void TestPrintColumnWithNoElements()
        {
            LinkedList subject = new LinkedList();
            Assert.AreEqual("", subject.PrintColumn());
        }

        [TestMethod]
        public void TestPrintColumnWithOneElement()
        {
            LinkedList subject = new LinkedList();
            subject.Push(1);
            Assert.AreEqual("1", subject.PrintColumn());
        }

        [TestMethod]
        public void TestPrintColumnWithSeveralElements()
        {
            LinkedList subject = new LinkedList();
            subject.Push(1);
            subject.Push(2);
            subject.Push(11);
            subject.Push(4);
            subject.Push(11);
            subject.Push(39);
            subject.Push(0);
            Assert.AreEqual("1\n2\n11\n4\n11\n39\n0", subject.PrintColumn());
        }

        /// SortByAsc
        [TestMethod]
        public void TestSortByAscWithNoElements()
        {
            LinkedList subject = new LinkedList();
            subject.SortByAsc();
            Assert.AreEqual("", subject.Print());
        }

        [TestMethod]
        public void TestSortByAscWithOneElement()
        {
            LinkedList subject = new LinkedList(1);
            subject.SortByAsc();
            Assert.AreEqual("1", subject.Print());
        }

        [TestMethod]
        public void TestSortByAscWithSeveralElements()
        {
            LinkedList subject = new LinkedList(4);
            subject.Push(1);
            subject.Push(2);
            subject.Push(11);
            subject.Push(4);
            subject.Push(11);
            subject.Push(39);
            subject.Push(0);
            subject.SortByAsc();
            Assert.AreEqual("0 -> 1 -> 2 -> 4 -> 4 -> 11 -> 11 -> 39", subject.Print());
        }

        /// Sum
        [TestMethod]
        public void TestSumFromStartWithNoElements()
        {
            LinkedList subject = new LinkedList();
            Assert.AreEqual(0, subject.Sum(0, 1));
        }
        [TestMethod]
        public void TestSumFromStartWithOneElement()
        {
            LinkedList subject = new LinkedList(1);
            Assert.AreEqual(0, subject.Sum(0,1));
        }

        [TestMethod]
        public void TestSumFromSecondWithOneElement()
        {
            LinkedList subject = new LinkedList(1);
            Assert.AreEqual(0, subject.Sum(1, 1));
        }

        [TestMethod]
        public void TestSumFromStartWitTwoElements()
        {
            LinkedList subject = new LinkedList(1);
            subject.Push(2);
            Assert.AreEqual(0, subject.Sum(0, 1));
        }

        [TestMethod]
        public void TestSumNotFromStartWithOneElement()
        {
            LinkedList subject = new LinkedList(1);
            Assert.AreEqual(0, subject.Sum(1, 2));
        }

        [TestMethod]
        public void TestSumNotFromStartWitSeveralElements()
        {
            LinkedList subject = new LinkedList(1);
            subject.Push(2);
            subject.Push(3);
            Assert.AreEqual(0, subject.Sum(1, 2));
        }

        [TestMethod]
        public void TestSumNotFromStartWitSeveralElementsAndGreaterLast()
        {
            LinkedList subject = new LinkedList(1);
            subject.Push(2);
            subject.Push(3);
            Assert.AreEqual(3, subject.Sum(1, 3));
        }

        [TestMethod]
        public void TestSumNotFromStartWitSeveralElementsAndNegativeLast()
        {
            LinkedList subject = new LinkedList(1);
            subject.Push(2);
            subject.Push(3);
            Assert.AreEqual(0, subject.Sum(1, -3));
        }

        [TestMethod]
        public void TestSumNotFromNegativeStartWitSeveralElementsAndNegativeLast()
        {
            LinkedList subject = new LinkedList(1);
            subject.Push(2);
            subject.Push(3);
            Assert.AreEqual(0, subject.Sum(-1, -3));
        }

        [TestMethod]
        public void TestInsertAfterWithEmptyListAndNegativeIndex()
        {
            LinkedList subject = new LinkedList();
            subject.InsertAfter(1, new LinkedList.Node(2));
            Assert.AreEqual("", subject.Print());
        }

        [TestMethod]
        public void TestInsertAfterWithEmptyListAndZeroIndex()
        {
            LinkedList subject = new LinkedList();
            subject.InsertAfter(0, new LinkedList.Node(2));
            Assert.AreEqual("2", subject.Print());
        }

        [TestMethod]
        public void TestInsertAfterWithFilledListAndZeroIndex()
        {
            LinkedList subject = new LinkedList(1);
            subject.Push(3);
            subject.InsertAfter(0, new LinkedList.Node(2));
            Assert.AreEqual("1 -> 2 -> 3", subject.Print());
        }

        [TestMethod]
        public void TestInsertAfterWithFilledListAndPositiveIndex()
        {
            LinkedList subject = new LinkedList(1);
            subject.Push(3);
            subject.InsertAfter(1, new LinkedList.Node(2));
            Assert.AreEqual("1 -> 3 -> 2", subject.Print());
        }
    }
}
