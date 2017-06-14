using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SingleLinkedList
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
                head = InsertToTheEndOfLinkedList(head, num);
                PrintList(head);
            }
            Console.WriteLine("After inserting number 5 at position at 2");
            head = InsertToTheNthPositionOfLinkedList(head, 5, 2);
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

        private Node InsertToTheBeginingOfLinkedList(Node head, int num)
        {
            Node node = new Node();
            node.Data = num;
            node.Next = head;
            return node;
        }

        private Node InsertToTheEndOfLinkedList(Node head, int num)
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

        private Node InsertToTheNthPositionOfLinkedList(Node head, int num, int position)
        {
            Node temp = new Node();
            temp.Data = num;

            Node node = head;
            for (int i = 0; i < position - 2; i++)
            {
                head = head.Next;
            }

            temp.Next = head.Next;
            head.Next = temp;


            return node;
        }

        private Node InitializeNodes()
        {
            Node head = null;
            Node node = null;
            for (int i = 10; i > 0; i--)
            {
                node = new Node();
                node.Data = i * i;
                node.Next = head;
                head = node;
            }

            PrintList(head);
            return head;

        }

        public void DeleteTheNodes()
        {
            Node head = InitializeNodes();
            head = DeleteNthNode(head, 11);
            PrintList(head);

        }

        private Node DeleteNthNode(Node head, int position)
        {
            Node node = head;
            for (int i = 1; i < position - 1; i++)
            {
                node = node.Next;
            }
            node.Next = node.Next != null ? node.Next.Next : node.Next;
            return head;
        }

        public void ReverseTheLinkedList()
        {
            Node head = InitializeNodes();
            //Console.WriteLine("Before Reversing the linked list the array is as follows");
            //PrintList(head);
            //head = ReverseUsingIterativeMethod(head);
            head = ReverseUsingResursion(head);
            //Console.WriteLine("After Reversing the linked list the array is as follows");
            PrintList(head);

            //PrintForwardLinkedListRecursion(head);
            //PrintReverseLinkedListRecursion(head);
        }

        private Node ReverseUsingIterativeMethod(Node head)
        {
            Node current = head;
            Node next = null;
            Node prev = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
            return head;
        }

        Node globalHead = new Node();
        private Node ReverseUsingResursion(Node head)
        {
            if (head == null) return globalHead;

            if (head.Next == null)
            {
                globalHead = head;
                return globalHead;
            }

            ReverseUsingResursion(head.Next);
            head.Next.Next = head;
            head.Next = null;
            return globalHead;
        }

        private void PrintForwardLinkedListRecursion(Node head)
        {
            if (head == null)
            {
                return;
            }
            Node node = head;
            head = head.Next;
            Console.Write(node.Data + " ");
            PrintForwardLinkedListRecursion(head);
        }

        private void PrintReverseLinkedListRecursion(Node head)
        {
            if (head == null)
            {
                return;
            }
            Node node = head;
            head = head.Next;

            PrintReverseLinkedListRecursion(head);
            Console.Write(node.Data + " ");

        }

    }
}
