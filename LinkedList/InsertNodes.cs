using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class InsertNodes
    {
        public Node InsertToTheBeginingOfLinkedList(Node head, int num)
        {
            Node temp = new Node();
            temp.Data = num;
            temp.Next = head;
            head = temp;
            return head;
        }

        public Node InsertToTheEndOfLinkedList(Node head, int num)
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

        public Node InsertToTheNthPositionOfLinkedList(Node head, int num, int position)
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
    }
}
