using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    internal class VIPOrder: Order
    {
        public string Present { get; set; }

        public VIPOrder(string name, long phone, float price, string address, string present): base(name, phone, price, address) 
        {
            Present = present;
        }

    }
}
