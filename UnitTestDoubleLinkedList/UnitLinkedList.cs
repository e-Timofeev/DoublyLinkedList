using DoublyLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestDoubleLinkedList
{
    [TestClass]
    public class UnitLinkedList
    {
        [TestMethod]
        public void AddFirst()
        {
            // arrange
            DoubleLinkedList<int> linkedList = new DoubleLinkedList<int>();
            // act
            linkedList.AddFirst(1);
            // assert
            Assert.AreEqual(1, linkedList.First.Value);            
        }

        [TestMethod]
        public void AddLast()
        {
            // arrange
            DoubleLinkedList<int> linkedList = new DoubleLinkedList<int>();
            // act
            linkedList.AddLast(9);
            // assert
            Assert.AreEqual(9, linkedList.Last.Value);
        }

        [TestMethod]
        public void Reverse()
        {
            // arrange
            DoubleLinkedList<int> linkedList = new DoubleLinkedList<int>();
            // act
            linkedList.AddFirst(1);
            linkedList.AddLast(9);
            linkedList.Reverse();
            // assert
            Assert.AreEqual(9, linkedList.First.Value);         
        }
    }
}
