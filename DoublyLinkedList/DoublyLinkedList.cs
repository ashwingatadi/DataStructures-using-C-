using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class DoublyLinkedList
    {
        public void InsertingTheNodes()
        {
            Node head = null;
            Console.WriteLine("How many numbers you want to enter");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the number");
                int num = int.Parse(Console.ReadLine());
                head = InsertToTheBeginingOfLinkedList(head, num);
                PrintList(head);
            }
            Console.WriteLine("After inserting number 5 at position at 2");
           
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

        private Node InsertToTheBeginingOfLinkedList(Node head, int num)
        {
            Node node = new Node();
            node.Data = num;
            if (head != null) {
                head.Prev = node;
            } 
            node.Next = head;
            return node;
        }

    }
}
