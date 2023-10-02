using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    internal class MyList<T>
    {
        public Node<T> Head { get; set; }
        int number;

        public void AddElement(T order)
        {
            if (Head == null) 
            {
                Head = new Node<T>(order, null);
            }
            else
            {
                Head = new Node<T>(order, Head);
            }
            number++;
        }

        public int NumberAvailableElement(T order) 
        {
            Node<T> current = Head;
            int count = -1;

            while (current != null) 
            {
                count++;
                if (current.Data.Equals(order)) 
                {
                    return count;
                }
                current = current.Next;
            }
            return -1;
        }

        public int ActualNumberElementsList() 
        {
            return number;
        }

        public T GetElementByNumber( int count) 
        {
            Node<T> current = Head;

            if (count > number) 
            {
                return default(T);
            }
            while (count > 0) 
            {
                current = current.Next;
                count--;
            }
            return current.Data;
        }

        public bool Remove(T data)
        {
            Node<T> current = Head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        Head = Head.Next;
                    }
                    number--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

    }
}
