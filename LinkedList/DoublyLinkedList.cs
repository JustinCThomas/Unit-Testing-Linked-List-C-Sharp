using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class DoublyLinkedList
    {
        public Node Head;
        public Node Tail;

        public DoublyLinkedList(int value)
        {
            Node node = new Node(value);
            Head = node;
            Tail = node;
        }

        public void AddToTail(Node newNode)
        {
            newNode.Previous = Tail;
            newNode.Next = null;
            Tail.Next = newNode;
            Tail = newNode;
        }
    }
}
