using Online_Shop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop.Interfaces
{
    internal interface IDelivery
    {
        void DeliverOrder(Order order) 
        {

        }

        void ExpectedDeliveryTime(Order order) 
        {

        }
    }
}
