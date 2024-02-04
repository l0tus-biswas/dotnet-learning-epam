using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusArrayList
{
   
    public class LotusArrayList<T>
    {

        private class Node
        {
            public T data;
            public Node next;
            public Node prev;

            public Node(T value)
            {
                data = value;
                next = null;
                prev = null;
            }
            
        }

        private Node head;
        private Node tail;

        #region AddToBack(T value)

        /// <summary>
        /// Adds an object at the end of the LotusArrayList<T>
        /// </summary>
        /// <param name="value">Represent an object or element you want to add</param>
        public void AddToBack(T value)
        {
            Node newnode = new Node(value);

            if(tail == null)
            {
                head = newnode;
                tail = newnode;
            }
            else
            {
                newnode.prev = tail;
                tail.next = newnode;
                tail = newnode;
            }
        }
        #endregion

        #region AddToFront(T value)

        /// <summary>
        /// Adds an object at the back of the LotusArrayList<T>
        /// </summary>
        /// <param name="value">Represent an object or element you want to add</param>
        public void AddToFront(T value)
        {
            Node newnode = new Node(value);
            if(head == null)
            {
                head = newnode;
                tail = newnode;
            }
            else
            {
                newnode.next = head;
                head.prev = newnode;
                head = newnode;
            }
        }
        #endregion


        #region InsertAfterIndex(T value, int index)
        /// <summary>
        /// Adds an object after a specific index LotusArrayList<T>
        /// </summary>
        /// <param name="value">Represent an object or element you want to add</param>
        /// <param name="index">Represent the index, where you want to add</param>
        public void InsertAfterIndex(T value, int index)
        {
            if(index < 0)
            {
                Console.WriteLine("Invalid index. Index should be non-negative");
                return;
            }
            Node newnode = new Node(value);
            Node current = head;
            int currentIndex = 0;

            while(current!=null && currentIndex < index)
            {
                current = current.next;
                currentIndex++;
                    
            }
            if(current == null)
            {
                Console.WriteLine("Invalid index. Index exceeds the size of the list.");
                return;
            }
            newnode.next = current.next;
            newnode.prev = current;

            if(current.next != null)
            {
                current.next.prev = newnode;
            }
            current.next = newnode;

            if(newnode.next == null)
            {
                tail = newnode;
            }
        }

        #endregion


        #region RemoveByValue(T value)

        /// <summary>
        /// Removing an element by its value. If present in the list, it will remove it, else print no found in the list
        /// </summary>
        /// <param name="value">Represent an object or element you want to remove</param>
        public void RemoveByValue(T value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data.Equals(value))
                {
                    if (current.prev != null)
                    {
                        current.prev.next = current.next;
                    }
                    else
                    {
                        head = current.next;
                    }
                    if(current.next != null)
                    {
                        current.next.prev = current.prev;
                    }
                    else
                    {
                        tail = current.prev;
                    }
                }
                else
                {
                    Console.WriteLine("Element nowhere to be found in the list.");
                }
                current = current.next;
            }
        }
        #endregion

        #region Contains(T value)

        /// <summary>
        /// Checks whether the object is present in LotusArrayList<T>.
        /// </summary>
        /// <param name="value">Represent an object or element you want to search</param>
        /// <returns> If present return true or else return false.</returns>
        public bool Contains(T value)
        {
            Node current = head;
            while(current!= null)
            {
                if(current.data.Equals(value))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }
        #endregion

        #region IndexOf(T value)

        /// <summary>
        /// Find the index position of the object present in LotusArrayList<T>. If present return the index number or else return -1 for not found. 
        /// </summary>
        /// <param name="value">Represent an object or element you want to search</param>
        /// <returns></returns>
        public int IndexOf(T value)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                index++;
                if (current.data.Equals(value))
                {
                    return index;
                }
                current = current.next;
            }
            return -1;
        }
        #endregion

        #region Count()
        /// <summary>
        /// Return the number of element in the sequence.
        /// </summary>
        /// <returns>Number of element in the input sequence.</returns>
        public int Count()
        {
            Node current = head;

            int count = 0;
            while (current != null)
            {
                ++count;
                current = current.next;
            }
            return count;
        }
        #endregion

        #region Print()

        /// <summary>
        /// Print all the elements present in the LotusArrayList<T>.
        /// </summary>
        public void Print()
        {
            Node current = head;

            while(current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
        }
        #endregion

    }
}
