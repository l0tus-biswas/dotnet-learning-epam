using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.DoublyLinkedListEG
{

    public class Node<T>
    {
        public T Data {  get; set; }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }
    }

    public class DoublyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>
            {
                Data = data,
            };

            if(head == null){
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();


            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
        }
    }
}
