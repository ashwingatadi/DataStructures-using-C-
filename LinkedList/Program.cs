using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertingTheNodes();
            
            Console.ReadLine();
        }

        private static void InsertingTheNodes() {
            Node head = null;
            Console.WriteLine("How many numbers you want to enter");
            int n = int.Parse(Console.ReadLine());
            InsertNodes inserts = new InsertNodes();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the number");
                int num = int.Parse(Console.ReadLine());
                //head = inserts.InsertToTheBeginingOfLinkedList(head, num);
                head = inserts.InsertToTheEndOfLinkedList(head, num);
                PrintList(head);
            }
            Console.WriteLine("After inserting number 5 at position at 2");
            head = inserts.InsertToTheNthPositionOfLinkedList(head, 5, 2);
            PrintList(head);
        }

        private static void PrintList(Node head)
        {
            Node temp = head;
            string str = string.Empty;
            while (temp != null)
            {
                str = str + temp.Data + " ";
                temp = temp.Next;
            }
            Console.WriteLine("Array is " + str);
        }
    }
}
