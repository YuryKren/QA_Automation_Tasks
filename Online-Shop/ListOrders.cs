using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    internal class ListOrders<T>
    {
        public OrderNode<T> Head { get; set; }

        public void AddOrder(T order)
        {
            if (Head == null) 
            {
                Head = new OrderNode<T>(order, null); 
            }
            else
            {
                Head = new OrderNode<T>(order, Head);
            }
        }
    }
}
