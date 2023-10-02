using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    public class Node<T>
    {
        public T Data { get; set; }
        public  Node<T> Next { get; set; }

        public Node(T data, Node<T> next) 
        {
            Data = data;
            Next = next;
        }
    }
}
