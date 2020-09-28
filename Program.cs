using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms_Review_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Data Structures and Algorithms Bitch");
            var head = new Node(1);
            var linkedList = new LinkedList(head);
            linkedList.Insert(2, 1);
            linkedList.Insert(3, 2);
            linkedList.Insert(4, 3);
            linkedList.Insert(5, 4);
            linkedList.Insert(6, 5);
            linkedList.Print();
            linkedList.Insert(7, 0);
            linkedList.Insert(8, 7);
            linkedList.Insert(8, 9);
            linkedList.Print();

        }
    }
}
