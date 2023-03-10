using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    internal class LinkedList
    {
        Node head;
        public void Addnode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List contains");
                Console.ResetColor();
                Node tempnode = head; ;
                while (tempnode != null)
                {
                    Console.WriteLine(tempnode.data + " ");
                    tempnode = tempnode.Next;
                }
                Console.WriteLine("\n");
            }
        }
        public void Delete()
        {
            Node node = head;
            if (head != null)
            {
                node = head;
                head = head.Next;
                node = null;
            }
        }
        public void DeleteLast()
        {
            Node node = head;
            Node lastnode = node.Next;
            if (head.Next != null)
            {
                node = node.Next;
                node.Next = null;
                lastnode = null;
            }
        }
    }
}
