using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    public class OrderNode<T>
    {
        public T Data { get; set; }
        public  OrderNode<T> Next { get; set; }

        public OrderNode(T data, OrderNode<T> next) 
        {
            Data = data;
            Next = next;
        }
    }
}
