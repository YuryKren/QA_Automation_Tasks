using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shop
{
    
    internal class Order
    {
        public string Product { get; set; }
        public long PhoneNumber { get; set; }
        public float Price {  get; set; }
        public string DeliveryAddress {  get; set; }

        public Order(string name, long phone, float price, string address)
        {
            Product = name;
            PhoneNumber = phone;
            Price = price;
            DeliveryAddress = address;
        }

        public string GetInformationFromOrder()
        {
            return $"The order for a {Product}, client's phone number: {PhoneNumber}, " +
                   $"price: {Price} BYN, delivery address: {DeliveryAddress}";
        }
    }
}
