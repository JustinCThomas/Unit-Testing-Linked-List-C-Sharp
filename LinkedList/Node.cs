using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node
    {
        public int Value;
        public Node Next;
        public Node Previous;

        /// <summary>
        /// Create Node class
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
        } 
    }
}
