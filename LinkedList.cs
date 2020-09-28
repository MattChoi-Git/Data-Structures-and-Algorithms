using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms_Review_Project
{
   public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class LinkedList
    {
        public Node head;
        private int _size;
        public LinkedList(Node head)
        {
            this.head = head;
            _size = 1;
        }
        public bool Insert(int newData, int index)
        {
            var newNode = new Node(newData);
            //Null check
            if (head == null)
            {
                throw new NullReferenceException("Empty list");
            }
            //Index out of bounds check
            if (index > _size)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            // Add to beginning of list
            if (index == 0)
            {
                newNode.next = head;
                head = newNode;
                Console.WriteLine("LL: Insert operation was successful");
                _size++;
                return true;
            }
            //Loop to find index referenced element to add after
            int counter = 0;
            var refNode = head;
            while(counter < index){
                // Add to end of list
                if (refNode.next == null)
                {
                    refNode.next = new Node(newData);
                    Console.WriteLine("LL: Insert operation was succesful");
                    _size++;
                    return true;
                }
                refNode = refNode.next;
                counter++;
            }
            newNode.next = refNode.next;
            refNode.next = newNode;
            Console.WriteLine("LL: Insert operation was successful");
            _size++;
            return true;

        }
        public bool Print()
        {
            if (head == null)
            {
                throw new NullReferenceException("Empty list");
            }
            var counter = _size;
            var refNode = head;
            while (counter > 0)
            {
                Console.WriteLine(refNode.data);
                refNode = refNode.next;
                counter--;
            }
            return true;
        }
    }
}
