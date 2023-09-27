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
        public T Head { get; set; }


        public void SetHead(T data) 
        {
            if (Head == null)
            {
                Head = data;
            }
            else 
            {
                Data = Head;
                Head = data;
            }
        }
    }
}
