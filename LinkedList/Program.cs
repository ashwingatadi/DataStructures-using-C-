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
            Node head = null;
            Console.WriteLine("How many numbers you want to enter");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the number");
                int num = int.Parse(Console.ReadLine());
                //head = InsertToTheBeginingOfLinkedList(head, num);
                head = InsertToTheEndOfLinkedList(head, num);
                PrintList(head);
            }
            Console.WriteLine("After inserting number 5 at position at 2");
            head = InsertToTheNthPositionOfLinkedList(head, 5, 2);
            PrintList(head);
            Console.ReadLine();
        }

        private static Node InsertToTheBeginingOfLinkedList(Node head, int num)
        {
            Node temp = new Node();
            temp.Data = num;
            temp.Next = head;
            head = temp;
            return head;
        }

        private static Node InsertToTheEndOfLinkedList(Node head, int num)
        {

            Node temp = new Node();
            temp.Data = num;
            temp.Next = null;
            if (head == null)
            {
                head = temp;
                return head;
            }
            else
            {
                Node node = head;
                while ((head.Next != null))
                {
                    head = head.Next;
                }
                head.Next = temp;
                return node;
            }
        }

        private static Node InsertToTheNthPositionOfLinkedList(Node head, int num, int position)
        {
            Node temp = new Node();
            temp.Data = num;
            //temp.Next = head;

            Node node = head;
            for (int i = 0; i < position - 2; i++) {
                head = head.Next;
            }

            temp.Next = head.Next;
            head.Next = temp; 

            
            return node;
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
