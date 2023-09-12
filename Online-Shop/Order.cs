using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    internal class Order
    {
        private string Product;
        private long PhoneNumber;
        private float Price;
        private string DeliveryAddress;

        public Order( string name, long phone, float price, string address )
        {
            Product = name;
            PhoneNumber = phone;
            Price = price;
            DeliveryAddress = address;
        }

        public string getInformationFromOrder()
        {
            return $"The order for a {Product}, customer phone number {PhoneNumber}, price {Price}, delivery address {DeliveryAddress}";
        }

    }
}
