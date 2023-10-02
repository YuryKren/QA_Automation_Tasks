using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    internal class MyList<T>
    {
        public OrderNode<T> Head { get; set; }
        public OrderNode<T> Tail { get; set; }
        int number = -1;

        public void AddOrder(T order)
        {
            var node = new OrderNode<T>(order);
            if (Head == null) 
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            number++;
        }
    }
}
