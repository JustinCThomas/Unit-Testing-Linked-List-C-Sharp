using System;
using Xunit;
using LinkedList;

namespace DoublyLinkedListTests
{
    public class DoublyLinkedListsTest
    {
        [Theory]
        [InlineData(5)]
        [InlineData(17)]
        public void AddToTailTest(int value)
        {
            LinkedList.DoublyLinkedList doublyLL = new DoublyLinkedList(value * 2);
            Node newNode = new Node(value);
            doublyLL.AddToTail(newNode);
            Assert.Equal(value, doublyLL.Tail.Value);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(17)]
        public void DeleteTest(int value)
        {
            LinkedList.DoublyLinkedList doublyLL = new DoublyLinkedList(value * 2);
            Node newNode = new Node(99);
            doublyLL.AddToTail(newNode);
            Assert.Equal(true, doublyLL.Tail.Value);
        }


    }
}
