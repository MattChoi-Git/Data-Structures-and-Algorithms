using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms_Review_Project
{
    public class PriorityQueue<T>
    {
        /*Notes:
         * -Queue where we can insert in any order\
         * -When removing an element from the queue, it is always the one with the highest priority
         *      -ie. Handing in homework or paying bills
         * -Rankes elements by key with a total order relation
         *      -Keys define the identity, weight, or rank of the item (non-unique)
         * -If unsorted:
         *      -insertion is O(1)
         *      -MinElement, MinKey, and RemoveMin are O(n)
         *              -Must search through list to find each
         * -If sorted:
         *      -insertion is O(n)
         *          -Have to scan through whole list at worst
         *      -MinElement, MinKey, and RemoveMin are O(1)
         */
        public int Size() // Return the number of items in PQ
        { }
        public bool IsEmpty() // Check if PQ is empty
        { }
        public void InsertItem(Key k, T item) // Insert a new item with key into PQ
        { }
        public T MinElement() // Return the item with the smallest key
        { }
        public Key MinKey() // Return the smalles key in PQ
        { }
        public void RemoveMin() // Remove and return the item with the smallest key in PQ
        { }

    }
    public class Key
    {

    }
}
