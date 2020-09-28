using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms_Review_Project
{
    public class Stacks_and_Queues
    {
        /*Notes:
         * -Stacks are LIFO
         * -Qs are FIFO
         * 
         */
    }
    public class Queue
    {
        // Space O(n)
        private Node _head;
        private Node _tail;
        public bool IsEmpty() // O(1)
        { 
        } 
        public int Size() // O(1)
        { 
        } 
        public int Peek() // O(1)
        { 
        }
        public void Add(int data) // O(1)
        { 
        }
        public int Remove() // O(1)
        { 
        }
    }
    public class Stack<T>
    {
        // Space O(n)
        private Node _top;
        private int _size;

        public int Size() // O(1)
        {

        }
        public bool IsEmpty() // O(1)
        {

        }
        public Node Top() // O(1)
        {

        }
        public T Pop() // O(1)
        {

        }
        public void Push(T node) // O(1)
        {

        }
    }
}
