using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.SingleLinkedListEG
{

    public class Node
    {
        public int data;
        public Node next;
        public Node(int d) {
            data = d;
            next = null;
        }
    }    
  
    public class MyLinkedList
    {

        Node head;

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;
            head = new_node;
        }
        public bool search(Node head, int x)
        {
            if (head == null) { return false; }

            if (head.data == x) { return true; }

            return search(head.next, x);
        }

        
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();
            list.push(10);
                list.push(30);
            list.push(11);
            list.push(21);
            list.push(14);
            list.push(17);

            Console.WriteLine("Linked List: ");
            list.PrintList();


            int x = 21;
            if(list.search(list.head, x))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.Read();
        }
    }
}
